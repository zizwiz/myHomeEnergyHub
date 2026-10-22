using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using myHomeEnergyHub.Data;



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
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_fill_data_Click(object sender, EventArgs e)
        {

            PrivateData.FillData(txtbx_api_key, txtbx_electric_serial_num,
                txtbx_electric_import_mpan, txtbx_electric_export_mpan,
                txtbx_gas_serial_num, txtbx_gas_mprn);
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

            var data = await client.GetConsumptionAsync(url);

            dgvGas.DataSource = data.results;
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

    }
}
