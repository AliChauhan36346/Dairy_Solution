namespace WindowsFormsApp1
{
    partial class Payments
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
            this.txt_accountBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_newAccount = new System.Windows.Forms.Button();
            this.btn_newCustomer = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_deleteRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cashAccountBalance = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAccountsSuggestion = new System.Windows.Forms.ListBox();
            this.txt_cashAccountId = new System.Windows.Forms.TextBox();
            this.lstAccountSuggestion = new System.Windows.Forms.ListBox();
            this.txt_discription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_accountName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_accountId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_paymentId = new System.Windows.Forms.TextBox();
            this.txt_cashAccountName = new System.Windows.Forms.TextBox();
            this.btn_goForward = new System.Windows.Forms.Button();
            this.btn_goBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_accountBalance
            // 
            this.txt_accountBalance.BackColor = System.Drawing.Color.White;
            this.txt_accountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_accountBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_accountBalance.Location = new System.Drawing.Point(886, 87);
            this.txt_accountBalance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_accountBalance.Name = "txt_accountBalance";
            this.txt_accountBalance.Size = new System.Drawing.Size(145, 27);
            this.txt_accountBalance.TabIndex = 75;
            this.txt_accountBalance.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(775, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Customer Balance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 419);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 271);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_newAccount);
            this.panel1.Controls.Add(this.btn_newCustomer);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_addNew);
            this.panel1.Controls.Add(this.btn_deleteRecord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 66);
            this.panel1.TabIndex = 62;
            // 
            // btn_newAccount
            // 
            this.btn_newAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_newAccount.Location = new System.Drawing.Point(403, 4);
            this.btn_newAccount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_newAccount.Name = "btn_newAccount";
            this.btn_newAccount.Size = new System.Drawing.Size(88, 56);
            this.btn_newAccount.TabIndex = 41;
            this.btn_newAccount.TabStop = false;
            this.btn_newAccount.Text = "New Account";
            this.btn_newAccount.UseVisualStyleBackColor = true;
            this.btn_newAccount.Click += new System.EventHandler(this.btn_newAccount_Click);
            // 
            // btn_newCustomer
            // 
            this.btn_newCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_newCustomer.Location = new System.Drawing.Point(491, 4);
            this.btn_newCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_newCustomer.Name = "btn_newCustomer";
            this.btn_newCustomer.Size = new System.Drawing.Size(88, 56);
            this.btn_newCustomer.TabIndex = 40;
            this.btn_newCustomer.TabStop = false;
            this.btn_newCustomer.Text = "New Customer";
            this.btn_newCustomer.UseVisualStyleBackColor = true;
            this.btn_newCustomer.Click += new System.EventHandler(this.btn_newCustomer_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Location = new System.Drawing.Point(674, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 56);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.Location = new System.Drawing.Point(586, 4);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 56);
            this.btn_update.TabIndex = 36;
            this.btn_update.TabStop = false;
            this.btn_update.Text = "Update Record";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.Location = new System.Drawing.Point(857, 4);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(88, 56);
            this.btn_dashboard.TabIndex = 35;
            this.btn_dashboard.TabStop = false;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addNew.Location = new System.Drawing.Point(762, 4);
            this.btn_addNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(88, 56);
            this.btn_addNew.TabIndex = 38;
            this.btn_addNew.TabStop = false;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_deleteRecord
            // 
            this.btn_deleteRecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteRecord.Location = new System.Drawing.Point(945, 4);
            this.btn_deleteRecord.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_deleteRecord.Name = "btn_deleteRecord";
            this.btn_deleteRecord.Size = new System.Drawing.Size(88, 56);
            this.btn_deleteRecord.TabIndex = 37;
            this.btn_deleteRecord.TabStop = false;
            this.btn_deleteRecord.Text = "Delete Record";
            this.btn_deleteRecord.UseVisualStyleBackColor = true;
            this.btn_deleteRecord.Click += new System.EventHandler(this.btn_deleteRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payments";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(784, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 104;
            this.label13.Text = "Account Balance";
            // 
            // txt_cashAccountBalance
            // 
            this.txt_cashAccountBalance.BackColor = System.Drawing.Color.White;
            this.txt_cashAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cashAccountBalance.ForeColor = System.Drawing.Color.Navy;
            this.txt_cashAccountBalance.Location = new System.Drawing.Point(886, 129);
            this.txt_cashAccountBalance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cashAccountBalance.Name = "txt_cashAccountBalance";
            this.txt_cashAccountBalance.Size = new System.Drawing.Size(145, 27);
            this.txt_cashAccountBalance.TabIndex = 103;
            this.txt_cashAccountBalance.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_goForward);
            this.groupBox1.Controls.Add(this.btn_goBack);
            this.groupBox1.Controls.Add(this.lstAccountsSuggestion);
            this.groupBox1.Controls.Add(this.txt_cashAccountId);
            this.groupBox1.Controls.Add(this.lstAccountSuggestion);
            this.groupBox1.Controls.Add(this.txt_discription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.txt_accountName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtm_picker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_accountId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_paymentId);
            this.groupBox1.Controls.Add(this.txt_cashAccountName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(415, 308);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Detail";
            // 
            // lstAccountsSuggestion
            // 
            this.lstAccountsSuggestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccountsSuggestion.FormattingEnabled = true;
            this.lstAccountsSuggestion.ItemHeight = 17;
            this.lstAccountsSuggestion.Location = new System.Drawing.Point(120, 128);
            this.lstAccountsSuggestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAccountsSuggestion.Name = "lstAccountsSuggestion";
            this.lstAccountsSuggestion.Size = new System.Drawing.Size(287, 174);
            this.lstAccountsSuggestion.TabIndex = 110;
            this.lstAccountsSuggestion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCustomersSuggestion_MouseDoubleClick);
            // 
            // txt_cashAccountId
            // 
            this.txt_cashAccountId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashAccountId.Location = new System.Drawing.Point(120, 180);
            this.txt_cashAccountId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cashAccountId.Name = "txt_cashAccountId";
            this.txt_cashAccountId.Size = new System.Drawing.Size(85, 27);
            this.txt_cashAccountId.TabIndex = 2;
            this.txt_cashAccountId.TextChanged += new System.EventHandler(this.txt_cashAccountId_TextChanged);
            this.txt_cashAccountId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cashAccountId_KeyDown);
            this.txt_cashAccountId.Leave += new System.EventHandler(this.txt_cashAccountId_Leave);
            // 
            // lstAccountSuggestion
            // 
            this.lstAccountSuggestion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccountSuggestion.FormattingEnabled = true;
            this.lstAccountSuggestion.Location = new System.Drawing.Point(120, 205);
            this.lstAccountSuggestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAccountSuggestion.Name = "lstAccountSuggestion";
            this.lstAccountSuggestion.Size = new System.Drawing.Size(287, 95);
            this.lstAccountSuggestion.TabIndex = 111;
            // 
            // txt_discription
            // 
            this.txt_discription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discription.Location = new System.Drawing.Point(120, 222);
            this.txt_discription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(287, 65);
            this.txt_discription.TabIndex = 3;
            this.txt_discription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(55, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 120;
            this.label8.Text = "Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(120, 139);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(287, 27);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            // 
            // txt_accountName
            // 
            this.txt_accountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountName.Location = new System.Drawing.Point(208, 101);
            this.txt_accountName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_accountName.Name = "txt_accountName";
            this.txt_accountName.Size = new System.Drawing.Size(199, 27);
            this.txt_accountName.TabIndex = 118;
            this.txt_accountName.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(17, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 116;
            this.label5.Text = "Cash Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(35, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Discription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(75, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "Date";
            // 
            // dtm_picker
            // 
            this.dtm_picker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_picker.Location = new System.Drawing.Point(120, 61);
            this.dtm_picker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtm_picker.Name = "dtm_picker";
            this.dtm_picker.Size = new System.Drawing.Size(182, 27);
            this.dtm_picker.TabIndex = 1;
            this.dtm_picker.TabStop = false;
            this.dtm_picker.Value = new System.DateTime(2024, 1, 29, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(42, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Customer";
            // 
            // txt_accountId
            // 
            this.txt_accountId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountId.Location = new System.Drawing.Point(120, 101);
            this.txt_accountId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_accountId.Name = "txt_accountId";
            this.txt_accountId.Size = new System.Drawing.Size(85, 27);
            this.txt_accountId.TabIndex = 0;
            this.txt_accountId.TextChanged += new System.EventHandler(this.txt_accountId_TextChanged);
            this.txt_accountId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accountId_KeyDown);
            this.txt_accountId.Leave += new System.EventHandler(this.txt_accountId_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(94, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Id";
            // 
            // txt_paymentId
            // 
            this.txt_paymentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_paymentId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentId.Location = new System.Drawing.Point(120, 22);
            this.txt_paymentId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_paymentId.Name = "txt_paymentId";
            this.txt_paymentId.ReadOnly = true;
            this.txt_paymentId.Size = new System.Drawing.Size(85, 27);
            this.txt_paymentId.TabIndex = 109;
            this.txt_paymentId.TabStop = false;
            // 
            // txt_cashAccountName
            // 
            this.txt_cashAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashAccountName.Location = new System.Drawing.Point(208, 180);
            this.txt_cashAccountName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_cashAccountName.Name = "txt_cashAccountName";
            this.txt_cashAccountName.ReadOnly = true;
            this.txt_cashAccountName.Size = new System.Drawing.Size(199, 27);
            this.txt_cashAccountName.TabIndex = 123;
            this.txt_cashAccountName.TabStop = false;
            // 
            // btn_goForward
            // 
            this.btn_goForward.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goForward.Location = new System.Drawing.Point(257, 19);
            this.btn_goForward.Name = "btn_goForward";
            this.btn_goForward.Size = new System.Drawing.Size(45, 33);
            this.btn_goForward.TabIndex = 125;
            this.btn_goForward.Text = ">>";
            this.btn_goForward.UseVisualStyleBackColor = true;
            this.btn_goForward.Click += new System.EventHandler(this.btn_goForward_Click);
            // 
            // btn_goBack
            // 
            this.btn_goBack.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goBack.Location = new System.Drawing.Point(211, 19);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(45, 33);
            this.btn_goBack.TabIndex = 124;
            this.btn_goBack.Text = "<<";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_cashAccountBalance);
            this.Controls.Add(this.txt_accountBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_accountBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cashAccountBalance;
        private System.Windows.Forms.Button btn_newAccount;
        private System.Windows.Forms.Button btn_newCustomer;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_deleteRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_discription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_accountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_accountId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_paymentId;
        private System.Windows.Forms.TextBox txt_cashAccountName;
        private System.Windows.Forms.TextBox txt_cashAccountId;
        private System.Windows.Forms.ListBox lstAccountsSuggestion;
        private System.Windows.Forms.ListBox lstAccountSuggestion;
        private System.Windows.Forms.Button btn_goForward;
        private System.Windows.Forms.Button btn_goBack;
    }
}