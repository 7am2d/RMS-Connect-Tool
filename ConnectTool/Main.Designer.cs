namespace ConnectTool
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clueTestDataSet = new ConnectTool.ClueTestDataSet();
            this.storeTableAdapter = new ConnectTool.ClueTestDataSetTableAdapters.StoreTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hQEventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hQEventLogTableAdapter = new ConnectTool.ClueTestDataSetTableAdapters.HQEventLogTableAdapter();
            this.tableAdapterManager = new ConnectTool.ClueTestDataSetTableAdapters.TableAdapterManager();
            this.hQEventLogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hQEventLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAotu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سلامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioDCostom = new System.Windows.Forms.RadioButton();
            this.radioDLN = new System.Windows.Forms.RadioButton();
            this.radioDNull = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clueTestDataSet1 = new ConnectTool.ClueTestDataSet1();
            this.salesRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesRepTableAdapter = new ConnectTool.ClueTestDataSet1TableAdapters.SalesRepTableAdapter();
            this.tableAdapterManager1 = new ConnectTool.ClueTestDataSet1TableAdapters.TableAdapterManager();
            this.salesRepDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioNull = new System.Windows.Forms.RadioButton();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radio12pm = new System.Windows.Forms.RadioButton();
            this.radio8am = new System.Windows.Forms.RadioButton();
            this.radio9pm = new System.Windows.Forms.RadioButton();
            this.radio5pm = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clueTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hQEventLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hQEventLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hQEventLogBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clueTestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.storeBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 628);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "ID";
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.clueTestDataSet;
            // 
            // clueTestDataSet
            // 
            this.clueTestDataSet.DataSetName = "ClueTestDataSet";
            this.clueTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 27);
            this.textBox1.TabIndex = 1;
            // 
            // hQEventLogBindingSource
            // 
            this.hQEventLogBindingSource.DataMember = "HQEventLog";
            this.hQEventLogBindingSource.DataSource = this.clueTestDataSet;
            // 
            // hQEventLogTableAdapter
            // 
            this.hQEventLogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HQEventLogTableAdapter = this.hQEventLogTableAdapter;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.UpdateOrder = ConnectTool.ClueTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hQEventLogDataGridView
            // 
            this.hQEventLogDataGridView.AllowUserToAddRows = false;
            this.hQEventLogDataGridView.AllowUserToDeleteRows = false;
            this.hQEventLogDataGridView.AutoGenerateColumns = false;
            this.hQEventLogDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.hQEventLogDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.hQEventLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hQEventLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hQEventLogDataGridView.DataSource = this.hQEventLogBindingSource;
            this.hQEventLogDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hQEventLogDataGridView.Location = new System.Drawing.Point(160, 209);
            this.hQEventLogDataGridView.Name = "hQEventLogDataGridView";
            this.hQEventLogDataGridView.ReadOnly = true;
            this.hQEventLogDataGridView.RowHeadersVisible = false;
            this.hQEventLogDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.hQEventLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hQEventLogDataGridView.Size = new System.Drawing.Size(452, 473);
            this.hQEventLogDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn1.FillWeight = 25.33784F;
            this.dataGridViewTextBoxColumn1.HeaderText = "StoreID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EventTime";
            this.dataGridViewTextBoxColumn2.FillWeight = 82.04379F;
            this.dataGridViewTextBoxColumn2.HeaderText = "EventTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EventMessage";
            this.dataGridViewTextBoxColumn3.FillWeight = 192.6184F;
            this.dataGridViewTextBoxColumn3.HeaderText = "EventMessage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // hQEventLogBindingSource1
            // 
            this.hQEventLogBindingSource1.DataMember = "HQEventLog";
            this.hQEventLogBindingSource1.DataSource = this.clueTestDataSet;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(26, 63);
            this.datePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(94, 20);
            this.datePicker.TabIndex = 3;
            // 
            // buttonAotu
            // 
            this.buttonAotu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.buttonAotu.Location = new System.Drawing.Point(461, 23);
            this.buttonAotu.Name = "buttonAotu";
            this.buttonAotu.Size = new System.Drawing.Size(151, 87);
            this.buttonAotu.TabIndex = 8;
            this.buttonAotu.Text = "Auto Check";
            this.buttonAotu.UseVisualStyleBackColor = true;
            this.buttonAotu.Click += new System.EventHandler(this.buttonAotu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سلامToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // سلامToolStripMenuItem
            // 
            this.سلامToolStripMenuItem.Name = "سلامToolStripMenuItem";
            this.سلامToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.سلامToolStripMenuItem.Text = "سلام";
            this.سلامToolStripMenuItem.Click += new System.EventHandler(this.سلامToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseConnectionToolStripMenuItem,
            this.detailsOptionsToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // dataBaseConnectionToolStripMenuItem
            // 
            this.dataBaseConnectionToolStripMenuItem.Name = "dataBaseConnectionToolStripMenuItem";
            this.dataBaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.dataBaseConnectionToolStripMenuItem.Text = "DataBase Connection";
            this.dataBaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.dataBaseConnectionToolStripMenuItem_Click);
            // 
            // detailsOptionsToolStripMenuItem
            // 
            this.detailsOptionsToolStripMenuItem.Name = "detailsOptionsToolStripMenuItem";
            this.detailsOptionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.detailsOptionsToolStripMenuItem.Text = "Details options";
            this.detailsOptionsToolStripMenuItem.Click += new System.EventHandler(this.detailsOptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareInfoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // softwareInfoToolStripMenuItem
            // 
            this.softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            this.softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.softwareInfoToolStripMenuItem.Text = "Software Info.";
            this.softwareInfoToolStripMenuItem.Click += new System.EventHandler(this.softwareInfoToolStripMenuItem_Click);
            // 
            // radioDCostom
            // 
            this.radioDCostom.AutoSize = true;
            this.radioDCostom.Checked = true;
            this.radioDCostom.Location = new System.Drawing.Point(6, 66);
            this.radioDCostom.Name = "radioDCostom";
            this.radioDCostom.Size = new System.Drawing.Size(14, 13);
            this.radioDCostom.TabIndex = 10;
            this.radioDCostom.TabStop = true;
            this.radioDCostom.UseVisualStyleBackColor = true;
            // 
            // radioDLN
            // 
            this.radioDLN.AutoSize = true;
            this.radioDLN.Location = new System.Drawing.Point(6, 43);
            this.radioDLN.Name = "radioDLN";
            this.radioDLN.Size = new System.Drawing.Size(70, 17);
            this.radioDLN.TabIndex = 11;
            this.radioDLN.TabStop = true;
            this.radioDLN.Text = "LastNight";
            this.radioDLN.UseVisualStyleBackColor = true;
            // 
            // radioDNull
            // 
            this.radioDNull.AutoSize = true;
            this.radioDNull.Location = new System.Drawing.Point(6, 20);
            this.radioDNull.Name = "radioDNull";
            this.radioDNull.Size = new System.Drawing.Size(42, 17);
            this.radioDNull.TabIndex = 12;
            this.radioDNull.TabStop = true;
            this.radioDNull.Text = "Null";
            this.radioDNull.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDNull);
            this.groupBox1.Controls.Add(this.radioDLN);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.radioDCostom);
            this.groupBox1.Location = new System.Drawing.Point(295, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اليوم";
            // 
            // clueTestDataSet1
            // 
            this.clueTestDataSet1.DataSetName = "ClueTestDataSet1";
            this.clueTestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesRepBindingSource
            // 
            this.salesRepBindingSource.DataMember = "SalesRep";
            this.salesRepBindingSource.DataSource = this.clueTestDataSet1;
            // 
            // salesRepTableAdapter
            // 
            this.salesRepTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SalesRepTableAdapter = this.salesRepTableAdapter;
            this.tableAdapterManager1.UpdateOrder = ConnectTool.ClueTestDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesRepDataGridView
            // 
            this.salesRepDataGridView.AllowUserToAddRows = false;
            this.salesRepDataGridView.AllowUserToDeleteRows = false;
            this.salesRepDataGridView.AllowUserToResizeRows = false;
            this.salesRepDataGridView.AutoGenerateColumns = false;
            this.salesRepDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesRepDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.salesRepDataGridView.DataSource = this.salesRepBindingSource;
            this.salesRepDataGridView.Location = new System.Drawing.Point(618, 332);
            this.salesRepDataGridView.Name = "salesRepDataGridView";
            this.salesRepDataGridView.ReadOnly = true;
            this.salesRepDataGridView.RowHeadersVisible = false;
            this.salesRepDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.salesRepDataGridView.Size = new System.Drawing.Size(295, 350);
            this.salesRepDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.FillWeight = 35.9589F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 35;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.FillWeight = 178.0461F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 173;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn7.FillWeight = 85.99504F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 84;
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Location = new System.Drawing.Point(618, 309);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPhone.TabIndex = 14;
            this.checkBoxPhone.Text = "Phone";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNull);
            this.groupBox2.Controls.Add(this.TimePicker);
            this.groupBox2.Controls.Add(this.radioCustom);
            this.groupBox2.Controls.Add(this.radio12pm);
            this.groupBox2.Controls.Add(this.radio8am);
            this.groupBox2.Controls.Add(this.radio9pm);
            this.groupBox2.Controls.Add(this.radio5pm);
            this.groupBox2.Location = new System.Drawing.Point(160, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 152);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "التوقيت";
            // 
            // radioNull
            // 
            this.radioNull.AutoSize = true;
            this.radioNull.Checked = true;
            this.radioNull.Location = new System.Drawing.Point(6, 19);
            this.radioNull.Name = "radioNull";
            this.radioNull.Size = new System.Drawing.Size(42, 17);
            this.radioNull.TabIndex = 17;
            this.radioNull.TabStop = true;
            this.radioNull.Text = "Null";
            this.radioNull.UseVisualStyleBackColor = true;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(26, 124);
            this.TimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(89, 20);
            this.TimePicker.TabIndex = 14;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(6, 124);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(14, 13);
            this.radioCustom.TabIndex = 16;
            this.radioCustom.UseVisualStyleBackColor = true;
            // 
            // radio12pm
            // 
            this.radio12pm.AutoSize = true;
            this.radio12pm.Location = new System.Drawing.Point(6, 61);
            this.radio12pm.Name = "radio12pm";
            this.radio12pm.Size = new System.Drawing.Size(70, 17);
            this.radio12pm.TabIndex = 15;
            this.radio12pm.Text = "12:00 PM";
            this.radio12pm.UseVisualStyleBackColor = true;
            // 
            // radio8am
            // 
            this.radio8am.AutoSize = true;
            this.radio8am.Location = new System.Drawing.Point(6, 40);
            this.radio8am.Name = "radio8am";
            this.radio8am.Size = new System.Drawing.Size(71, 17);
            this.radio8am.TabIndex = 13;
            this.radio8am.Text = "08:00 AM";
            this.radio8am.UseVisualStyleBackColor = true;
            // 
            // radio9pm
            // 
            this.radio9pm.AutoSize = true;
            this.radio9pm.Location = new System.Drawing.Point(6, 103);
            this.radio9pm.Name = "radio9pm";
            this.radio9pm.Size = new System.Drawing.Size(70, 17);
            this.radio9pm.TabIndex = 12;
            this.radio9pm.Text = "09:00 PM";
            this.radio9pm.UseVisualStyleBackColor = true;
            // 
            // radio5pm
            // 
            this.radio5pm.AutoSize = true;
            this.radio5pm.Location = new System.Drawing.Point(6, 82);
            this.radio5pm.Name = "radio5pm";
            this.radio5pm.Size = new System.Drawing.Size(70, 17);
            this.radio5pm.TabIndex = 11;
            this.radio5pm.Text = "05:00 PM";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textBox2.Location = new System.Drawing.Point(160, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(183, 30);
            this.textBox2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(618, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(260, 233);
            this.dataGridView1.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 702);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBoxPhone);
            this.Controls.Add(this.salesRepDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAotu);
            this.Controls.Add(this.hQEventLogDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "RMS Connect Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clueTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hQEventLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hQEventLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hQEventLogBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clueTestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRepDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private ClueTestDataSet clueTestDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private ClueTestDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource hQEventLogBindingSource;
        private ClueTestDataSetTableAdapters.HQEventLogTableAdapter hQEventLogTableAdapter;
        private ClueTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hQEventLogDataGridView;
        private System.Windows.Forms.BindingSource hQEventLogBindingSource1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button buttonAotu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseConnectionToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioDCostom;
        private System.Windows.Forms.RadioButton radioDLN;
        private System.Windows.Forms.RadioButton radioDNull;
        private System.Windows.Forms.GroupBox groupBox1;
        private ClueTestDataSet1 clueTestDataSet1;
        private System.Windows.Forms.BindingSource salesRepBindingSource;
        private ClueTestDataSet1TableAdapters.SalesRepTableAdapter salesRepTableAdapter;
        private ClueTestDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView salesRepDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem سلامToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio5pm;
        private System.Windows.Forms.RadioButton radio9pm;
        private System.Windows.Forms.RadioButton radio8am;
        private System.Windows.Forms.RadioButton radio12pm;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.RadioButton radioNull;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInfoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem detailsOptionsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}