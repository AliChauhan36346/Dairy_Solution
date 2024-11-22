namespace WindowsFormsApp1
{
    partial class Customers
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_credit = new System.Windows.Forms.CheckBox();
            this.txt_phNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pgNo = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dodhiName = new System.Windows.Forms.TextBox();
            this.txt_dodhiId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_creditLimit = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lstDodhiSuggestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_updateRecord = new System.Windows.Forms.Button();
            this.cusBtn_dashboard = new System.Windows.Forms.Button();
            this.cusBtn_addNew = new System.Windows.Forms.Button();
            this.cusBtn_save = new System.Windows.Forms.Button();
            this.cusBtn_deleteCustomer = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cusBtn_find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.txt_cusId = new System.Windows.Forms.TextBox();
            this.lstCustomerSuggestions = new System.Windows.Forms.ListBox();
            this.chk_inactiveCus = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(74, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rate";
            // 
            // txt_rate
            // 
            this.txt_rate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.Location = new System.Drawing.Point(118, 105);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(100, 27);
            this.txt_rate.TabIndex = 1;
            this.txt_rate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_rate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(51, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(64, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.ForeColor = System.Drawing.Color.Maroon;
            this.txt_customerName.Location = new System.Drawing.Point(118, 67);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(319, 26);
            this.txt_customerName.TabIndex = 0;
            this.txt_customerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customerName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(91, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDodhiSuggestions);
            this.groupBox1.Controls.Add(this.chk_credit);
            this.groupBox1.Controls.Add(this.txt_phNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_pgNo);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_dodhiName);
            this.groupBox1.Controls.Add(this.txt_dodhiId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_creditLimit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_rate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_customerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(450, 303);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // chk_credit
            // 
            this.chk_credit.AutoSize = true;
            this.chk_credit.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_credit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_credit.Location = new System.Drawing.Point(253, 35);
            this.chk_credit.Name = "chk_credit";
            this.chk_credit.Size = new System.Drawing.Size(184, 25);
            this.chk_credit.TabIndex = 8;
            this.chk_credit.Text = "Give Credit on Parchi";
            this.chk_credit.UseVisualStyleBackColor = true;
            // 
            // txt_phNo
            // 
            this.txt_phNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phNo.Location = new System.Drawing.Point(360, 145);
            this.txt_phNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_phNo.Name = "txt_phNo";
            this.txt_phNo.Size = new System.Drawing.Size(77, 27);
            this.txt_phNo.TabIndex = 4;
            this.txt_phNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phNo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(220, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Installment Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(6, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Register Pg No";
            // 
            // txt_pgNo
            // 
            this.txt_pgNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pgNo.Location = new System.Drawing.Point(118, 145);
            this.txt_pgNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_pgNo.Name = "txt_pgNo";
            this.txt_pgNo.Size = new System.Drawing.Size(77, 27);
            this.txt_pgNo.TabIndex = 3;
            this.txt_pgNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pgNo_KeyDown);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(118, 227);
            this.txt_address.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(319, 64);
            this.txt_address.TabIndex = 6;
            this.txt_address.Text = "";
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(63, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dodhi";
            // 
            // txt_dodhiName
            // 
            this.txt_dodhiName.BackColor = System.Drawing.Color.White;
            this.txt_dodhiName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dodhiName.Location = new System.Drawing.Point(199, 185);
            this.txt_dodhiName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_dodhiName.Name = "txt_dodhiName";
            this.txt_dodhiName.ReadOnly = true;
            this.txt_dodhiName.Size = new System.Drawing.Size(238, 27);
            this.txt_dodhiName.TabIndex = 38;
            this.txt_dodhiName.TabStop = false;
            // 
            // txt_dodhiId
            // 
            this.txt_dodhiId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dodhiId.Location = new System.Drawing.Point(118, 185);
            this.txt_dodhiId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_dodhiId.Name = "txt_dodhiId";
            this.txt_dodhiId.Size = new System.Drawing.Size(79, 27);
            this.txt_dodhiId.TabIndex = 5;
            this.txt_dodhiId.TextChanged += new System.EventHandler(this.txt_dodhiId_TextChanged);
            this.txt_dodhiId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dodhiId_KeyDown);
            this.txt_dodhiId.Leave += new System.EventHandler(this.txt_dodhiId_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(247, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Credit Limit";
            // 
            // txt_creditLimit
            // 
            this.txt_creditLimit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_creditLimit.Location = new System.Drawing.Point(337, 105);
            this.txt_creditLimit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_creditLimit.Name = "txt_creditLimit";
            this.txt_creditLimit.Size = new System.Drawing.Size(100, 27);
            this.txt_creditLimit.TabIndex = 2;
            this.txt_creditLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_creditLimit_KeyDown);
            // 
            // txt_Id
            // 
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(118, 29);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(83, 27);
            this.txt_Id.TabIndex = 4;
            this.txt_Id.TabStop = false;
            // 
            // lstDodhiSuggestions
            // 
            this.lstDodhiSuggestions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDodhiSuggestions.FormattingEnabled = true;
            this.lstDodhiSuggestions.ItemHeight = 17;
            this.lstDodhiSuggestions.Location = new System.Drawing.Point(118, 28);
            this.lstDodhiSuggestions.Name = "lstDodhiSuggestions";
            this.lstDodhiSuggestions.Size = new System.Drawing.Size(319, 157);
            this.lstDodhiSuggestions.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_updateRecord);
            this.panel1.Controls.Add(this.cusBtn_dashboard);
            this.panel1.Controls.Add(this.cusBtn_addNew);
            this.panel1.Controls.Add(this.cusBtn_save);
            this.panel1.Controls.Add(this.cusBtn_deleteCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 62);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(560, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 52);
            this.button1.TabIndex = 31;
            this.button1.TabStop = false;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_updateRecord
            // 
            this.btn_updateRecord.BackColor = System.Drawing.Color.White;
            this.btn_updateRecord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_updateRecord.Location = new System.Drawing.Point(648, 4);
            this.btn_updateRecord.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_updateRecord.Name = "btn_updateRecord";
            this.btn_updateRecord.Size = new System.Drawing.Size(81, 52);
            this.btn_updateRecord.TabIndex = 1;
            this.btn_updateRecord.TabStop = false;
            this.btn_updateRecord.Text = "Update Record";
            this.btn_updateRecord.UseVisualStyleBackColor = false;
            this.btn_updateRecord.Click += new System.EventHandler(this.btn_updateRecord_Click);
            // 
            // cusBtn_dashboard
            // 
            this.cusBtn_dashboard.BackColor = System.Drawing.Color.White;
            this.cusBtn_dashboard.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBtn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusBtn_dashboard.Location = new System.Drawing.Point(896, 4);
            this.cusBtn_dashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cusBtn_dashboard.Name = "cusBtn_dashboard";
            this.cusBtn_dashboard.Size = new System.Drawing.Size(81, 52);
            this.cusBtn_dashboard.TabIndex = 2;
            this.cusBtn_dashboard.TabStop = false;
            this.cusBtn_dashboard.Text = "Dashboard";
            this.cusBtn_dashboard.UseVisualStyleBackColor = false;
            this.cusBtn_dashboard.Click += new System.EventHandler(this.cusBtn_dashboard_Click);
            // 
            // cusBtn_addNew
            // 
            this.cusBtn_addNew.BackColor = System.Drawing.Color.White;
            this.cusBtn_addNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBtn_addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusBtn_addNew.Location = new System.Drawing.Point(808, 4);
            this.cusBtn_addNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cusBtn_addNew.Name = "cusBtn_addNew";
            this.cusBtn_addNew.Size = new System.Drawing.Size(81, 52);
            this.cusBtn_addNew.TabIndex = 1;
            this.cusBtn_addNew.TabStop = false;
            this.cusBtn_addNew.Text = "Add New";
            this.cusBtn_addNew.UseVisualStyleBackColor = false;
            this.cusBtn_addNew.Click += new System.EventHandler(this.cusBtn_addNew_Click);
            // 
            // cusBtn_save
            // 
            this.cusBtn_save.BackColor = System.Drawing.Color.White;
            this.cusBtn_save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBtn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusBtn_save.Location = new System.Drawing.Point(728, 4);
            this.cusBtn_save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cusBtn_save.Name = "cusBtn_save";
            this.cusBtn_save.Size = new System.Drawing.Size(81, 52);
            this.cusBtn_save.TabIndex = 0;
            this.cusBtn_save.Text = "Save";
            this.cusBtn_save.UseVisualStyleBackColor = false;
            this.cusBtn_save.Click += new System.EventHandler(this.cusBtn_save_Click);
            // 
            // cusBtn_deleteCustomer
            // 
            this.cusBtn_deleteCustomer.BackColor = System.Drawing.Color.White;
            this.cusBtn_deleteCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBtn_deleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cusBtn_deleteCustomer.Location = new System.Drawing.Point(977, 4);
            this.cusBtn_deleteCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cusBtn_deleteCustomer.Name = "cusBtn_deleteCustomer";
            this.cusBtn_deleteCustomer.Size = new System.Drawing.Size(81, 52);
            this.cusBtn_deleteCustomer.TabIndex = 29;
            this.cusBtn_deleteCustomer.TabStop = false;
            this.cusBtn_deleteCustomer.Text = "Delete Customer";
            this.cusBtn_deleteCustomer.UseVisualStyleBackColor = false;
            this.cusBtn_deleteCustomer.Click += new System.EventHandler(this.cusBtn_deleteCustomer_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.Location = new System.Drawing.Point(0, 398);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1068, 282);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // cusBtn_find
            // 
            this.cusBtn_find.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBtn_find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusBtn_find.Location = new System.Drawing.Point(988, 120);
            this.cusBtn_find.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cusBtn_find.Name = "cusBtn_find";
            this.cusBtn_find.Size = new System.Drawing.Size(67, 36);
            this.cusBtn_find.TabIndex = 37;
            this.cusBtn_find.TabStop = false;
            this.cusBtn_find.Text = "Find";
            this.cusBtn_find.UseVisualStyleBackColor = true;
            this.cusBtn_find.Click += new System.EventHandler(this.cusBtn_find_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(677, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Find Customer";
            // 
            // txt_cusName
            // 
            this.txt_cusName.BackColor = System.Drawing.Color.White;
            this.txt_cusName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusName.Location = new System.Drawing.Point(852, 85);
            this.txt_cusName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.ReadOnly = true;
            this.txt_cusName.Size = new System.Drawing.Size(204, 27);
            this.txt_cusName.TabIndex = 40;
            this.txt_cusName.TabStop = false;
            // 
            // txt_cusId
            // 
            this.txt_cusId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusId.Location = new System.Drawing.Point(771, 85);
            this.txt_cusId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cusId.Name = "txt_cusId";
            this.txt_cusId.Size = new System.Drawing.Size(79, 27);
            this.txt_cusId.TabIndex = 39;
            this.txt_cusId.TextChanged += new System.EventHandler(this.txt_cusId_TextChanged);
            this.txt_cusId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cusId_KeyDown);
            // 
            // lstCustomerSuggestions
            // 
            this.lstCustomerSuggestions.FormattingEnabled = true;
            this.lstCustomerSuggestions.ItemHeight = 20;
            this.lstCustomerSuggestions.Location = new System.Drawing.Point(772, 112);
            this.lstCustomerSuggestions.Name = "lstCustomerSuggestions";
            this.lstCustomerSuggestions.Size = new System.Drawing.Size(283, 144);
            this.lstCustomerSuggestions.TabIndex = 41;
            // 
            // chk_inactiveCus
            // 
            this.chk_inactiveCus.AutoSize = true;
            this.chk_inactiveCus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_inactiveCus.ForeColor = System.Drawing.Color.Red;
            this.chk_inactiveCus.Location = new System.Drawing.Point(43, 34);
            this.chk_inactiveCus.Name = "chk_inactiveCus";
            this.chk_inactiveCus.Size = new System.Drawing.Size(151, 24);
            this.chk_inactiveCus.TabIndex = 7;
            this.chk_inactiveCus.Text = "Inactive Customer";
            this.chk_inactiveCus.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_inactiveCus);
            this.groupBox2.Location = new System.Drawing.Point(474, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Status";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstCustomerSuggestions);
            this.Controls.Add(this.txt_cusName);
            this.Controls.Add(this.txt_cusId);
            this.Controls.Add(this.cusBtn_find);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cusBtn_addNew;
        private System.Windows.Forms.Button cusBtn_save;
        private System.Windows.Forms.Button cusBtn_deleteCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_creditLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cusBtn_dashboard;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Button btn_updateRecord;
        private System.Windows.Forms.Button cusBtn_find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dodhiName;
        private System.Windows.Forms.TextBox txt_dodhiId;
        private System.Windows.Forms.ListBox lstDodhiSuggestions;
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.TextBox txt_cusId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstCustomerSuggestions;
        private System.Windows.Forms.TextBox txt_phNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pgNo;
        private System.Windows.Forms.CheckBox chk_credit;
        private System.Windows.Forms.CheckBox chk_inactiveCus;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}