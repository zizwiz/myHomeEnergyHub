using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        ///////////////////////////////////////////////
        //             FoxESS Solar Part
        ///////////////////////////////////////////////
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
                BuildDailySolarChart(rows);
            else if (dimension == "month")
                BuildMonthlySolarChart(rows);
            else if (dimension == "year")
                BuildYearlySolarChart(rows);


            // Do after building the chart
            if (dimension == "day")
                ChartUtils.AddSunriseSunsetShading(chartSolar, date,
                    double.Parse(txtbx_latitude.Text),
                    double.Parse(txtbx_longitude.Text));


            ChartUtils.ApplyXAxisLabels(chartSolar, rows, dimension);
            ChartUtils.SetChartTitle(chartSolar, dimension, date);
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

        // Daily Solar Charts - method
        private void BuildDailySolarChart(List<SolarRow> rows)
        {
            double longitude = double.Parse(txtbx_longitude.Text);
            double latitude = double.Parse(txtbx_latitude.Text);
            DateTime date = dtSolarDate.Value;

            ChartUtils.PrepareChart(chartSolar, "day");

            ChartUtils.AddSeries(chartSolar, "Solar", Color.Gold, rows.Select(r => r.PVEnergy).ToList(), date, "day");
            ChartUtils.AddSeries(chartSolar, "Loads", Color.Blue, rows.Select(r => r.Loads).ToList(), date, "day");
            ChartUtils.AddSeries(chartSolar, "Grid Import", Color.Red, rows.Select(r => r.GridConsumption).ToList(), date, "day");
            ChartUtils.AddSeries(chartSolar, "Feed-in", Color.Green, rows.Select(r => r.FeedIn).ToList(), date, "day");

            chartSolar.ChartAreas[0].AxisX.Title = "Time";
            chartSolar.ChartAreas[0].AxisY.Title = "kWh";
        }

        // Weekly Solar Charts - method
        private void BuildMonthlySolarChart(List<SolarRow> rows)
        {
            DateTime date = dtSolarDate.Value;

            ChartUtils.PrepareChart(chartSolar, "month");

            ChartUtils.AddSeries(chartSolar, "Solar", Color.Gold, rows.Select(r => r.PVEnergy).ToList(), date, "month");
            ChartUtils.AddSeries(chartSolar, "Loads", Color.Blue, rows.Select(r => r.Loads).ToList(), date, "month");
            ChartUtils.AddSeries(chartSolar, "Grid Import", Color.Red, rows.Select(r => r.GridConsumption).ToList(), date, "month");
            ChartUtils.AddSeries(chartSolar, "Feed-in", Color.Green, rows.Select(r => r.FeedIn).ToList(), date, "month");

            chartSolar.ChartAreas[0].AxisX.Title = "Day";
            chartSolar.ChartAreas[0].AxisY.Title = "kWh";
        }

        // Annual Solar Charts - method
        private void BuildYearlySolarChart(List<SolarRow> rows)
        {
            DateTime date = dtSolarDate.Value;

            ChartUtils.PrepareChart(chartSolar, "year");

            ChartUtils.AddSeries(chartSolar, "Solar", Color.Gold, rows.Select(r => r.PVEnergy).ToList(), date, "year");
            ChartUtils.AddSeries(chartSolar, "Loads", Color.Blue, rows.Select(r => r.Loads).ToList(), date, "year");
            ChartUtils.AddSeries(chartSolar, "Grid Import", Color.Red, rows.Select(r => r.GridConsumption).ToList(), date, "year");
            ChartUtils.AddSeries(chartSolar, "Feed-in", Color.Green, rows.Select(r => r.FeedIn).ToList(), date, "year");

            chartSolar.ChartAreas[0].AxisX.Title = "Month";
            chartSolar.ChartAreas[0].AxisY.Title = "kWh";
        }
    }
}
