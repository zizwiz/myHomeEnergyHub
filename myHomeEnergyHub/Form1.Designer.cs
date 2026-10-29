
namespace myHomeEnergyHub
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_common_buttons = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabctrl_master = new System.Windows.Forms.TabControl();
            this.tab_data = new System.Windows.Forms.TabPage();
            this.tabctrl_data = new System.Windows.Forms.TabControl();
            this.tab_dashboard = new System.Windows.Forms.TabPage();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.grpbx_solar = new System.Windows.Forms.GroupBox();
            this.rdobtn_annually = new System.Windows.Forms.RadioButton();
            this.rdobtn_monthly = new System.Windows.Forms.RadioButton();
            this.rdobtn_daily = new System.Windows.Forms.RadioButton();
            this.dtSolarDate = new System.Windows.Forms.DateTimePicker();
            this.btnDownloadSolar = new System.Windows.Forms.Button();
            this.btnDownloadGas = new System.Windows.Forms.Button();
            this.btn_fill_data = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbobx_minute_to = new System.Windows.Forms.ComboBox();
            this.cmbobx_hour_to = new System.Windows.Forms.ComboBox();
            this.cmbobx_minute_from = new System.Windows.Forms.ComboBox();
            this.cmbobx_hour_from = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPicker_date_to = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_date_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBoth = new System.Windows.Forms.RadioButton();
            this.btnDownloadElectric = new System.Windows.Forms.Button();
            this.rdoExport = new System.Windows.Forms.RadioButton();
            this.rdoImport = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_longitude = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_latitude = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_foxess_device_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_foxess_api_key = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_electric_export_mpan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbx_gas_serial_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_gas_mprn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_electric_serial_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_electric_import_mpan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_api_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_electric_data = new System.Windows.Forms.TabPage();
            this.pnl_electricty_data = new System.Windows.Forms.Panel();
            this.dgvElectric = new System.Windows.Forms.DataGridView();
            this.tab_gas_data = new System.Windows.Forms.TabPage();
            this.pnl_gas_data = new System.Windows.Forms.Panel();
            this.dgvGas = new System.Windows.Forms.DataGridView();
            this.tab_solar_data = new System.Windows.Forms.TabPage();
            this.pnl_solar_data = new System.Windows.Forms.Panel();
            this.dgvSolar = new System.Windows.Forms.DataGridView();
            this.tab_Charts = new System.Windows.Forms.TabPage();
            this.tabCtrl_charts = new System.Windows.Forms.TabControl();
            this.tab_electricity = new System.Windows.Forms.TabPage();
            this.chartElectricity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_gas = new System.Windows.Forms.TabPage();
            this.chartGas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_solar = new System.Windows.Forms.TabPage();
            this.chartSolar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_database_data = new System.Windows.Forms.TabPage();
            this.pnl_database_data = new System.Windows.Forms.Panel();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clbDays = new System.Windows.Forms.CheckedListBox();
            this.clbMonths = new System.Windows.Forms.CheckedListBox();
            this.clbYears = new System.Windows.Forms.CheckedListBox();
            this.btnDrawChart = new System.Windows.Forms.Button();
            this.btnLoadDatabase = new System.Windows.Forms.Button();
            this.grpbx_energy_type = new System.Windows.Forms.GroupBox();
            this.rdoSolar = new System.Windows.Forms.RadioButton();
            this.rdoGas = new System.Windows.Forms.RadioButton();
            this.rdoElectricity = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_common_buttons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabctrl_master.SuspendLayout();
            this.tab_data.SuspendLayout();
            this.tabctrl_data.SuspendLayout();
            this.tab_dashboard.SuspendLayout();
            this.pnl_dashboard.SuspendLayout();
            this.grpbx_solar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_electric_data.SuspendLayout();
            this.pnl_electricty_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).BeginInit();
            this.tab_gas_data.SuspendLayout();
            this.pnl_gas_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGas)).BeginInit();
            this.tab_solar_data.SuspendLayout();
            this.pnl_solar_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolar)).BeginInit();
            this.tab_Charts.SuspendLayout();
            this.tabCtrl_charts.SuspendLayout();
            this.tab_electricity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartElectricity)).BeginInit();
            this.tab_gas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).BeginInit();
            this.tab_solar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSolar)).BeginInit();
            this.tab_database_data.SuspendLayout();
            this.pnl_database_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.grpbx_energy_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_common_buttons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1435, 744);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnl_common_buttons
            // 
            this.pnl_common_buttons.Controls.Add(this.btn_close);
            this.pnl_common_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_common_buttons.Location = new System.Drawing.Point(3, 667);
            this.pnl_common_buttons.Name = "pnl_common_buttons";
            this.pnl_common_buttons.Size = new System.Drawing.Size(1429, 74);
            this.pnl_common_buttons.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1243, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(158, 71);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabctrl_master);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 578);
            this.panel1.TabIndex = 2;
            // 
            // tabctrl_master
            // 
            this.tabctrl_master.Controls.Add(this.tab_data);
            this.tabctrl_master.Controls.Add(this.tab_Charts);
            this.tabctrl_master.Controls.Add(this.tab_database_data);
            this.tabctrl_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_master.Location = new System.Drawing.Point(0, 0);
            this.tabctrl_master.Name = "tabctrl_master";
            this.tabctrl_master.SelectedIndex = 0;
            this.tabctrl_master.Size = new System.Drawing.Size(1429, 578);
            this.tabctrl_master.TabIndex = 0;
            // 
            // tab_data
            // 
            this.tab_data.Controls.Add(this.tabctrl_data);
            this.tab_data.Location = new System.Drawing.Point(4, 29);
            this.tab_data.Name = "tab_data";
            this.tab_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_data.Size = new System.Drawing.Size(1421, 545);
            this.tab_data.TabIndex = 0;
            this.tab_data.Text = "Data";
            this.tab_data.UseVisualStyleBackColor = true;
            // 
            // tabctrl_data
            // 
            this.tabctrl_data.Controls.Add(this.tab_dashboard);
            this.tabctrl_data.Controls.Add(this.tab_electric_data);
            this.tabctrl_data.Controls.Add(this.tab_gas_data);
            this.tabctrl_data.Controls.Add(this.tab_solar_data);
            this.tabctrl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_data.Location = new System.Drawing.Point(3, 3);
            this.tabctrl_data.Name = "tabctrl_data";
            this.tabctrl_data.SelectedIndex = 0;
            this.tabctrl_data.Size = new System.Drawing.Size(1415, 539);
            this.tabctrl_data.TabIndex = 0;
            // 
            // tab_dashboard
            // 
            this.tab_dashboard.Controls.Add(this.pnl_dashboard);
            this.tab_dashboard.Location = new System.Drawing.Point(4, 29);
            this.tab_dashboard.Name = "tab_dashboard";
            this.tab_dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dashboard.Size = new System.Drawing.Size(1407, 506);
            this.tab_dashboard.TabIndex = 0;
            this.tab_dashboard.Text = "DashBoard";
            this.tab_dashboard.UseVisualStyleBackColor = true;
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.Controls.Add(this.grpbx_solar);
            this.pnl_dashboard.Controls.Add(this.btnDownloadGas);
            this.pnl_dashboard.Controls.Add(this.btn_fill_data);
            this.pnl_dashboard.Controls.Add(this.groupBox3);
            this.pnl_dashboard.Controls.Add(this.groupBox1);
            this.pnl_dashboard.Controls.Add(this.groupBox2);
            this.pnl_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dashboard.Location = new System.Drawing.Point(3, 3);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(1401, 500);
            this.pnl_dashboard.TabIndex = 0;
            // 
            // grpbx_solar
            // 
            this.grpbx_solar.Controls.Add(this.rdobtn_annually);
            this.grpbx_solar.Controls.Add(this.rdobtn_monthly);
            this.grpbx_solar.Controls.Add(this.rdobtn_daily);
            this.grpbx_solar.Controls.Add(this.dtSolarDate);
            this.grpbx_solar.Controls.Add(this.btnDownloadSolar);
            this.grpbx_solar.Location = new System.Drawing.Point(16, 254);
            this.grpbx_solar.Name = "grpbx_solar";
            this.grpbx_solar.Size = new System.Drawing.Size(380, 196);
            this.grpbx_solar.TabIndex = 37;
            this.grpbx_solar.TabStop = false;
            this.grpbx_solar.Text = "Solar";
            // 
            // rdobtn_annually
            // 
            this.rdobtn_annually.AutoSize = true;
            this.rdobtn_annually.Location = new System.Drawing.Point(28, 103);
            this.rdobtn_annually.Name = "rdobtn_annually";
            this.rdobtn_annually.Size = new System.Drawing.Size(94, 24);
            this.rdobtn_annually.TabIndex = 39;
            this.rdobtn_annually.Text = "Annually";
            this.rdobtn_annually.UseVisualStyleBackColor = true;
            // 
            // rdobtn_monthly
            // 
            this.rdobtn_monthly.AutoSize = true;
            this.rdobtn_monthly.Location = new System.Drawing.Point(28, 73);
            this.rdobtn_monthly.Name = "rdobtn_monthly";
            this.rdobtn_monthly.Size = new System.Drawing.Size(89, 24);
            this.rdobtn_monthly.TabIndex = 38;
            this.rdobtn_monthly.Text = "Monthly";
            this.rdobtn_monthly.UseVisualStyleBackColor = true;
            // 
            // rdobtn_daily
            // 
            this.rdobtn_daily.AutoSize = true;
            this.rdobtn_daily.Checked = true;
            this.rdobtn_daily.Location = new System.Drawing.Point(28, 43);
            this.rdobtn_daily.Name = "rdobtn_daily";
            this.rdobtn_daily.Size = new System.Drawing.Size(68, 24);
            this.rdobtn_daily.TabIndex = 37;
            this.rdobtn_daily.TabStop = true;
            this.rdobtn_daily.Text = "Daily";
            this.rdobtn_daily.UseVisualStyleBackColor = true;
            // 
            // dtSolarDate
            // 
            this.dtSolarDate.CustomFormat = "dd-MM-yyyy";
            this.dtSolarDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSolarDate.Location = new System.Drawing.Point(210, 43);
            this.dtSolarDate.Name = "dtSolarDate";
            this.dtSolarDate.Size = new System.Drawing.Size(142, 26);
            this.dtSolarDate.TabIndex = 36;
            this.dtSolarDate.Value = new System.DateTime(2026, 10, 25, 13, 57, 13, 0);
            // 
            // btnDownloadSolar
            // 
            this.btnDownloadSolar.Location = new System.Drawing.Point(194, 125);
            this.btnDownloadSolar.Name = "btnDownloadSolar";
            this.btnDownloadSolar.Size = new System.Drawing.Size(158, 50);
            this.btnDownloadSolar.TabIndex = 35;
            this.btnDownloadSolar.Text = "Download Solar";
            this.btnDownloadSolar.UseVisualStyleBackColor = true;
            this.btnDownloadSolar.Click += new System.EventHandler(this.btnDownloadSolar_Click);
            // 
            // btnDownloadGas
            // 
            this.btnDownloadGas.Location = new System.Drawing.Point(429, 252);
            this.btnDownloadGas.Name = "btnDownloadGas";
            this.btnDownloadGas.Size = new System.Drawing.Size(158, 50);
            this.btnDownloadGas.TabIndex = 34;
            this.btnDownloadGas.Text = "Download Gas";
            this.btnDownloadGas.UseVisualStyleBackColor = true;
            this.btnDownloadGas.Click += new System.EventHandler(this.btnDownloadGas_Click);
            // 
            // btn_fill_data
            // 
            this.btn_fill_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fill_data.Location = new System.Drawing.Point(429, 379);
            this.btn_fill_data.Name = "btn_fill_data";
            this.btn_fill_data.Size = new System.Drawing.Size(158, 43);
            this.btn_fill_data.TabIndex = 32;
            this.btn_fill_data.Text = "Fill Data";
            this.btn_fill_data.UseVisualStyleBackColor = true;
            this.btn_fill_data.Click += new System.EventHandler(this.btn_fill_data_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbobx_minute_to);
            this.groupBox3.Controls.Add(this.cmbobx_hour_to);
            this.groupBox3.Controls.Add(this.cmbobx_minute_from);
            this.groupBox3.Controls.Add(this.cmbobx_hour_from);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtPicker_date_to);
            this.groupBox3.Controls.Add(this.dtPicker_date_from);
            this.groupBox3.Location = new System.Drawing.Point(226, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 185);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Span";
            // 
            // cmbobx_minute_to
            // 
            this.cmbobx_minute_to.FormattingEnabled = true;
            this.cmbobx_minute_to.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbobx_minute_to.Location = new System.Drawing.Point(231, 141);
            this.cmbobx_minute_to.Name = "cmbobx_minute_to";
            this.cmbobx_minute_to.Size = new System.Drawing.Size(61, 28);
            this.cmbobx_minute_to.TabIndex = 27;
            // 
            // cmbobx_hour_to
            // 
            this.cmbobx_hour_to.FormattingEnabled = true;
            this.cmbobx_hour_to.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbobx_hour_to.Location = new System.Drawing.Point(170, 141);
            this.cmbobx_hour_to.Name = "cmbobx_hour_to";
            this.cmbobx_hour_to.Size = new System.Drawing.Size(55, 28);
            this.cmbobx_hour_to.TabIndex = 26;
            // 
            // cmbobx_minute_from
            // 
            this.cmbobx_minute_from.FormattingEnabled = true;
            this.cmbobx_minute_from.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbobx_minute_from.Location = new System.Drawing.Point(231, 68);
            this.cmbobx_minute_from.Name = "cmbobx_minute_from";
            this.cmbobx_minute_from.Size = new System.Drawing.Size(61, 28);
            this.cmbobx_minute_from.TabIndex = 25;
            // 
            // cmbobx_hour_from
            // 
            this.cmbobx_hour_from.FormattingEnabled = true;
            this.cmbobx_hour_from.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbobx_hour_from.Location = new System.Drawing.Point(170, 68);
            this.cmbobx_hour_from.Name = "cmbobx_hour_from";
            this.cmbobx_hour_from.Size = new System.Drawing.Size(55, 28);
            this.cmbobx_hour_from.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Period To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Period From:";
            // 
            // dtPicker_date_to
            // 
            this.dtPicker_date_to.CustomFormat = "dd-MM-yyyy";
            this.dtPicker_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_date_to.Location = new System.Drawing.Point(18, 139);
            this.dtPicker_date_to.Name = "dtPicker_date_to";
            this.dtPicker_date_to.Size = new System.Drawing.Size(142, 26);
            this.dtPicker_date_to.TabIndex = 20;
            // 
            // dtPicker_date_from
            // 
            this.dtPicker_date_from.CustomFormat = "dd-MM-yyyy";
            this.dtPicker_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_date_from.Location = new System.Drawing.Point(18, 66);
            this.dtPicker_date_from.Name = "dtPicker_date_from";
            this.dtPicker_date_from.Size = new System.Drawing.Size(142, 26);
            this.dtPicker_date_from.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBoth);
            this.groupBox1.Controls.Add(this.btnDownloadElectric);
            this.groupBox1.Controls.Add(this.rdoExport);
            this.groupBox1.Controls.Add(this.rdoImport);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 196);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Electricity";
            // 
            // rdoBoth
            // 
            this.rdoBoth.AutoSize = true;
            this.rdoBoth.Location = new System.Drawing.Point(20, 99);
            this.rdoBoth.Name = "rdoBoth";
            this.rdoBoth.Size = new System.Drawing.Size(68, 24);
            this.rdoBoth.TabIndex = 4;
            this.rdoBoth.Text = "Both";
            this.rdoBoth.UseVisualStyleBackColor = true;
            // 
            // btnDownloadElectric
            // 
            this.btnDownloadElectric.Location = new System.Drawing.Point(6, 133);
            this.btnDownloadElectric.Name = "btnDownloadElectric";
            this.btnDownloadElectric.Size = new System.Drawing.Size(158, 50);
            this.btnDownloadElectric.TabIndex = 33;
            this.btnDownloadElectric.Text = "Download Electric";
            this.btnDownloadElectric.UseVisualStyleBackColor = true;
            this.btnDownloadElectric.Click += new System.EventHandler(this.btnDownloadElectric_Click);
            // 
            // rdoExport
            // 
            this.rdoExport.AutoSize = true;
            this.rdoExport.Location = new System.Drawing.Point(20, 69);
            this.rdoExport.Name = "rdoExport";
            this.rdoExport.Size = new System.Drawing.Size(80, 24);
            this.rdoExport.TabIndex = 3;
            this.rdoExport.Text = "Export";
            this.rdoExport.UseVisualStyleBackColor = true;
            // 
            // rdoImport
            // 
            this.rdoImport.AutoSize = true;
            this.rdoImport.Checked = true;
            this.rdoImport.Location = new System.Drawing.Point(20, 38);
            this.rdoImport.Name = "rdoImport";
            this.rdoImport.Size = new System.Drawing.Size(80, 24);
            this.rdoImport.TabIndex = 1;
            this.rdoImport.TabStop = true;
            this.rdoImport.Text = "Import";
            this.rdoImport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbx_longitude);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbx_latitude);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtbx_foxess_device_id);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtbx_foxess_api_key);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbx_electric_export_mpan);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtbx_gas_serial_num);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbx_gas_mprn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbx_electric_serial_num);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbx_electric_import_mpan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbx_api_key);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(621, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 416);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Octopus Data";
            // 
            // txtbx_longitude
            // 
            this.txtbx_longitude.Location = new System.Drawing.Point(322, 345);
            this.txtbx_longitude.Name = "txtbx_longitude";
            this.txtbx_longitude.Size = new System.Drawing.Size(412, 26);
            this.txtbx_longitude.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Longitude";
            // 
            // txtbx_latitude
            // 
            this.txtbx_latitude.Location = new System.Drawing.Point(322, 380);
            this.txtbx_latitude.Name = "txtbx_latitude";
            this.txtbx_latitude.Size = new System.Drawing.Size(412, 26);
            this.txtbx_latitude.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Latitude";
            // 
            // txtbx_foxess_device_id
            // 
            this.txtbx_foxess_device_id.Location = new System.Drawing.Point(322, 248);
            this.txtbx_foxess_device_id.Name = "txtbx_foxess_device_id";
            this.txtbx_foxess_device_id.Size = new System.Drawing.Size(412, 26);
            this.txtbx_foxess_device_id.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "FoxESS Device ID";
            // 
            // txtbx_foxess_api_key
            // 
            this.txtbx_foxess_api_key.Location = new System.Drawing.Point(322, 283);
            this.txtbx_foxess_api_key.Name = "txtbx_foxess_api_key";
            this.txtbx_foxess_api_key.Size = new System.Drawing.Size(412, 26);
            this.txtbx_foxess_api_key.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "FoxESS API Key";
            // 
            // txtbx_electric_export_mpan
            // 
            this.txtbx_electric_export_mpan.Location = new System.Drawing.Point(322, 96);
            this.txtbx_electric_export_mpan.Name = "txtbx_electric_export_mpan";
            this.txtbx_electric_export_mpan.Size = new System.Drawing.Size(412, 26);
            this.txtbx_electric_export_mpan.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Electricty export meterpoint\'s MPAN";
            // 
            // txtbx_gas_serial_num
            // 
            this.txtbx_gas_serial_num.Location = new System.Drawing.Point(322, 192);
            this.txtbx_gas_serial_num.Name = "txtbx_gas_serial_num";
            this.txtbx_gas_serial_num.Size = new System.Drawing.Size(412, 26);
            this.txtbx_gas_serial_num.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gas meter\'s serial number";
            // 
            // txtbx_gas_mprn
            // 
            this.txtbx_gas_mprn.Location = new System.Drawing.Point(322, 160);
            this.txtbx_gas_mprn.Name = "txtbx_gas_mprn";
            this.txtbx_gas_mprn.Size = new System.Drawing.Size(412, 26);
            this.txtbx_gas_mprn.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gas meterpoint\'s MPRN";
            // 
            // txtbx_electric_serial_num
            // 
            this.txtbx_electric_serial_num.Location = new System.Drawing.Point(322, 128);
            this.txtbx_electric_serial_num.Name = "txtbx_electric_serial_num";
            this.txtbx_electric_serial_num.Size = new System.Drawing.Size(412, 26);
            this.txtbx_electric_serial_num.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Electricty meter\'s serial number";
            // 
            // txtbx_electric_import_mpan
            // 
            this.txtbx_electric_import_mpan.Location = new System.Drawing.Point(322, 64);
            this.txtbx_electric_import_mpan.Name = "txtbx_electric_import_mpan";
            this.txtbx_electric_import_mpan.Size = new System.Drawing.Size(412, 26);
            this.txtbx_electric_import_mpan.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Electricty import meterpoint\'s MPAN";
            // 
            // txtbx_api_key
            // 
            this.txtbx_api_key.Location = new System.Drawing.Point(322, 32);
            this.txtbx_api_key.Name = "txtbx_api_key";
            this.txtbx_api_key.Size = new System.Drawing.Size(412, 26);
            this.txtbx_api_key.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key";
            // 
            // tab_electric_data
            // 
            this.tab_electric_data.Controls.Add(this.pnl_electricty_data);
            this.tab_electric_data.Location = new System.Drawing.Point(4, 29);
            this.tab_electric_data.Name = "tab_electric_data";
            this.tab_electric_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_electric_data.Size = new System.Drawing.Size(1407, 506);
            this.tab_electric_data.TabIndex = 1;
            this.tab_electric_data.Text = "Electricity Data";
            this.tab_electric_data.UseVisualStyleBackColor = true;
            // 
            // pnl_electricty_data
            // 
            this.pnl_electricty_data.Controls.Add(this.dgvElectric);
            this.pnl_electricty_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_electricty_data.Location = new System.Drawing.Point(3, 3);
            this.pnl_electricty_data.Name = "pnl_electricty_data";
            this.pnl_electricty_data.Size = new System.Drawing.Size(1401, 500);
            this.pnl_electricty_data.TabIndex = 0;
            // 
            // dgvElectric
            // 
            this.dgvElectric.AllowUserToAddRows = false;
            this.dgvElectric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElectric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElectric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvElectric.Location = new System.Drawing.Point(0, 0);
            this.dgvElectric.Name = "dgvElectric";
            this.dgvElectric.ReadOnly = true;
            this.dgvElectric.RowHeadersVisible = false;
            this.dgvElectric.RowHeadersWidth = 62;
            this.dgvElectric.RowTemplate.Height = 28;
            this.dgvElectric.Size = new System.Drawing.Size(1401, 500);
            this.dgvElectric.TabIndex = 0;
            // 
            // tab_gas_data
            // 
            this.tab_gas_data.Controls.Add(this.pnl_gas_data);
            this.tab_gas_data.Location = new System.Drawing.Point(4, 29);
            this.tab_gas_data.Name = "tab_gas_data";
            this.tab_gas_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_gas_data.Size = new System.Drawing.Size(1407, 506);
            this.tab_gas_data.TabIndex = 2;
            this.tab_gas_data.Text = "Gas Data";
            this.tab_gas_data.UseVisualStyleBackColor = true;
            // 
            // pnl_gas_data
            // 
            this.pnl_gas_data.Controls.Add(this.dgvGas);
            this.pnl_gas_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_gas_data.Location = new System.Drawing.Point(3, 3);
            this.pnl_gas_data.Name = "pnl_gas_data";
            this.pnl_gas_data.Size = new System.Drawing.Size(1401, 500);
            this.pnl_gas_data.TabIndex = 0;
            // 
            // dgvGas
            // 
            this.dgvGas.AllowUserToAddRows = false;
            this.dgvGas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGas.Location = new System.Drawing.Point(0, 0);
            this.dgvGas.Name = "dgvGas";
            this.dgvGas.ReadOnly = true;
            this.dgvGas.RowHeadersVisible = false;
            this.dgvGas.RowHeadersWidth = 62;
            this.dgvGas.RowTemplate.Height = 28;
            this.dgvGas.Size = new System.Drawing.Size(1401, 500);
            this.dgvGas.TabIndex = 0;
            // 
            // tab_solar_data
            // 
            this.tab_solar_data.Controls.Add(this.pnl_solar_data);
            this.tab_solar_data.Location = new System.Drawing.Point(4, 29);
            this.tab_solar_data.Name = "tab_solar_data";
            this.tab_solar_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_solar_data.Size = new System.Drawing.Size(1407, 506);
            this.tab_solar_data.TabIndex = 3;
            this.tab_solar_data.Text = "Solar Data";
            this.tab_solar_data.UseVisualStyleBackColor = true;
            // 
            // pnl_solar_data
            // 
            this.pnl_solar_data.Controls.Add(this.dgvSolar);
            this.pnl_solar_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_solar_data.Location = new System.Drawing.Point(3, 3);
            this.pnl_solar_data.Name = "pnl_solar_data";
            this.pnl_solar_data.Size = new System.Drawing.Size(1401, 500);
            this.pnl_solar_data.TabIndex = 0;
            // 
            // dgvSolar
            // 
            this.dgvSolar.AllowUserToAddRows = false;
            this.dgvSolar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolar.Location = new System.Drawing.Point(0, 0);
            this.dgvSolar.Name = "dgvSolar";
            this.dgvSolar.ReadOnly = true;
            this.dgvSolar.RowHeadersVisible = false;
            this.dgvSolar.RowHeadersWidth = 62;
            this.dgvSolar.RowTemplate.Height = 28;
            this.dgvSolar.Size = new System.Drawing.Size(1401, 500);
            this.dgvSolar.TabIndex = 0;
            // 
            // tab_Charts
            // 
            this.tab_Charts.Controls.Add(this.tabCtrl_charts);
            this.tab_Charts.Location = new System.Drawing.Point(4, 29);
            this.tab_Charts.Name = "tab_Charts";
            this.tab_Charts.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Charts.Size = new System.Drawing.Size(1421, 545);
            this.tab_Charts.TabIndex = 1;
            this.tab_Charts.Text = "Charts";
            this.tab_Charts.UseVisualStyleBackColor = true;
            // 
            // tabCtrl_charts
            // 
            this.tabCtrl_charts.Controls.Add(this.tab_electricity);
            this.tabCtrl_charts.Controls.Add(this.tab_gas);
            this.tabCtrl_charts.Controls.Add(this.tab_solar);
            this.tabCtrl_charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl_charts.Location = new System.Drawing.Point(3, 3);
            this.tabCtrl_charts.Name = "tabCtrl_charts";
            this.tabCtrl_charts.SelectedIndex = 0;
            this.tabCtrl_charts.Size = new System.Drawing.Size(1415, 539);
            this.tabCtrl_charts.TabIndex = 0;
            // 
            // tab_electricity
            // 
            this.tab_electricity.Controls.Add(this.chartElectricity);
            this.tab_electricity.Location = new System.Drawing.Point(4, 29);
            this.tab_electricity.Name = "tab_electricity";
            this.tab_electricity.Padding = new System.Windows.Forms.Padding(3);
            this.tab_electricity.Size = new System.Drawing.Size(1407, 506);
            this.tab_electricity.TabIndex = 1;
            this.tab_electricity.Text = "Electricity";
            this.tab_electricity.UseVisualStyleBackColor = true;
            // 
            // chartElectricity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartElectricity.ChartAreas.Add(chartArea1);
            this.chartElectricity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartElectricity.Legends.Add(legend1);
            this.chartElectricity.Location = new System.Drawing.Point(3, 3);
            this.chartElectricity.Name = "chartElectricity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartElectricity.Series.Add(series1);
            this.chartElectricity.Size = new System.Drawing.Size(1401, 500);
            this.chartElectricity.TabIndex = 1;
            this.chartElectricity.Text = "chart1";
            // 
            // tab_gas
            // 
            this.tab_gas.Controls.Add(this.chartGas);
            this.tab_gas.Location = new System.Drawing.Point(4, 29);
            this.tab_gas.Name = "tab_gas";
            this.tab_gas.Size = new System.Drawing.Size(1407, 506);
            this.tab_gas.TabIndex = 2;
            this.tab_gas.Text = "Gas";
            this.tab_gas.UseVisualStyleBackColor = true;
            // 
            // chartGas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGas.ChartAreas.Add(chartArea2);
            this.chartGas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartGas.Legends.Add(legend2);
            this.chartGas.Location = new System.Drawing.Point(0, 0);
            this.chartGas.Name = "chartGas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGas.Series.Add(series2);
            this.chartGas.Size = new System.Drawing.Size(1407, 506);
            this.chartGas.TabIndex = 1;
            this.chartGas.Text = "chart1";
            // 
            // tab_solar
            // 
            this.tab_solar.Controls.Add(this.chartSolar);
            this.tab_solar.Location = new System.Drawing.Point(4, 29);
            this.tab_solar.Name = "tab_solar";
            this.tab_solar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_solar.Size = new System.Drawing.Size(1407, 506);
            this.tab_solar.TabIndex = 0;
            this.tab_solar.Text = "Solar";
            this.tab_solar.UseVisualStyleBackColor = true;
            // 
            // chartSolar
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSolar.ChartAreas.Add(chartArea3);
            this.chartSolar.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartSolar.Legends.Add(legend3);
            this.chartSolar.Location = new System.Drawing.Point(3, 3);
            this.chartSolar.Name = "chartSolar";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSolar.Series.Add(series3);
            this.chartSolar.Size = new System.Drawing.Size(1401, 500);
            this.chartSolar.TabIndex = 0;
            this.chartSolar.Text = "chart1";
            // 
            // tab_database_data
            // 
            this.tab_database_data.Controls.Add(this.pnl_database_data);
            this.tab_database_data.Location = new System.Drawing.Point(4, 29);
            this.tab_database_data.Name = "tab_database_data";
            this.tab_database_data.Size = new System.Drawing.Size(1421, 545);
            this.tab_database_data.TabIndex = 2;
            this.tab_database_data.Text = "Database Data";
            this.tab_database_data.UseVisualStyleBackColor = true;
            // 
            // pnl_database_data
            // 
            this.pnl_database_data.Controls.Add(this.chartMain);
            this.pnl_database_data.Controls.Add(this.clbDays);
            this.pnl_database_data.Controls.Add(this.clbMonths);
            this.pnl_database_data.Controls.Add(this.clbYears);
            this.pnl_database_data.Controls.Add(this.btnDrawChart);
            this.pnl_database_data.Controls.Add(this.btnLoadDatabase);
            this.pnl_database_data.Controls.Add(this.grpbx_energy_type);
            this.pnl_database_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_database_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_database_data.Name = "pnl_database_data";
            this.pnl_database_data.Size = new System.Drawing.Size(1421, 545);
            this.pnl_database_data.TabIndex = 1;
            // 
            // chartMain
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMain.Legends.Add(legend4);
            this.chartMain.Location = new System.Drawing.Point(411, 12);
            this.chartMain.Name = "chartMain";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartMain.Series.Add(series4);
            this.chartMain.Size = new System.Drawing.Size(1007, 507);
            this.chartMain.TabIndex = 13;
            this.chartMain.Text = "chart1";
            // 
            // clbDays
            // 
            this.clbDays.CheckOnClick = true;
            this.clbDays.FormattingEnabled = true;
            this.clbDays.Location = new System.Drawing.Point(229, 354);
            this.clbDays.Name = "clbDays";
            this.clbDays.Size = new System.Drawing.Size(173, 165);
            this.clbDays.TabIndex = 12;
            // 
            // clbMonths
            // 
            this.clbMonths.CheckOnClick = true;
            this.clbMonths.FormattingEnabled = true;
            this.clbMonths.Location = new System.Drawing.Point(229, 183);
            this.clbMonths.Name = "clbMonths";
            this.clbMonths.Size = new System.Drawing.Size(173, 165);
            this.clbMonths.TabIndex = 11;
            // 
            // clbYears
            // 
            this.clbYears.CheckOnClick = true;
            this.clbYears.FormattingEnabled = true;
            this.clbYears.Location = new System.Drawing.Point(229, 12);
            this.clbYears.Name = "clbYears";
            this.clbYears.Size = new System.Drawing.Size(173, 165);
            this.clbYears.TabIndex = 10;
            // 
            // btnDrawChart
            // 
            this.btnDrawChart.Location = new System.Drawing.Point(22, 231);
            this.btnDrawChart.Name = "btnDrawChart";
            this.btnDrawChart.Size = new System.Drawing.Size(189, 45);
            this.btnDrawChart.TabIndex = 5;
            this.btnDrawChart.Text = "Draw Chart";
            this.btnDrawChart.UseVisualStyleBackColor = true;
            this.btnDrawChart.Click += new System.EventHandler(this.btnDrawChart_Click);
            // 
            // btnLoadDatabase
            // 
            this.btnLoadDatabase.Location = new System.Drawing.Point(22, 180);
            this.btnLoadDatabase.Name = "btnLoadDatabase";
            this.btnLoadDatabase.Size = new System.Drawing.Size(189, 45);
            this.btnLoadDatabase.TabIndex = 4;
            this.btnLoadDatabase.Text = "Load Database";
            this.btnLoadDatabase.UseVisualStyleBackColor = true;
            this.btnLoadDatabase.Click += new System.EventHandler(this.btnLoadDatabase_Click);
            // 
            // grpbx_energy_type
            // 
            this.grpbx_energy_type.Controls.Add(this.rdoSolar);
            this.grpbx_energy_type.Controls.Add(this.rdoGas);
            this.grpbx_energy_type.Controls.Add(this.rdoElectricity);
            this.grpbx_energy_type.Location = new System.Drawing.Point(22, 12);
            this.grpbx_energy_type.Name = "grpbx_energy_type";
            this.grpbx_energy_type.Size = new System.Drawing.Size(189, 135);
            this.grpbx_energy_type.TabIndex = 3;
            this.grpbx_energy_type.TabStop = false;
            this.grpbx_energy_type.Text = "Energy Type";
            // 
            // rdoSolar
            // 
            this.rdoSolar.AutoSize = true;
            this.rdoSolar.Location = new System.Drawing.Point(43, 96);
            this.rdoSolar.Name = "rdoSolar";
            this.rdoSolar.Size = new System.Drawing.Size(71, 24);
            this.rdoSolar.TabIndex = 2;
            this.rdoSolar.Text = "Solar";
            this.rdoSolar.UseVisualStyleBackColor = true;
            // 
            // rdoGas
            // 
            this.rdoGas.AutoSize = true;
            this.rdoGas.Location = new System.Drawing.Point(43, 66);
            this.rdoGas.Name = "rdoGas";
            this.rdoGas.Size = new System.Drawing.Size(64, 24);
            this.rdoGas.TabIndex = 1;
            this.rdoGas.Text = "Gas";
            this.rdoGas.UseVisualStyleBackColor = true;
            // 
            // rdoElectricity
            // 
            this.rdoElectricity.AutoSize = true;
            this.rdoElectricity.Checked = true;
            this.rdoElectricity.Location = new System.Drawing.Point(43, 36);
            this.rdoElectricity.Name = "rdoElectricity";
            this.rdoElectricity.Size = new System.Drawing.Size(101, 24);
            this.rdoElectricity.TabIndex = 0;
            this.rdoElectricity.TabStop = true;
            this.rdoElectricity.Text = "Electricity";
            this.rdoElectricity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 744);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myHomeEnergyHub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_common_buttons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabctrl_master.ResumeLayout(false);
            this.tab_data.ResumeLayout(false);
            this.tabctrl_data.ResumeLayout(false);
            this.tab_dashboard.ResumeLayout(false);
            this.pnl_dashboard.ResumeLayout(false);
            this.grpbx_solar.ResumeLayout(false);
            this.grpbx_solar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_electric_data.ResumeLayout(false);
            this.pnl_electricty_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).EndInit();
            this.tab_gas_data.ResumeLayout(false);
            this.pnl_gas_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGas)).EndInit();
            this.tab_solar_data.ResumeLayout(false);
            this.pnl_solar_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolar)).EndInit();
            this.tab_Charts.ResumeLayout(false);
            this.tabCtrl_charts.ResumeLayout(false);
            this.tab_electricity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartElectricity)).EndInit();
            this.tab_gas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).EndInit();
            this.tab_solar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSolar)).EndInit();
            this.tab_database_data.ResumeLayout(false);
            this.pnl_database_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.grpbx_energy_type.ResumeLayout(false);
            this.grpbx_energy_type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabctrl_data;
        private System.Windows.Forms.TabPage tab_dashboard;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Button btn_fill_data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPicker_date_to;
        private System.Windows.Forms.DateTimePicker dtPicker_date_from;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBoth;
        private System.Windows.Forms.RadioButton rdoExport;
        private System.Windows.Forms.RadioButton rdoImport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbx_electric_export_mpan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbx_gas_serial_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_gas_mprn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_electric_serial_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_electric_import_mpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_api_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_electric_data;
        private System.Windows.Forms.TabPage tab_gas_data;
        private System.Windows.Forms.Panel pnl_common_buttons;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_electricty_data;
        private System.Windows.Forms.DataGridView dgvElectric;
        private System.Windows.Forms.Panel pnl_gas_data;
        private System.Windows.Forms.DataGridView dgvGas;
        private System.Windows.Forms.Button btnDownloadGas;
        private System.Windows.Forms.Button btnDownloadElectric;
        private System.Windows.Forms.ComboBox cmbobx_minute_to;
        private System.Windows.Forms.ComboBox cmbobx_hour_to;
        private System.Windows.Forms.ComboBox cmbobx_minute_from;
        private System.Windows.Forms.ComboBox cmbobx_hour_from;
        private System.Windows.Forms.TextBox txtbx_foxess_api_key;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tab_solar_data;
        private System.Windows.Forms.Panel pnl_solar_data;
        private System.Windows.Forms.DataGridView dgvSolar;
        private System.Windows.Forms.Button btnDownloadSolar;
        private System.Windows.Forms.TextBox txtbx_foxess_device_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtSolarDate;
        private System.Windows.Forms.GroupBox grpbx_solar;
        private System.Windows.Forms.RadioButton rdobtn_annually;
        private System.Windows.Forms.RadioButton rdobtn_monthly;
        private System.Windows.Forms.RadioButton rdobtn_daily;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabctrl_master;
        private System.Windows.Forms.TabPage tab_data;
        private System.Windows.Forms.TabPage tab_Charts;
        private System.Windows.Forms.TabControl tabCtrl_charts;
        private System.Windows.Forms.TabPage tab_solar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSolar;
        private System.Windows.Forms.TabPage tab_electricity;
        private System.Windows.Forms.TextBox txtbx_longitude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_latitude;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tab_gas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartElectricity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGas;
        private System.Windows.Forms.TabPage tab_database_data;
        private System.Windows.Forms.Panel pnl_database_data;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.CheckedListBox clbDays;
        private System.Windows.Forms.CheckedListBox clbMonths;
        private System.Windows.Forms.CheckedListBox clbYears;
        private System.Windows.Forms.Button btnDrawChart;
        private System.Windows.Forms.Button btnLoadDatabase;
        private System.Windows.Forms.GroupBox grpbx_energy_type;
        private System.Windows.Forms.RadioButton rdoSolar;
        private System.Windows.Forms.RadioButton rdoGas;
        private System.Windows.Forms.RadioButton rdoElectricity;
    }
}

