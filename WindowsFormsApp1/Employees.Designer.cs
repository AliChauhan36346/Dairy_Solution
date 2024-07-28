namespace WindowsFormsApp1
{
    partial class Employees
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.empBtn_save = new System.Windows.Forms.Button();
            this.empBtn_addNew = new System.Windows.Forms.Button();
            this.empBtn_deleteEmployee = new System.Windows.Forms.Button();
            this.empBtn_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_updateEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbo_designation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.dtTm_hireDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_employeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_employeeId = new System.Windows.Forms.TextBox();
            this.empTxt_searhEmployee = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empTxt_searchID = new System.Windows.Forms.TextBox();
            this.empBtn_find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBx_jobLeft = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTm_resignDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 342);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(825, 275);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // empBtn_save
            // 
            this.empBtn_save.BackColor = System.Drawing.Color.White;
            this.empBtn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empBtn_save.Location = new System.Drawing.Point(540, 3);
            this.empBtn_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empBtn_save.Name = "empBtn_save";
            this.empBtn_save.Size = new System.Drawing.Size(68, 42);
            this.empBtn_save.TabIndex = 0;
            this.empBtn_save.Text = "Save";
            this.empBtn_save.UseVisualStyleBackColor = false;
            this.empBtn_save.Click += new System.EventHandler(this.empBtn_save_Click);
            // 
            // empBtn_addNew
            // 
            this.empBtn_addNew.BackColor = System.Drawing.Color.White;
            this.empBtn_addNew.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn_addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empBtn_addNew.Location = new System.Drawing.Point(607, 3);
            this.empBtn_addNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empBtn_addNew.Name = "empBtn_addNew";
            this.empBtn_addNew.Size = new System.Drawing.Size(68, 42);
            this.empBtn_addNew.TabIndex = 8;
            this.empBtn_addNew.Text = "Add New";
            this.empBtn_addNew.UseVisualStyleBackColor = false;
            this.empBtn_addNew.Click += new System.EventHandler(this.empBtn_addNew_Click);
            // 
            // empBtn_deleteEmployee
            // 
            this.empBtn_deleteEmployee.BackColor = System.Drawing.Color.White;
            this.empBtn_deleteEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn_deleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.empBtn_deleteEmployee.Location = new System.Drawing.Point(750, 3);
            this.empBtn_deleteEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empBtn_deleteEmployee.Name = "empBtn_deleteEmployee";
            this.empBtn_deleteEmployee.Size = new System.Drawing.Size(68, 42);
            this.empBtn_deleteEmployee.TabIndex = 29;
            this.empBtn_deleteEmployee.TabStop = false;
            this.empBtn_deleteEmployee.Text = "Delete Employee";
            this.empBtn_deleteEmployee.UseVisualStyleBackColor = false;
            this.empBtn_deleteEmployee.Click += new System.EventHandler(this.empBtn_deleteEmployee_Click);
            // 
            // empBtn_dashboard
            // 
            this.empBtn_dashboard.BackColor = System.Drawing.Color.White;
            this.empBtn_dashboard.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empBtn_dashboard.Location = new System.Drawing.Point(683, 3);
            this.empBtn_dashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empBtn_dashboard.Name = "empBtn_dashboard";
            this.empBtn_dashboard.Size = new System.Drawing.Size(68, 42);
            this.empBtn_dashboard.TabIndex = 27;
            this.empBtn_dashboard.TabStop = false;
            this.empBtn_dashboard.Text = "Dashboard";
            this.empBtn_dashboard.UseVisualStyleBackColor = false;
            this.empBtn_dashboard.Click += new System.EventHandler(this.empBtn_dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_updateEmployee);
            this.panel1.Controls.Add(this.empBtn_save);
            this.panel1.Controls.Add(this.empBtn_dashboard);
            this.panel1.Controls.Add(this.empBtn_addNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.empBtn_deleteEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 51);
            this.panel1.TabIndex = 12;
            // 
            // btn_updateEmployee
            // 
            this.btn_updateEmployee.BackColor = System.Drawing.Color.White;
            this.btn_updateEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_updateEmployee.Location = new System.Drawing.Point(464, 3);
            this.btn_updateEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_updateEmployee.Name = "btn_updateEmployee";
            this.btn_updateEmployee.Size = new System.Drawing.Size(68, 42);
            this.btn_updateEmployee.TabIndex = 30;
            this.btn_updateEmployee.Text = "Update Employee";
            this.btn_updateEmployee.UseVisualStyleBackColor = false;
            this.btn_updateEmployee.Click += new System.EventHandler(this.btn_updateEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(19, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Designation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbo_designation);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Controls.Add(this.dtTm_hireDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_phNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_employeeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_employeeId);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(287, 261);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Joining Info";
            // 
            // cmbo_designation
            // 
            this.cmbo_designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_designation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_designation.FormattingEnabled = true;
            this.cmbo_designation.Items.AddRange(new object[] {
            "Dodhi",
            "Manager",
            "Chilar Incharge",
            "CEO"});
            this.cmbo_designation.Location = new System.Drawing.Point(100, 159);
            this.cmbo_designation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbo_designation.Name = "cmbo_designation";
            this.cmbo_designation.Size = new System.Drawing.Size(177, 25);
            this.cmbo_designation.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(33, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Hire Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(53, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salary";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(102, 194);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(178, 25);
            this.txt_salary.TabIndex = 4;
            // 
            // dtTm_hireDate
            // 
            this.dtTm_hireDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTm_hireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTm_hireDate.Location = new System.Drawing.Point(102, 228);
            this.dtTm_hireDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtTm_hireDate.Name = "dtTm_hireDate";
            this.dtTm_hireDate.Size = new System.Drawing.Size(178, 25);
            this.dtTm_hireDate.TabIndex = 5;
            this.dtTm_hireDate.Value = new System.DateTime(2024, 2, 2, 18, 15, 10, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(27, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone No.";
            // 
            // txt_phNo
            // 
            this.txt_phNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phNo.Location = new System.Drawing.Point(100, 126);
            this.txt_phNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_phNo.Name = "txt_phNo";
            this.txt_phNo.Size = new System.Drawing.Size(178, 25);
            this.txt_phNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(40, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(100, 92);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(178, 25);
            this.txt_address.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(53, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txt_employeeName
            // 
            this.txt_employeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeName.Location = new System.Drawing.Point(100, 59);
            this.txt_employeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_employeeName.Name = "txt_employeeName";
            this.txt_employeeName.Size = new System.Drawing.Size(178, 25);
            this.txt_employeeName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(77, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // txt_employeeId
            // 
            this.txt_employeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_employeeId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeId.Location = new System.Drawing.Point(100, 25);
            this.txt_employeeId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_employeeId.Name = "txt_employeeId";
            this.txt_employeeId.ReadOnly = true;
            this.txt_employeeId.Size = new System.Drawing.Size(67, 25);
            this.txt_employeeId.TabIndex = 4;
            this.txt_employeeId.TabStop = false;
            // 
            // empTxt_searhEmployee
            // 
            this.empTxt_searhEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empTxt_searhEmployee.Location = new System.Drawing.Point(161, 25);
            this.empTxt_searhEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empTxt_searhEmployee.Name = "empTxt_searhEmployee";
            this.empTxt_searhEmployee.Size = new System.Drawing.Size(140, 25);
            this.empTxt_searhEmployee.TabIndex = 1;
            this.empTxt_searhEmployee.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empTxt_searchID);
            this.groupBox2.Controls.Add(this.empBtn_find);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.empTxt_searhEmployee);
            this.groupBox2.Location = new System.Drawing.Point(508, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(307, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employee";
            // 
            // empTxt_searchID
            // 
            this.empTxt_searchID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empTxt_searchID.Location = new System.Drawing.Point(93, 25);
            this.empTxt_searchID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empTxt_searchID.Name = "empTxt_searchID";
            this.empTxt_searchID.Size = new System.Drawing.Size(62, 25);
            this.empTxt_searchID.TabIndex = 0;
            this.empTxt_searchID.TabStop = false;
            // 
            // empBtn_find
            // 
            this.empBtn_find.BackColor = System.Drawing.Color.Green;
            this.empBtn_find.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBtn_find.ForeColor = System.Drawing.Color.White;
            this.empBtn_find.Location = new System.Drawing.Point(240, 60);
            this.empBtn_find.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empBtn_find.Name = "empBtn_find";
            this.empBtn_find.Size = new System.Drawing.Size(61, 29);
            this.empBtn_find.TabIndex = 2;
            this.empBtn_find.TabStop = false;
            this.empBtn_find.Text = "Find";
            this.empBtn_find.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id or Name";
            // 
            // chkBx_jobLeft
            // 
            this.chkBx_jobLeft.AutoSize = true;
            this.chkBx_jobLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBx_jobLeft.Location = new System.Drawing.Point(10, 22);
            this.chkBx_jobLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkBx_jobLeft.Name = "chkBx_jobLeft";
            this.chkBx_jobLeft.Size = new System.Drawing.Size(73, 21);
            this.chkBx_jobLeft.TabIndex = 16;
            this.chkBx_jobLeft.TabStop = false;
            this.chkBx_jobLeft.Text = "Job Left";
            this.chkBx_jobLeft.UseVisualStyleBackColor = true;
            this.chkBx_jobLeft.CheckedChanged += new System.EventHandler(this.chkBx_jobLeft_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtTm_resignDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.chkBx_jobLeft);
            this.groupBox3.Location = new System.Drawing.Point(307, 61);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(134, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resign";
            // 
            // dtTm_resignDate
            // 
            this.dtTm_resignDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTm_resignDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTm_resignDate.Location = new System.Drawing.Point(10, 67);
            this.dtTm_resignDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtTm_resignDate.Name = "dtTm_resignDate";
            this.dtTm_resignDate.Size = new System.Drawing.Size(116, 25);
            this.dtTm_resignDate.TabIndex = 18;
            this.dtTm_resignDate.TabStop = false;
            this.dtTm_resignDate.Value = new System.DateTime(2024, 2, 2, 22, 36, 54, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Resign Date";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button empBtn_save;
        private System.Windows.Forms.Button empBtn_addNew;
        private System.Windows.Forms.Button empBtn_deleteEmployee;
        private System.Windows.Forms.Button empBtn_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_employeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_employeeId;
        private System.Windows.Forms.TextBox empTxt_searhEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button empBtn_find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTm_hireDate;
        private System.Windows.Forms.CheckBox chkBx_jobLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtTm_resignDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.ComboBox cmbo_designation;
        private System.Windows.Forms.TextBox empTxt_searchID;
        private System.Windows.Forms.Button btn_updateEmployee;
    }
}