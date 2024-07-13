namespace WindowsFormsApp1
{
    partial class expenseGeneral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deleteRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCashAccountSuggestions = new System.Windows.Forms.ListBox();
            this.lstEmployeeSuggestions = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cashAccountId = new System.Windows.Forms.TextBox();
            this.txt_cashAccountName = new System.Windows.Forms.TextBox();
            this.txt_discription = new System.Windows.Forms.RichTextBox();
            this.combo_expenseType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtTm_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_employeeId = new System.Windows.Forms.TextBox();
            this.txt_employeeName = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_expenseId = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_addEmployee);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_addNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_deleteRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 67);
            this.panel1.TabIndex = 13;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.Location = new System.Drawing.Point(479, 4);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 56);
            this.btn_update.TabIndex = 30;
            this.btn_update.TabStop = false;
            this.btn_update.Text = "Update Expense";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Location = new System.Drawing.Point(566, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 56);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addEmployee.Location = new System.Drawing.Point(384, 4);
            this.btn_addEmployee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(88, 56);
            this.btn_addEmployee.TabIndex = 28;
            this.btn_addEmployee.TabStop = false;
            this.btn_addEmployee.Text = "Add Employee";
            this.btn_addEmployee.UseVisualStyleBackColor = true;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addPurchase_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.Location = new System.Drawing.Point(747, 4);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(88, 56);
            this.btn_dashboard.TabIndex = 27;
            this.btn_dashboard.TabStop = false;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addNew.Location = new System.Drawing.Point(653, 4);
            this.btn_addNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(88, 56);
            this.btn_addNew.TabIndex = 7;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expenses";
            // 
            // btn_deleteRecord
            // 
            this.btn_deleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteRecord.Location = new System.Drawing.Point(835, 4);
            this.btn_deleteRecord.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_deleteRecord.Name = "btn_deleteRecord";
            this.btn_deleteRecord.Size = new System.Drawing.Size(88, 56);
            this.btn_deleteRecord.TabIndex = 29;
            this.btn_deleteRecord.TabStop = false;
            this.btn_deleteRecord.Text = "Delete Record";
            this.btn_deleteRecord.UseVisualStyleBackColor = true;
            this.btn_deleteRecord.Click += new System.EventHandler(this.btn_deleteRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCashAccountSuggestions);
            this.groupBox1.Controls.Add(this.lstEmployeeSuggestions);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cashAccountId);
            this.groupBox1.Controls.Add(this.txt_cashAccountName);
            this.groupBox1.Controls.Add(this.txt_discription);
            this.groupBox1.Controls.Add(this.combo_expenseType);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtTm_date);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_employeeId);
            this.groupBox1.Controls.Add(this.txt_employeeName);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_expenseId);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(372, 286);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstCashAccountSuggestions
            // 
            this.lstCashAccountSuggestions.FormattingEnabled = true;
            this.lstCashAccountSuggestions.Location = new System.Drawing.Point(107, 91);
            this.lstCashAccountSuggestions.Name = "lstCashAccountSuggestions";
            this.lstCashAccountSuggestions.Size = new System.Drawing.Size(256, 95);
            this.lstCashAccountSuggestions.TabIndex = 17;
            // 
            // lstEmployeeSuggestions
            // 
            this.lstEmployeeSuggestions.FormattingEnabled = true;
            this.lstEmployeeSuggestions.Location = new System.Drawing.Point(106, 152);
            this.lstEmployeeSuggestions.Name = "lstEmployeeSuggestions";
            this.lstEmployeeSuggestions.Size = new System.Drawing.Size(258, 95);
            this.lstEmployeeSuggestions.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cash Account";
            // 
            // txt_cashAccountId
            // 
            this.txt_cashAccountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashAccountId.Location = new System.Drawing.Point(108, 69);
            this.txt_cashAccountId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cashAccountId.Name = "txt_cashAccountId";
            this.txt_cashAccountId.Size = new System.Drawing.Size(77, 26);
            this.txt_cashAccountId.TabIndex = 18;
            this.txt_cashAccountId.TextChanged += new System.EventHandler(this.txt_cashAccountId_TextChanged);
            this.txt_cashAccountId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cashAccountId_KeyDown);
            this.txt_cashAccountId.Leave += new System.EventHandler(this.txt_cashAccountId_Leave);
            // 
            // txt_cashAccountName
            // 
            this.txt_cashAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashAccountName.Location = new System.Drawing.Point(187, 69);
            this.txt_cashAccountName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cashAccountName.Name = "txt_cashAccountName";
            this.txt_cashAccountName.Size = new System.Drawing.Size(177, 26);
            this.txt_cashAccountName.TabIndex = 19;
            // 
            // txt_discription
            // 
            this.txt_discription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discription.Location = new System.Drawing.Point(108, 182);
            this.txt_discription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(256, 54);
            this.txt_discription.TabIndex = 3;
            this.txt_discription.Text = "";
            // 
            // combo_expenseType
            // 
            this.combo_expenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_expenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_expenseType.FormattingEnabled = true;
            this.combo_expenseType.Items.AddRange(new object[] {
            "Electricity",
            "Labour",
            "Vehical Repairing",
            "Petrol",
            "Chilar Repairing",
            "Other"});
            this.combo_expenseType.Location = new System.Drawing.Point(108, 105);
            this.combo_expenseType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combo_expenseType.Name = "combo_expenseType";
            this.combo_expenseType.Size = new System.Drawing.Size(256, 28);
            this.combo_expenseType.TabIndex = 1;
            this.combo_expenseType.SelectedIndexChanged += new System.EventHandler(this.combo_expenseType_SelectedIndexChanged);
            this.combo_expenseType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_expenseType_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(22, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Employee Id";
            // 
            // dtTm_date
            // 
            this.dtTm_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTm_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTm_date.Location = new System.Drawing.Point(187, 33);
            this.dtTm_date.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtTm_date.Name = "dtTm_date";
            this.dtTm_date.Size = new System.Drawing.Size(91, 25);
            this.dtTm_date.TabIndex = 1;
            this.dtTm_date.TabStop = false;
            this.dtTm_date.Value = new System.DateTime(2024, 7, 13, 0, 0, 0, 0);
            this.dtTm_date.ValueChanged += new System.EventHandler(this.dtTm_date_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(32, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Discription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(49, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount";
            // 
            // txt_employeeId
            // 
            this.txt_employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeId.Location = new System.Drawing.Point(106, 247);
            this.txt_employeeId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_employeeId.Name = "txt_employeeId";
            this.txt_employeeId.Size = new System.Drawing.Size(76, 26);
            this.txt_employeeId.TabIndex = 4;
            this.txt_employeeId.TextChanged += new System.EventHandler(this.txt_employeeId_TextChanged);
            this.txt_employeeId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_employeeId_KeyDown);
            // 
            // txt_employeeName
            // 
            this.txt_employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employeeName.Location = new System.Drawing.Point(184, 247);
            this.txt_employeeName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_employeeName.Name = "txt_employeeName";
            this.txt_employeeName.Size = new System.Drawing.Size(180, 26);
            this.txt_employeeName.TabIndex = 5;
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(108, 143);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(256, 26);
            this.txt_amount.TabIndex = 2;
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expense Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expense Id";
            // 
            // txt_expenseId
            // 
            this.txt_expenseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_expenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expenseId.Location = new System.Drawing.Point(108, 33);
            this.txt_expenseId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_expenseId.Name = "txt_expenseId";
            this.txt_expenseId.ReadOnly = true;
            this.txt_expenseId.Size = new System.Drawing.Size(77, 26);
            this.txt_expenseId.TabIndex = 4;
            this.txt_expenseId.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 385);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(931, 288);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // expenseGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 673);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "expenseGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expenseGeneral";
            this.Load += new System.EventHandler(this.expenseGeneral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deleteRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_discription;
        private System.Windows.Forms.ComboBox combo_expenseType;
        private System.Windows.Forms.DateTimePicker dtTm_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_expenseId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_employeeName;
        private System.Windows.Forms.TextBox txt_employeeId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_cashAccountId;
        private System.Windows.Forms.TextBox txt_cashAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCashAccountSuggestions;
        private System.Windows.Forms.ListBox lstEmployeeSuggestions;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}