
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_dashboard = new System.Windows.Forms.TabPage();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.btn_fill_data = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPicker_date_to = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_date_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBoth = new System.Windows.Forms.RadioButton();
            this.rdoExport = new System.Windows.Forms.RadioButton();
            this.rdoImport = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.tab_gas_data = new System.Windows.Forms.TabPage();
            this.pnl_common_buttons = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_electricty_data = new System.Windows.Forms.Panel();
            this.pnl_gas_data = new System.Windows.Forms.Panel();
            this.dgvElectric = new System.Windows.Forms.DataGridView();
            this.dgvGas = new System.Windows.Forms.DataGridView();
            this.btnDownloadElectric = new System.Windows.Forms.Button();
            this.btnDownloadGas = new System.Windows.Forms.Button();
            this.cmbobx_hour_to = new System.Windows.Forms.ComboBox();
            this.cmbobx_minute_to = new System.Windows.Forms.ComboBox();
            this.cmbobx_hour_from = new System.Windows.Forms.ComboBox();
            this.cmbobx_minute_from = new System.Windows.Forms.ComboBox();
            this.txtbx_foxess_api_key = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tab_solar_data = new System.Windows.Forms.TabPage();
            this.pnl_solar_data = new System.Windows.Forms.Panel();
            this.dgvSolar = new System.Windows.Forms.DataGridView();
            this.btnDownloadSolar = new System.Windows.Forms.Button();
            this.txtbx_foxess_device_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtSolarDate = new System.Windows.Forms.DateTimePicker();
            this.grpbx_solar = new System.Windows.Forms.GroupBox();
            this.rdobtn_daily = new System.Windows.Forms.RadioButton();
            this.rdobtn_monthly = new System.Windows.Forms.RadioButton();
            this.rdobtn_annually = new System.Windows.Forms.RadioButton();
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_dashboard.SuspendLayout();
            this.pnl_dashboard.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_electric_data.SuspendLayout();
            this.tab_gas_data.SuspendLayout();
            this.pnl_common_buttons.SuspendLayout();
            this.pnl_electricty_data.SuspendLayout();
            this.pnl_gas_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGas)).BeginInit();
            this.tab_solar_data.SuspendLayout();
            this.pnl_solar_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolar)).BeginInit();
            this.grpbx_solar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_common_buttons, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1435, 689);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_dashboard);
            this.tabControl1.Controls.Add(this.tab_electric_data);
            this.tabControl1.Controls.Add(this.tab_gas_data);
            this.tabControl1.Controls.Add(this.tab_solar_data);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1429, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_dashboard
            // 
            this.tab_dashboard.Controls.Add(this.pnl_dashboard);
            this.tab_dashboard.Location = new System.Drawing.Point(4, 29);
            this.tab_dashboard.Name = "tab_dashboard";
            this.tab_dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dashboard.Size = new System.Drawing.Size(1421, 490);
            this.tab_dashboard.TabIndex = 0;
            this.tab_dashboard.Text = "DashBoard";
            this.tab_dashboard.UseVisualStyleBackColor = true;
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.Controls.Add(this.rchtxbx_output);
            this.pnl_dashboard.Controls.Add(this.grpbx_solar);
            this.pnl_dashboard.Controls.Add(this.btnDownloadGas);
            this.pnl_dashboard.Controls.Add(this.btn_fill_data);
            this.pnl_dashboard.Controls.Add(this.groupBox3);
            this.pnl_dashboard.Controls.Add(this.groupBox1);
            this.pnl_dashboard.Controls.Add(this.groupBox2);
            this.pnl_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dashboard.Location = new System.Drawing.Point(3, 3);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(1415, 484);
            this.pnl_dashboard.TabIndex = 0;
            // 
            // btn_fill_data
            // 
            this.btn_fill_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fill_data.Location = new System.Drawing.Point(1218, 406);
            this.btn_fill_data.Name = "btn_fill_data";
            this.btn_fill_data.Size = new System.Drawing.Size(156, 45);
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
            this.groupBox2.Size = new System.Drawing.Size(763, 324);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Octopus Data";
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
            this.tab_electric_data.Size = new System.Drawing.Size(1421, 490);
            this.tab_electric_data.TabIndex = 1;
            this.tab_electric_data.Text = "Electricity Data";
            this.tab_electric_data.UseVisualStyleBackColor = true;
            // 
            // tab_gas_data
            // 
            this.tab_gas_data.Controls.Add(this.pnl_gas_data);
            this.tab_gas_data.Location = new System.Drawing.Point(4, 29);
            this.tab_gas_data.Name = "tab_gas_data";
            this.tab_gas_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_gas_data.Size = new System.Drawing.Size(1421, 490);
            this.tab_gas_data.TabIndex = 2;
            this.tab_gas_data.Text = "Gas Data";
            this.tab_gas_data.UseVisualStyleBackColor = true;
            // 
            // pnl_common_buttons
            // 
            this.pnl_common_buttons.Controls.Add(this.btn_close);
            this.pnl_common_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_common_buttons.Location = new System.Drawing.Point(3, 612);
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
            // pnl_electricty_data
            // 
            this.pnl_electricty_data.Controls.Add(this.dgvElectric);
            this.pnl_electricty_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_electricty_data.Location = new System.Drawing.Point(3, 3);
            this.pnl_electricty_data.Name = "pnl_electricty_data";
            this.pnl_electricty_data.Size = new System.Drawing.Size(1415, 484);
            this.pnl_electricty_data.TabIndex = 0;
            // 
            // pnl_gas_data
            // 
            this.pnl_gas_data.Controls.Add(this.dgvGas);
            this.pnl_gas_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_gas_data.Location = new System.Drawing.Point(3, 3);
            this.pnl_gas_data.Name = "pnl_gas_data";
            this.pnl_gas_data.Size = new System.Drawing.Size(1415, 484);
            this.pnl_gas_data.TabIndex = 0;
            // 
            // dgvElectric
            // 
            this.dgvElectric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElectric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvElectric.Location = new System.Drawing.Point(0, 0);
            this.dgvElectric.Name = "dgvElectric";
            this.dgvElectric.RowHeadersWidth = 62;
            this.dgvElectric.RowTemplate.Height = 28;
            this.dgvElectric.Size = new System.Drawing.Size(1415, 484);
            this.dgvElectric.TabIndex = 0;
            // 
            // dgvGas
            // 
            this.dgvGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGas.Location = new System.Drawing.Point(0, 0);
            this.dgvGas.Name = "dgvGas";
            this.dgvGas.RowHeadersWidth = 62;
            this.dgvGas.RowTemplate.Height = 28;
            this.dgvGas.Size = new System.Drawing.Size(1415, 484);
            this.dgvGas.TabIndex = 0;
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
            // btnDownloadGas
            // 
            this.btnDownloadGas.Location = new System.Drawing.Point(507, 400);
            this.btnDownloadGas.Name = "btnDownloadGas";
            this.btnDownloadGas.Size = new System.Drawing.Size(158, 50);
            this.btnDownloadGas.TabIndex = 34;
            this.btnDownloadGas.Text = "Download Gas";
            this.btnDownloadGas.UseVisualStyleBackColor = true;
            this.btnDownloadGas.Click += new System.EventHandler(this.btnDownloadGas_Click);
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
            // tab_solar_data
            // 
            this.tab_solar_data.Controls.Add(this.pnl_solar_data);
            this.tab_solar_data.Location = new System.Drawing.Point(4, 29);
            this.tab_solar_data.Name = "tab_solar_data";
            this.tab_solar_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_solar_data.Size = new System.Drawing.Size(1421, 490);
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
            this.pnl_solar_data.Size = new System.Drawing.Size(1415, 484);
            this.pnl_solar_data.TabIndex = 0;
            // 
            // dgvSolar
            // 
            this.dgvSolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolar.Location = new System.Drawing.Point(0, 0);
            this.dgvSolar.Name = "dgvSolar";
            this.dgvSolar.RowHeadersWidth = 62;
            this.dgvSolar.RowTemplate.Height = 28;
            this.dgvSolar.Size = new System.Drawing.Size(1415, 484);
            this.dgvSolar.TabIndex = 0;
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
            // dtSolarDate
            // 
            this.dtSolarDate.CustomFormat = "dd-MM-yyyy";
            this.dtSolarDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSolarDate.Location = new System.Drawing.Point(210, 43);
            this.dtSolarDate.Name = "dtSolarDate";
            this.dtSolarDate.Size = new System.Drawing.Size(142, 26);
            this.dtSolarDate.TabIndex = 36;
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
            // rchtxbx_output
            // 
            this.rchtxbx_output.Location = new System.Drawing.Point(813, 377);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(314, 97);
            this.rchtxbx_output.TabIndex = 38;
            this.rchtxbx_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myHomeEnergyHub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_dashboard.ResumeLayout(false);
            this.pnl_dashboard.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_electric_data.ResumeLayout(false);
            this.tab_gas_data.ResumeLayout(false);
            this.pnl_common_buttons.ResumeLayout(false);
            this.pnl_electricty_data.ResumeLayout(false);
            this.pnl_gas_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGas)).EndInit();
            this.tab_solar_data.ResumeLayout(false);
            this.pnl_solar_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolar)).EndInit();
            this.grpbx_solar.ResumeLayout(false);
            this.grpbx_solar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.RichTextBox rchtxbx_output;
    }
}

