using System;

namespace DBapplication
{
    partial class Lab5
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
            this.addDepGrpBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.empSuperSSNLbl = new System.Windows.Forms.Label();
            this.DepNumber = new System.Windows.Forms.NumericUpDown();
            this.DepMngrStartDateLbl = new System.Windows.Forms.Label();
            this.empSsnLbl = new System.Windows.Forms.Label();
            this.DepNameLbl = new System.Windows.Forms.Label();
            this.depNameTxtBox = new System.Windows.Forms.TextBox();
            this.addDepBtn = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDBLab42EDataSet = new DBapplication.CompanyDBLab42EDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddPrjGrpBox = new System.Windows.Forms.GroupBox();
            this.PrjNo = new System.Windows.Forms.NumericUpDown();
            this.LnkDepComboBox = new System.Windows.Forms.ComboBox();
            this.LnkDepLbl = new System.Windows.Forms.Label();
            this.PrjNumLbl = new System.Windows.Forms.Label();
            this.prjLocLbl = new System.Windows.Forms.Label();
            this.prjLocTxtBox = new System.Windows.Forms.TextBox();
            this.prjNameLbl = new System.Windows.Forms.Label();
            this.PrjNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddPrjBtn = new System.Windows.Forms.Button();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.getPrjEmpLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.getPrjEmpBtn = new System.Windows.Forms.Button();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new DBapplication.CompanyDBLab42EDataSetTableAdapters.EmployeeTableAdapter();
            this.departmentTableAdapter = new DBapplication.CompanyDBLab42EDataSetTableAdapters.DepartmentTableAdapter();
            this.projectTableAdapter = new DBapplication.CompanyDBLab42EDataSetTableAdapters.ProjectTableAdapter();
            this.AddDepLocGrpBox = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DepNoLoc = new System.Windows.Forms.Label();
            this.DepLocLbl = new System.Windows.Forms.Label();
            this.DepLocTxtBox = new System.Windows.Forms.TextBox();
            this.AddDepLocBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addDepGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBLab42EDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.AddPrjGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrjNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.ViewInfoGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.AddDepLocGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDepGrpBox
            // 
            this.addDepGrpBox.Controls.Add(this.label3);
            this.addDepGrpBox.Controls.Add(this.textBox3);
            this.addDepGrpBox.Controls.Add(this.textBox2);
            this.addDepGrpBox.Controls.Add(this.label1);
            this.addDepGrpBox.Controls.Add(this.textBox1);
            this.addDepGrpBox.Controls.Add(this.empSuperSSNLbl);
            this.addDepGrpBox.Controls.Add(this.DepNumber);
            this.addDepGrpBox.Controls.Add(this.DepMngrStartDateLbl);
            this.addDepGrpBox.Controls.Add(this.empSsnLbl);
            this.addDepGrpBox.Controls.Add(this.DepNameLbl);
            this.addDepGrpBox.Controls.Add(this.depNameTxtBox);
            this.addDepGrpBox.Controls.Add(this.addDepBtn);
            this.addDepGrpBox.Location = new System.Drawing.Point(12, 12);
            this.addDepGrpBox.Name = "addDepGrpBox";
            this.addDepGrpBox.Size = new System.Drawing.Size(714, 237);
            this.addDepGrpBox.TabIndex = 19;
            this.addDepGrpBox.TabStop = false;
            this.addDepGrpBox.Text = "Add Employee";
            this.addDepGrpBox.Enter += new System.EventHandler(this.addDepGrpBox_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 116);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 64;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 156);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Employee Second Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 61;
            // 
            // empSuperSSNLbl
            // 
            this.empSuperSSNLbl.AutoSize = true;
            this.empSuperSSNLbl.Location = new System.Drawing.Point(20, 116);
            this.empSuperSSNLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empSuperSSNLbl.Name = "empSuperSSNLbl";
            this.empSuperSSNLbl.Size = new System.Drawing.Size(102, 17);
            this.empSuperSSNLbl.TabIndex = 60;
            this.empSuperSSNLbl.Text = "Employee SSN";
            // 
            // DepNumber
            // 
            this.DepNumber.Location = new System.Drawing.Point(164, 74);
            this.DepNumber.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.DepNumber.Name = "DepNumber";
            this.DepNumber.Size = new System.Drawing.Size(120, 22);
            this.DepNumber.TabIndex = 58;
            this.DepNumber.ValueChanged += new System.EventHandler(this.DepNumber_ValueChanged);
            // 
            // DepMngrStartDateLbl
            // 
            this.DepMngrStartDateLbl.AutoSize = true;
            this.DepMngrStartDateLbl.Location = new System.Drawing.Point(20, 156);
            this.DepMngrStartDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepMngrStartDateLbl.Name = "DepMngrStartDateLbl";
            this.DepMngrStartDateLbl.Size = new System.Drawing.Size(37, 17);
            this.DepMngrStartDateLbl.TabIndex = 46;
            this.DepMngrStartDateLbl.Text = "Minit";
            // 
            // empSsnLbl
            // 
            this.empSsnLbl.AutoSize = true;
            this.empSsnLbl.Location = new System.Drawing.Point(20, 74);
            this.empSsnLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empSsnLbl.Name = "empSsnLbl";
            this.empSsnLbl.Size = new System.Drawing.Size(136, 17);
            this.empSsnLbl.TabIndex = 45;
            this.empSsnLbl.Text = "Department Number";
            // 
            // DepNameLbl
            // 
            this.DepNameLbl.AutoSize = true;
            this.DepNameLbl.Location = new System.Drawing.Point(20, 38);
            this.DepNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepNameLbl.Name = "DepNameLbl";
            this.DepNameLbl.Size = new System.Drawing.Size(142, 17);
            this.DepNameLbl.TabIndex = 44;
            this.DepNameLbl.Text = "Employee First Name";
            // 
            // depNameTxtBox
            // 
            this.depNameTxtBox.Location = new System.Drawing.Point(164, 38);
            this.depNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.depNameTxtBox.Name = "depNameTxtBox";
            this.depNameTxtBox.Size = new System.Drawing.Size(132, 22);
            this.depNameTxtBox.TabIndex = 42;
            this.depNameTxtBox.TextChanged += new System.EventHandler(this.depNameTxtBox_TextChanged);
            // 
            // addDepBtn
            // 
            this.addDepBtn.Location = new System.Drawing.Point(538, 199);
            this.addDepBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addDepBtn.Name = "addDepBtn";
            this.addDepBtn.Size = new System.Drawing.Size(147, 31);
            this.addDepBtn.TabIndex = 41;
            this.addDepBtn.Text = "Add Empolyee";
            this.addDepBtn.UseVisualStyleBackColor = true;
            this.addDepBtn.Click += new System.EventHandler(this.addDepBtn_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.companyDBLab42EDataSet;
            // 
            // companyDBLab42EDataSet
            // 
            this.companyDBLab42EDataSet.DataSetName = "CompanyDBLab42EDataSet";
            this.companyDBLab42EDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.companyDBLab42EDataSet;
            // 
            // AddPrjGrpBox
            // 
            this.AddPrjGrpBox.Controls.Add(this.PrjNo);
            this.AddPrjGrpBox.Controls.Add(this.LnkDepComboBox);
            this.AddPrjGrpBox.Controls.Add(this.LnkDepLbl);
            this.AddPrjGrpBox.Controls.Add(this.PrjNumLbl);
            this.AddPrjGrpBox.Controls.Add(this.prjLocLbl);
            this.AddPrjGrpBox.Controls.Add(this.prjLocTxtBox);
            this.AddPrjGrpBox.Controls.Add(this.prjNameLbl);
            this.AddPrjGrpBox.Controls.Add(this.PrjNameTxtBox);
            this.AddPrjGrpBox.Controls.Add(this.AddPrjBtn);
            this.AddPrjGrpBox.Location = new System.Drawing.Point(12, 484);
            this.AddPrjGrpBox.Name = "AddPrjGrpBox";
            this.AddPrjGrpBox.Size = new System.Drawing.Size(714, 200);
            this.AddPrjGrpBox.TabIndex = 20;
            this.AddPrjGrpBox.TabStop = false;
            this.AddPrjGrpBox.Text = "Add Project";
            this.AddPrjGrpBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // PrjNo
            // 
            this.PrjNo.Location = new System.Drawing.Point(431, 87);
            this.PrjNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PrjNo.Name = "PrjNo";
            this.PrjNo.Size = new System.Drawing.Size(91, 22);
            this.PrjNo.TabIndex = 51;
            // 
            // LnkDepComboBox
            // 
            this.LnkDepComboBox.DataSource = this.departmentBindingSource;
            this.LnkDepComboBox.DisplayMember = "Dname";
            this.LnkDepComboBox.FormattingEnabled = true;
            this.LnkDepComboBox.Location = new System.Drawing.Point(429, 47);
            this.LnkDepComboBox.Name = "LnkDepComboBox";
            this.LnkDepComboBox.Size = new System.Drawing.Size(163, 24);
            this.LnkDepComboBox.TabIndex = 49;
            this.LnkDepComboBox.ValueMember = "Dnumber";
            // 
            // LnkDepLbl
            // 
            this.LnkDepLbl.AutoSize = true;
            this.LnkDepLbl.Location = new System.Drawing.Point(294, 50);
            this.LnkDepLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnkDepLbl.Name = "LnkDepLbl";
            this.LnkDepLbl.Size = new System.Drawing.Size(128, 17);
            this.LnkDepLbl.TabIndex = 48;
            this.LnkDepLbl.Text = "Linked Department";
            // 
            // PrjNumLbl
            // 
            this.PrjNumLbl.AutoSize = true;
            this.PrjNumLbl.Location = new System.Drawing.Point(295, 90);
            this.PrjNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrjNumLbl.Name = "PrjNumLbl";
            this.PrjNumLbl.Size = new System.Drawing.Size(106, 17);
            this.PrjNumLbl.TabIndex = 48;
            this.PrjNumLbl.Text = "Project Number";
            // 
            // prjLocLbl
            // 
            this.prjLocLbl.AutoSize = true;
            this.prjLocLbl.Location = new System.Drawing.Point(25, 87);
            this.prjLocLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prjLocLbl.Name = "prjLocLbl";
            this.prjLocLbl.Size = new System.Drawing.Size(110, 17);
            this.prjLocLbl.TabIndex = 48;
            this.prjLocLbl.Text = "Project Location";
            // 
            // prjLocTxtBox
            // 
            this.prjLocTxtBox.Location = new System.Drawing.Point(138, 90);
            this.prjLocTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.prjLocTxtBox.Name = "prjLocTxtBox";
            this.prjLocTxtBox.Size = new System.Drawing.Size(132, 22);
            this.prjLocTxtBox.TabIndex = 47;
            // 
            // prjNameLbl
            // 
            this.prjNameLbl.AutoSize = true;
            this.prjNameLbl.Location = new System.Drawing.Point(25, 45);
            this.prjNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prjNameLbl.Name = "prjNameLbl";
            this.prjNameLbl.Size = new System.Drawing.Size(93, 17);
            this.prjNameLbl.TabIndex = 46;
            this.prjNameLbl.Text = "Project Name";
            // 
            // PrjNameTxtBox
            // 
            this.PrjNameTxtBox.Location = new System.Drawing.Point(138, 45);
            this.PrjNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrjNameTxtBox.Name = "PrjNameTxtBox";
            this.PrjNameTxtBox.Size = new System.Drawing.Size(132, 22);
            this.PrjNameTxtBox.TabIndex = 45;
            // 
            // AddPrjBtn
            // 
            this.AddPrjBtn.Location = new System.Drawing.Point(275, 143);
            this.AddPrjBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddPrjBtn.Name = "AddPrjBtn";
            this.AddPrjBtn.Size = new System.Drawing.Size(147, 31);
            this.AddPrjBtn.TabIndex = 41;
            this.AddPrjBtn.Text = "Add Project";
            this.AddPrjBtn.UseVisualStyleBackColor = true;
            this.AddPrjBtn.Click += new System.EventHandler(this.AddPrjBtn_Click);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.companyDBLab42EDataSet;
            // 
            // ViewInfoGrpBox
            // 
            this.ViewInfoGrpBox.Controls.Add(this.label5);
            this.ViewInfoGrpBox.Controls.Add(this.textBox6);
            this.ViewInfoGrpBox.Controls.Add(this.getPrjEmpLbl);
            this.ViewInfoGrpBox.Controls.Add(this.dataGridView);
            this.ViewInfoGrpBox.Controls.Add(this.getPrjEmpBtn);
            this.ViewInfoGrpBox.Location = new System.Drawing.Point(742, 12);
            this.ViewInfoGrpBox.Name = "ViewInfoGrpBox";
            this.ViewInfoGrpBox.Size = new System.Drawing.Size(359, 605);
            this.ViewInfoGrpBox.TabIndex = 21;
            this.ViewInfoGrpBox.TabStop = false;
            this.ViewInfoGrpBox.Text = "View Info";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(179, 31);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 65;
            // 
            // getPrjEmpLbl
            // 
            this.getPrjEmpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getPrjEmpLbl.AutoSize = true;
            this.getPrjEmpLbl.Location = new System.Drawing.Point(18, 34);
            this.getPrjEmpLbl.Name = "getPrjEmpLbl";
            this.getPrjEmpLbl.Size = new System.Drawing.Size(127, 17);
            this.getPrjEmpLbl.TabIndex = 61;
            this.getPrjEmpLbl.Text = "Department Name ";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 132);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(321, 447);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // getPrjEmpBtn
            // 
            this.getPrjEmpBtn.Location = new System.Drawing.Point(61, 65);
            this.getPrjEmpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.getPrjEmpBtn.Name = "getPrjEmpBtn";
            this.getPrjEmpBtn.Size = new System.Drawing.Size(250, 31);
            this.getPrjEmpBtn.TabIndex = 41;
            this.getPrjEmpBtn.Text = "Show Projects Names";
            this.getPrjEmpBtn.UseVisualStyleBackColor = true;
            this.getPrjEmpBtn.Click += new System.EventHandler(this.getPrjEmpBtn_Click);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.companyDBLab42EDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // AddDepLocGrpBox
            // 
            this.AddDepLocGrpBox.Controls.Add(this.label4);
            this.AddDepLocGrpBox.Controls.Add(this.textBox5);
            this.AddDepLocGrpBox.Controls.Add(this.label2);
            this.AddDepLocGrpBox.Controls.Add(this.textBox4);
            this.AddDepLocGrpBox.Controls.Add(this.DepNoLoc);
            this.AddDepLocGrpBox.Controls.Add(this.DepLocLbl);
            this.AddDepLocGrpBox.Controls.Add(this.DepLocTxtBox);
            this.AddDepLocGrpBox.Controls.Add(this.AddDepLocBtn);
            this.AddDepLocGrpBox.Location = new System.Drawing.Point(12, 275);
            this.AddDepLocGrpBox.Name = "AddDepLocGrpBox";
            this.AddDepLocGrpBox.Size = new System.Drawing.Size(714, 178);
            this.AddDepLocGrpBox.TabIndex = 23;
            this.AddDepLocGrpBox.TabStop = false;
            this.AddDepLocGrpBox.Text = "Add to Works_On";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 40);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 22);
            this.textBox5.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Hours";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 90);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 22);
            this.textBox4.TabIndex = 64;
            // 
            // DepNoLoc
            // 
            this.DepNoLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepNoLoc.AutoSize = true;
            this.DepNoLoc.Location = new System.Drawing.Point(29, 40);
            this.DepNoLoc.Name = "DepNoLoc";
            this.DepNoLoc.Size = new System.Drawing.Size(39, 17);
            this.DepNoLoc.TabIndex = 63;
            this.DepNoLoc.Text = "Essn";
            // 
            // DepLocLbl
            // 
            this.DepLocLbl.AutoSize = true;
            this.DepLocLbl.Location = new System.Drawing.Point(395, 43);
            this.DepLocLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepLocLbl.Name = "DepLocLbl";
            this.DepLocLbl.Size = new System.Drawing.Size(35, 17);
            this.DepLocLbl.TabIndex = 46;
            this.DepLocLbl.Text = "PNo";
            // 
            // DepLocTxtBox
            // 
            this.DepLocTxtBox.Location = new System.Drawing.Point(553, 40);
            this.DepLocTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DepLocTxtBox.Name = "DepLocTxtBox";
            this.DepLocTxtBox.Size = new System.Drawing.Size(132, 22);
            this.DepLocTxtBox.TabIndex = 45;
            // 
            // AddDepLocBtn
            // 
            this.AddDepLocBtn.Location = new System.Drawing.Point(538, 140);
            this.AddDepLocBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddDepLocBtn.Name = "AddDepLocBtn";
            this.AddDepLocBtn.Size = new System.Drawing.Size(147, 31);
            this.AddDepLocBtn.TabIndex = 41;
            this.AddDepLocBtn.Text = "Add to Works_On";
            this.AddDepLocBtn.UseVisualStyleBackColor = true;
            this.AddDepLocBtn.Click += new System.EventHandler(this.AddDepLocBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Make Sure To Choose Existing Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Make Sure To Choose Existing Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "NOT WORKING";
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 715);
            this.Controls.Add(this.AddDepLocGrpBox);
            this.Controls.Add(this.ViewInfoGrpBox);
            this.Controls.Add(this.AddPrjGrpBox);
            this.Controls.Add(this.addDepGrpBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab5";
            this.Text = "Lab5";
            this.Load += new System.EventHandler(this.Company_Load);
            this.addDepGrpBox.ResumeLayout(false);
            this.addDepGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBLab42EDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.AddPrjGrpBox.ResumeLayout(false);
            this.AddPrjGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrjNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ViewInfoGrpBox.ResumeLayout(false);
            this.ViewInfoGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.AddDepLocGrpBox.ResumeLayout(false);
            this.AddDepLocGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
          
        }

        #endregion
        private System.Windows.Forms.GroupBox addDepGrpBox;
        private System.Windows.Forms.Label empSuperSSNLbl;
        private System.Windows.Forms.Label DepMngrStartDateLbl;
        private System.Windows.Forms.Label empSsnLbl;
        private System.Windows.Forms.Label DepNameLbl;
        private System.Windows.Forms.TextBox depNameTxtBox;
        private System.Windows.Forms.Button addDepBtn;
        private System.Windows.Forms.GroupBox AddPrjGrpBox;
        private System.Windows.Forms.Label prjNameLbl;
        private System.Windows.Forms.TextBox PrjNameTxtBox;
        private System.Windows.Forms.ComboBox LnkDepComboBox;
        private System.Windows.Forms.Button AddPrjBtn;
        private System.Windows.Forms.GroupBox ViewInfoGrpBox;
        private System.Windows.Forms.Label getPrjEmpLbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button getPrjEmpBtn;
        private CompanyDBLab42EDataSet companyDBLab42EDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private CompanyDBLab42EDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private CompanyDBLab42EDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private CompanyDBLab42EDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.NumericUpDown DepNumber;
        private System.Windows.Forms.NumericUpDown PrjNo;
        private System.Windows.Forms.Label LnkDepLbl;
        private System.Windows.Forms.Label PrjNumLbl;
        private System.Windows.Forms.Label prjLocLbl;
        private System.Windows.Forms.TextBox prjLocTxtBox;
        private System.Windows.Forms.GroupBox AddDepLocGrpBox;
        private System.Windows.Forms.Label DepNoLoc;
        private System.Windows.Forms.Label DepLocLbl;
        private System.Windows.Forms.TextBox DepLocTxtBox;
        private System.Windows.Forms.Button AddDepLocBtn;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

