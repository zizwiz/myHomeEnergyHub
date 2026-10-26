using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CenteredMessagebox;
using myHomeEnergyHub.Data;
using Newtonsoft.Json;


namespace myHomeEnergyHub
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            Database.Initialize();

            cmbobx_hour_from.SelectedIndex = 0;
            cmbobx_hour_to.SelectedIndex = 0;
            cmbobx_minute_from.SelectedIndex = 0;
            cmbobx_minute_to.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_fill_data_Click(object sender, EventArgs e)
        {

            PrivateData.FillData(txtbx_api_key, txtbx_electric_serial_num,
                txtbx_electric_import_mpan, txtbx_electric_export_mpan,
                txtbx_gas_serial_num, txtbx_gas_mprn, txtbx_foxess_api_key,
                txtbx_foxess_device_id, txtbx_longitude, txtbx_latitude);
        }

        private async void btnDownloadElectric_Click(object sender, EventArgs e)
        {
            try
            {
                var apiKey = txtbx_api_key.Text;

                DateTime from = BuildDateTime(dtPicker_date_from, cmbobx_hour_from, cmbobx_minute_from);
                DateTime to = BuildDateTime(dtPicker_date_to, cmbobx_hour_to, cmbobx_minute_to);


                var client = new OctopusClient(apiKey);

                ConsumptionItem[] importData = new ConsumptionItem[0];
                ConsumptionItem[] exportData = new ConsumptionItem[0];

                // IMPORT
                if (rdoImport.Checked || rdoBoth.Checked)
                {
                    var urlImport = BuildElectricUrl(
                        txtbx_electric_import_mpan.Text,
                        txtbx_electric_serial_num.Text,
                        from,
                        to);

                    var dataImport = await client.GetConsumptionAsync(urlImport);
                    importData = dataImport.results;
                }

                // EXPORT
                if (rdoExport.Checked || rdoBoth.Checked)
                {
                    var urlExport = BuildElectricUrl(
                        txtbx_electric_export_mpan.Text,
                        txtbx_electric_serial_num.Text,
                        from,
                        to);

                    var dataExport = await client.GetConsumptionAsync(urlExport);
                    exportData = dataExport.results;
                }

                // Merge into Import/Export columns
                var merged = MergeImportExport(importData, exportData);

                Database.overwriteMode = OverwriteChoice.Ask; //reset

                foreach (var row in merged)
                {
                    Database.InsertElectricity(row);
                }

                dgvElectric.DataSource = merged;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private async void btnDownloadGas_Click(object sender, EventArgs e)
        {
            var apiKey = txtbx_api_key.Text;
            var mprn = txtbx_gas_mprn.Text;
            var serial = txtbx_gas_serial_num.Text;

            DateTime from = BuildDateTime(dtPicker_date_from, cmbobx_hour_from, cmbobx_minute_from);
            DateTime to = BuildDateTime(dtPicker_date_to, cmbobx_hour_to, cmbobx_minute_to);

            var client = new OctopusClient(apiKey);
            var url = BuildGasUrl(mprn, serial, from, to);

            var gasData = await client.GetConsumptionAsync(url);

            Database.overwriteMode = OverwriteChoice.Ask; //reset
            foreach (var row in gasData.results) // add to database
            {
                Database.InsertGas(row);
            }

            dgvGas.DataSource = gasData.results;
        }

        private string BuildElectricUrl(string mpan, string serial, DateTime from, DateTime to)
        {
            return $"https://api.octopus.energy/v1/electricity-meter-points/{mpan}/meters/{serial}/consumption/" +
                   $"?period_from={from:yyyy-MM-ddTHH:mm:ss}&period_to={to:yyyy-MM-ddTHH:mm:ss}";
        }

        private string BuildGasUrl(string mprn, string serial, DateTime from, DateTime to)
        {
            return $"https://api.octopus.energy/v1/gas-meter-points/{mprn}/meters/{serial}/consumption/" +
                   $"?period_from={from:yyyy-MM-ddTHH:mm:ss}&period_to={to:yyyy-MM-ddTHH:mm:ss}";
        }

        private DateTime BuildDateTime(DateTimePicker date, ComboBox hour, ComboBox minute)
        {
            int h = int.Parse(hour.SelectedItem.ToString());
            int m = int.Parse(minute.SelectedItem.ToString());

            return new DateTime(
                date.Value.Year,
                date.Value.Month,
                date.Value.Day,
                h,
                m,
                0
            );
        }

        private List<CombinedConsumption> MergeImportExport(
            ConsumptionItem[] importData,
            ConsumptionItem[] exportData)
        {
            var combined = new Dictionary<DateTime, CombinedConsumption>();

            // Process import data
            foreach (var item in importData)
            {
                if (!combined.ContainsKey(item.interval_start))
                {
                    combined[item.interval_start] = new CombinedConsumption
                    {
                        interval_start = item.interval_start,
                        interval_end = item.interval_end
                    };
                }

                combined[item.interval_start].Import = item.consumption;
            }

            // Process export data
            foreach (var item in exportData)
            {
                if (!combined.ContainsKey(item.interval_start))
                {
                    combined[item.interval_start] = new CombinedConsumption
                    {
                        interval_start = item.interval_start,
                        interval_end = item.interval_end
                    };
                }

                combined[item.interval_start].Export = item.consumption;
            }

            return combined.Values
                .OrderBy(x => x.interval_start)
                .ToList();
        }

        // FoxESS Solar Part

        private async void btnDownloadSolar_Click(object sender, EventArgs e)
        {
            dgvSolar.DataSource = null;
            dgvSolar.Refresh();

            string apiKey = txtbx_foxess_api_key.Text;
            string deviceSn = txtbx_foxess_device_id.Text;
            DateTime date = dtSolarDate.Value;

            string dimension = "day";
            if (rdobtn_monthly.Checked) dimension = "month";
            if (rdobtn_annually.Checked) dimension = "year";

            // Reset overwrite mode BEFORE inserting
            Database.overwriteMode = OverwriteChoice.Ask;

            string raw = await GetFoxEssDailyReportAsync(apiKey, deviceSn, date, dimension);
            var response = JsonConvert.DeserializeObject<FoxResponse>(raw);

            var rows = BuildSolarRows(response, dimension, date);

            dgvSolar.DataSource = rows;

            foreach (var row in rows)
            {
                Database.InsertSolarRow(row, dimension);
            }

            if (dimension == "day")
                BuildDailyChart(rows);
            else if (dimension == "month")
                BuildMonthlyChart(rows);
            else if (dimension == "year")
                BuildYearlyChart(rows);

            // Do after building the chart
            ApplyXAxisLabels(rows);
            SetChartTitle(dimension, date);
        }


        public static string Md5(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(input);
                var hash = md5.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public static HttpClient BuildFoxEssClient(string apiKey, string path)
        {
            var client = new HttpClient();

            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            // Signature = MD5(path + "\r\n" + token + "\r\n" + timestamp)
            string signatureInput = path + "\r\n" + apiKey + "\r\n" + timestamp;
            string signature = Md5(signatureInput);

            client.DefaultRequestHeaders.Add("Token", apiKey);
            client.DefaultRequestHeaders.Add("Timestamp", timestamp);
            client.DefaultRequestHeaders.Add("Signature", signature);
            client.DefaultRequestHeaders.Add("Lang", "en");
            client.DefaultRequestHeaders.Add("Timezone", "Europe/London");

            return client;
        }

        public async Task<string> GetFoxEssDailyReportAsync(string apiKey, string deviceSn, DateTime date, string myDimension)
        {
            string path = "/op/v0/device/report/query";
            string url = "https://www.foxesscloud.com" + path;

            var client = BuildFoxEssClient(apiKey, path);

            var body = new
            {
                sn = deviceSn,
                variables = new[]
                {
                    "feedin",
                    "gridConsumption",
                    "chargeEnergyToTal",
                    "dischargeEnergyToTal",
                    "loads",
                    "PVEnergyTotal"
                },
                dimension = myDimension,
                year = date.Year,
                month = date.Month,
                day = date.Day
            };


            string json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            string result = await response.Content.ReadAsStringAsync();

            return result;
        }

        public List<SolarRow> BuildSolarRows(FoxResponse response, string dimension, DateTime date)
        {
            if (response == null)
            {
                MsgBox.Show("Check the information sent is correct", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            var rows = new List<SolarRow>();
            int count = response.result[0].values.Length;

            for (int i = 0; i < count; i++)
            {
                var row = new SolarRow();

                // REAL date stored internally
                row.Date = date;

                // PRETTY date for UI
                if (dimension == "day")
                    row.DisplayDate = date.ToString("dd MMM yyyy");
                else if (dimension == "month")
                    row.DisplayDate = date.ToString("MMM yyyy");
                else if (dimension == "year")
                    row.DisplayDate = date.ToString("yyyy");

                // Period label
                if (dimension == "day")
                    row.Period = $"{i:00}:00";
                else if (dimension == "month")
                    row.Period = $"Day {i + 1}";
                else if (dimension == "year")
                    row.Period = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1);

                // Fill values
                foreach (var item in response.result)
                {
                    decimal value = item.values[i];

                    switch (item.variable)
                    {
                        case "feedin": row.FeedIn = value; break;
                        case "gridConsumption": row.GridConsumption = value; break;
                        case "chargeEnergyToTal": row.ChargeEnergy = value; break;
                        case "dischargeEnergyToTal": row.DischargeEnergy = value; break;
                        case "loads": row.Loads = value; break;
                        case "PVEnergyTotal": row.PVEnergy = value; break;
                    }
                }

                rows.Add(row);
            }
            return rows;
        }


        ////////////////////////////////////////////////////////////////////////////
        /// Solar Charting
        ////////////////////////////////////////////////////////////////////////////

        // Solar Chart Helper
        private void PrepareChart()
        {
            chartSolar.Series.Clear();
            chartSolar.ChartAreas.Clear();

            var area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartSolar.ChartAreas.Add(area);
        }

        // Daily Solar Charts - method
        private void BuildDailyChart(List<SolarRow> rows)
        {
            double longitude = double.Parse(txtbx_longitude.Text);
            double latitude = double.Parse(txtbx_latitude.Text);

            PrepareChart();

            AddSeries("Solar", Color.Gold, rows.Select(r => r.PVEnergy).ToList());
            AddSeries("Loads", Color.Blue, rows.Select(r => r.Loads).ToList());
            AddSeries("Grid Import", Color.Red, rows.Select(r => r.GridConsumption).ToList());
            AddSeries("Feed-in", Color.Green, rows.Select(r => r.FeedIn).ToList());

            chartSolar.ChartAreas[0].AxisX.Title = "Time";
            chartSolar.ChartAreas[0].AxisY.Title = "kWh";

            DateTime date = dtSolarDate.Value;

            // work out Sunrise and Sunset times
            var sun = new Sunriset();
            double sunriseUTC = sun.CalculateSunTime(date, latitude, longitude, true);
            double sunsetUTC = sun.CalculateSunTime(date, latitude, longitude, false);

            // Convert UTC → local time
            DateTime sunrise = date.Date.AddHours(sunriseUTC).ToLocalTime();
            DateTime sunset = date.Date.AddHours(sunsetUTC).ToLocalTime();

            // Convert to X-axis positions (1–24)
            int sunriseX = sunrise.Hour + 1;
            int sunsetX = sunset.Hour + 1;

            // Add sunrise and Sunset Vertical lines
            var area = chartSolar.ChartAreas[0];

            var sunriseLine = new StripLine
            {
                BorderColor = Color.Red,
                BorderWidth = 2,
                BorderDashStyle = ChartDashStyle.Solid,
                IntervalOffset = sunriseX,
                ToolTip = $"Sunrise: {sunrise:HH:mm}"
            };

            var sunsetLine = new StripLine
            {
                BorderColor = Color.Red,
                BorderWidth = 2,
                BorderDashStyle = ChartDashStyle.Solid,
                IntervalOffset = sunsetX,
                ToolTip = $"Sunset: {sunset:HH:mm}"
            };

            area.AxisX.StripLines.Add(sunriseLine);
            area.AxisX.StripLines.Add(sunsetLine);

            // Add night Shading
            var night1 = new StripLine
            {
                BackColor = Color.FromArgb(40, Color.DarkBlue),
                StripWidth = sunriseX - 1, // midnight → sunrise
                IntervalOffset = 1
            };

            var night2 = new StripLine
            {
                BackColor = Color.FromArgb(40, Color.DarkBlue),
                StripWidth = 24 - sunsetX, // sunset → midnight
                IntervalOffset = sunsetX
            };

            //Add Daylight shading
            var day = new StripLine
            {
                BackColor = Color.FromArgb(40, Color.Yellow),
                StripWidth = sunsetX - sunriseX,
                IntervalOffset = sunriseX
            };

            DateTime yesterday = date.AddDays(-1);
            DateTime start = yesterday.Date.AddHours(23).AddMinutes(00);
            DateTime end = date.Date;

            var beforeNight1 = new StripLine
            {
                BackColor = Color.FromArgb(40, Color.DarkBlue),
                IntervalOffset = start.ToOADate(),
                StripWidth = end.ToOADate() - start.ToOADate()
            };

            area.AxisX.StripLines.Add(beforeNight1);
            area.AxisX.StripLines.Add(night1);
            area.AxisX.StripLines.Add(day);
            area.AxisX.StripLines.Add(night2);

        }

        // Weekly Solar Charts - method
        private void BuildMonthlyChart(List<SolarRow> rows)
        {
            PrepareChart();

            AddSeries("Solar", Color.Gold, rows.Select(r => r.PVEnergy).ToList());
            AddSeries("Loads", Color.Blue, rows.Select(r => r.Loads).ToList());
            AddSeries("Grid Import", Color.Red, rows.Select(r => r.GridConsumption).ToList());
            AddSeries("Feed-in", Color.Green, rows.Select(r => r.FeedIn).ToList());

            chartSolar.ChartAreas[0].AxisX.Title = "Day";
            chartSolar.ChartAreas[0].AxisY.Title = "kWh";
        }

        // Annual Solar Charts - method
        private void BuildYearlyChart(List<SolarRow> rows)
        {
            PrepareChart();

            AddSeries("Solar", Color.Gold, rows.Select(r => r.PVEnergy).ToList());
            AddSeries("Loads", Color.Blue, rows.Select(r => r.Loads).ToList());
            AddSeries("Grid Import", Color.Red, rows.Select(r => r.GridConsumption).ToList());
            AddSeries("Feed-in", Color.Green, rows.Select(r => r.FeedIn).ToList());

            chartSolar.ChartAreas[0].AxisX.Title = "Month";
            chartSolar.ChartAreas[0].AxisY.Title = "kWh";
        }


        // Solar Chart Helper to Add Series
        private void AddSeries(string name, Color color, List<decimal> values)
        {
            var series = new Series(name);
            series.ChartType = SeriesChartType.Line;
            series.Color = color;
            series.BorderWidth = 2;
            int p;

            for (int i = 0; i < values.Count; i++)
            {
                series.Points.AddXY(i + 1, (double)values[i]);
                p = series.Points.AddXY(i + 1, (double)values[i]);
                series.Points[p].ToolTip = $"{name}: {values[i]:0.###} kWh";
            }

            chartSolar.Series.Add(series);
        }

        private void ApplyXAxisLabels(List<SolarRow> rows)
        {
            var area = chartSolar.ChartAreas[0];
            area.AxisX.CustomLabels.Clear();

            for (int i = 0; i < rows.Count; i++)
            {
                var lbl = new CustomLabel();
                lbl.FromPosition = i + 0.5;
                lbl.ToPosition = i + 1.5;
                lbl.Text = rows[i].Period;

                area.AxisX.CustomLabels.Add(lbl);
            }
        }

        private void SetChartTitle(string dimension, DateTime date)
        {
            chartSolar.Titles.Clear();

            string title = "Solar Chart";

            switch (dimension)
            {
                case "day":
                    title += $" — {date:dd MMM yyyy}";
                    break;
                case "month":
                    title += $" — {date:MMM yyyy}";
                    break;
                case "year":
                    title += $" — {date:yyyy}";
                    break;
            }

            chartSolar.Titles.Add(title);
            chartSolar.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

    }
}
