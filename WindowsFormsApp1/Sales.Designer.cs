namespace WindowsFormsApp1
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_newAccount = new System.Windows.Forms.Button();
            this.btn_newCompany = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lstCompanySuggestions = new System.Windows.Forms.ListBox();
            this.btn_goForward = new System.Windows.Forms.Button();
            this.lstAccountSuggestions = new System.Windows.Forms.ListBox();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.txt_cashAccountId = new System.Windows.Forms.TextBox();
            this.txt_cashAccountName = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_tsStandard = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_totalAmount = new System.Windows.Forms.TextBox();
            this.txt_amountReceived = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fat = new System.Windows.Forms.TextBox();
            this.txt_lr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tsLiters = new System.Windows.Forms.TextBox();
            this.dtm_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_liters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_salesId = new System.Windows.Forms.TextBox();
            this.txt_tsSales = new System.Windows.Forms.TextBox();
            this.txt_grossSales = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_stockVolume = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_newAccount);
            this.panel1.Controls.Add(this.btn_newCompany);
            this.panel1.Controls.Add(this.btn_addNew);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 65);
            this.panel1.TabIndex = 0;
            // 
            // btn_newAccount
            // 
            this.btn_newAccount.BackColor = System.Drawing.Color.White;
            this.btn_newAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newAccount.ForeColor = System.Drawing.Color.Black;
            this.btn_newAccount.Location = new System.Drawing.Point(682, 6);
            this.btn_newAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_newAccount.Name = "btn_newAccount";
            this.btn_newAccount.Size = new System.Drawing.Size(80, 52);
            this.btn_newAccount.TabIndex = 70;
            this.btn_newAccount.TabStop = false;
            this.btn_newAccount.Text = "New Account";
            this.btn_newAccount.UseVisualStyleBackColor = false;
            this.btn_newAccount.Click += new System.EventHandler(this.btn_newAccount_Click);
            // 
            // btn_newCompany
            // 
            this.btn_newCompany.BackColor = System.Drawing.Color.White;
            this.btn_newCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCompany.ForeColor = System.Drawing.Color.Black;
            this.btn_newCompany.Location = new System.Drawing.Point(761, 6);
            this.btn_newCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_newCompany.Name = "btn_newCompany";
            this.btn_newCompany.Size = new System.Drawing.Size(80, 52);
            this.btn_newCompany.TabIndex = 69;
            this.btn_newCompany.TabStop = false;
            this.btn_newCompany.Text = "New Company";
            this.btn_newCompany.UseVisualStyleBackColor = false;
            this.btn_newCompany.Click += new System.EventHandler(this.salesBtn_newCompany_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.White;
            this.btn_addNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew.ForeColor = System.Drawing.Color.Black;
            this.btn_addNew.Location = new System.Drawing.Point(1009, 6);
            this.btn_addNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(80, 52);
            this.btn_addNew.TabIndex = 68;
            this.btn_addNew.TabStop = false;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = false;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(929, 6);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 52);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(1177, 6);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 52);
            this.btn_delete.TabIndex = 66;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(850, 6);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 52);
            this.btn_update.TabIndex = 65;
            this.btn_update.TabStop = false;
            this.btn_update.Text = "Update Record";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(1097, 6);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(80, 52);
            this.btn_dashboard.TabIndex = 64;
            this.btn_dashboard.TabStop = false;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales فروخت";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 413);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 279);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(996, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Company Balance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(1002, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total Gross Sales";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Purple;
            this.label14.Location = new System.Drawing.Point(1056, 161);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ts-Sales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCompanySuggestions);
            this.groupBox1.Controls.Add(this.btn_goForward);
            this.groupBox1.Controls.Add(this.lstAccountSuggestions);
            this.groupBox1.Controls.Add(this.btn_goBack);
            this.groupBox1.Controls.Add(this.txt_cashAccountId);
            this.groupBox1.Controls.Add(this.txt_cashAccountName);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.txt_tsStandard);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_balance);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_totalAmount);
            this.groupBox1.Controls.Add(this.txt_amountReceived);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_fat);
            this.groupBox1.Controls.Add(this.txt_lr);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tsLiters);
            this.groupBox1.Controls.Add(this.dtm_picker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_companyName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_rate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_liters);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_salesId);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(519, 320);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Detail";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(392, 186);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 20);
            this.label18.TabIndex = 55;
            this.label18.Text = "موصول ہوئی رقم";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // lstCompanySuggestions
            // 
            this.lstCompanySuggestions.FormattingEnabled = true;
            this.lstCompanySuggestions.ItemHeight = 20;
            this.lstCompanySuggestions.Location = new System.Drawing.Point(186, 88);
            this.lstCompanySuggestions.Name = "lstCompanySuggestions";
            this.lstCompanySuggestions.Size = new System.Drawing.Size(326, 204);
            this.lstCompanySuggestions.TabIndex = 36;
            this.lstCompanySuggestions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCompanySuggestions_MouseDoubleClick);
            // 
            // btn_goForward
            // 
            this.btn_goForward.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goForward.Location = new System.Drawing.Point(467, 22);
            this.btn_goForward.Name = "btn_goForward";
            this.btn_goForward.Size = new System.Drawing.Size(45, 33);
            this.btn_goForward.TabIndex = 75;
            this.btn_goForward.Text = ">>";
            this.btn_goForward.UseVisualStyleBackColor = true;
            this.btn_goForward.Click += new System.EventHandler(this.btn_goForward_Click);
            // 
            // lstAccountSuggestions
            // 
            this.lstAccountSuggestions.FormattingEnabled = true;
            this.lstAccountSuggestions.ItemHeight = 20;
            this.lstAccountSuggestions.Location = new System.Drawing.Point(186, 118);
            this.lstAccountSuggestions.Name = "lstAccountSuggestions";
            this.lstAccountSuggestions.Size = new System.Drawing.Size(326, 124);
            this.lstAccountSuggestions.TabIndex = 37;
            this.lstAccountSuggestions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAccountSuggestions_MouseDoubleClick);
            // 
            // btn_goBack
            // 
            this.btn_goBack.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goBack.Location = new System.Drawing.Point(421, 22);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(45, 33);
            this.btn_goBack.TabIndex = 74;
            this.btn_goBack.Text = "<<";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // txt_cashAccountId
            // 
            this.txt_cashAccountId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashAccountId.Location = new System.Drawing.Point(186, 243);
            this.txt_cashAccountId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cashAccountId.Name = "txt_cashAccountId";
            this.txt_cashAccountId.Size = new System.Drawing.Size(100, 27);
            this.txt_cashAccountId.TabIndex = 63;
            this.txt_cashAccountId.TextChanged += new System.EventHandler(this.txt_cashAccountId_TextChanged);
            this.txt_cashAccountId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cashAccountId_KeyDown);
            this.txt_cashAccountId.Leave += new System.EventHandler(this.txt_cashAccountId_Leave);
            // 
            // txt_cashAccountName
            // 
            this.txt_cashAccountName.BackColor = System.Drawing.Color.White;
            this.txt_cashAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashAccountName.Location = new System.Drawing.Point(287, 243);
            this.txt_cashAccountName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cashAccountName.Name = "txt_cashAccountName";
            this.txt_cashAccountName.ReadOnly = true;
            this.txt_cashAccountName.Size = new System.Drawing.Size(225, 27);
            this.txt_cashAccountName.TabIndex = 64;
            this.txt_cashAccountName.TabStop = false;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.White;
            this.txt_status.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(390, 283);
            this.txt_status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(122, 27);
            this.txt_status.TabIndex = 59;
            this.txt_status.TabStop = false;
            // 
            // txt_tsStandard
            // 
            this.txt_tsStandard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tsStandard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsStandard.ForeColor = System.Drawing.Color.Black;
            this.txt_tsStandard.Location = new System.Drawing.Point(476, 133);
            this.txt_tsStandard.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_tsStandard.Name = "txt_tsStandard";
            this.txt_tsStandard.ReadOnly = true;
            this.txt_tsStandard.Size = new System.Drawing.Size(36, 27);
            this.txt_tsStandard.TabIndex = 61;
            this.txt_tsStandard.TabStop = false;
            this.txt_tsStandard.Leave += new System.EventHandler(this.txt_tsStandard_Leave);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_id.Location = new System.Drawing.Point(186, 61);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 27);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(398, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Ts ٹی ایس";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(8, 282);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 59;
            this.label16.Text = "Balance بقیہ";
            // 
            // txt_balance
            // 
            this.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_balance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(186, 283);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.Size = new System.Drawing.Size(194, 27);
            this.txt_balance.TabIndex = 58;
            this.txt_balance.TabStop = false;
            this.txt_balance.TextChanged += new System.EventHandler(this.txt_balance_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(8, 206);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 20);
            this.label15.TabIndex = 57;
            this.label15.Text = "Total Amount کل رقم";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(315, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Amount Received";
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalAmount.Location = new System.Drawing.Point(186, 207);
            this.txt_totalAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.ReadOnly = true;
            this.txt_totalAmount.Size = new System.Drawing.Size(113, 27);
            this.txt_totalAmount.TabIndex = 56;
            this.txt_totalAmount.TabStop = false;
            // 
            // txt_amountReceived
            // 
            this.txt_amountReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amountReceived.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amountReceived.Location = new System.Drawing.Point(315, 207);
            this.txt_amountReceived.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_amountReceived.Name = "txt_amountReceived";
            this.txt_amountReceived.Size = new System.Drawing.Size(197, 27);
            this.txt_amountReceived.TabIndex = 6;
            this.txt_amountReceived.TextChanged += new System.EventHandler(this.txt_amountReceived_TextChanged);
            this.txt_amountReceived.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amountReceived_KeyDown);
            this.txt_amountReceived.Leave += new System.EventHandler(this.txt_amountReceived_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(8, 243);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Cash Account اکاؤنٹ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(251, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Fat% فیٹ";
            // 
            // txt_fat
            // 
            this.txt_fat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fat.Location = new System.Drawing.Point(325, 133);
            this.txt_fat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fat.Name = "txt_fat";
            this.txt_fat.Size = new System.Drawing.Size(65, 27);
            this.txt_fat.TabIndex = 4;
            this.txt_fat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fat_KeyDown);
            this.txt_fat.Leave += new System.EventHandler(this.txt_fat_Leave);
            // 
            // txt_lr
            // 
            this.txt_lr.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lr.Location = new System.Drawing.Point(186, 133);
            this.txt_lr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_lr.Name = "txt_lr";
            this.txt_lr.Size = new System.Drawing.Size(57, 27);
            this.txt_lr.TabIndex = 3;
            this.txt_lr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_lr_KeyDown);
            this.txt_lr.Leave += new System.EventHandler(this.txt_lr_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(8, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "LR ایل آر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(8, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ts Liters ٹی ایس لیٹر";
            // 
            // txt_tsLiters
            // 
            this.txt_tsLiters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tsLiters.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsLiters.Location = new System.Drawing.Point(186, 170);
            this.txt_tsLiters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tsLiters.Name = "txt_tsLiters";
            this.txt_tsLiters.ReadOnly = true;
            this.txt_tsLiters.Size = new System.Drawing.Size(113, 27);
            this.txt_tsLiters.TabIndex = 46;
            this.txt_tsLiters.TabStop = false;
            this.txt_tsLiters.TextChanged += new System.EventHandler(this.txt_tsLiters_TextChanged);
            // 
            // dtm_picker
            // 
            this.dtm_picker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_picker.Location = new System.Drawing.Point(288, 25);
            this.dtm_picker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtm_picker.Name = "dtm_picker";
            this.dtm_picker.Size = new System.Drawing.Size(126, 27);
            this.dtm_picker.TabIndex = 45;
            this.dtm_picker.TabStop = false;
            this.dtm_picker.ValueChanged += new System.EventHandler(this.dtm_picker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(8, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Company کمپنی";
            // 
            // txt_companyName
            // 
            this.txt_companyName.BackColor = System.Drawing.Color.White;
            this.txt_companyName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companyName.ForeColor = System.Drawing.Color.Red;
            this.txt_companyName.Location = new System.Drawing.Point(287, 61);
            this.txt_companyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.ReadOnly = true;
            this.txt_companyName.Size = new System.Drawing.Size(225, 27);
            this.txt_companyName.TabIndex = 43;
            this.txt_companyName.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(283, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Gross Liters لیٹر";
            // 
            // txt_rate
            // 
            this.txt_rate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_rate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.Location = new System.Drawing.Point(186, 97);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(82, 27);
            this.txt_rate.TabIndex = 1;
            this.txt_rate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_rate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Rate قیمت";
            // 
            // txt_liters
            // 
            this.txt_liters.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_liters.Location = new System.Drawing.Point(402, 97);
            this.txt_liters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_liters.Name = "txt_liters";
            this.txt_liters.Size = new System.Drawing.Size(110, 27);
            this.txt_liters.TabIndex = 2;
            this.txt_liters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_liters_KeyDown);
            this.txt_liters.Leave += new System.EventHandler(this.txt_liters_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sales Id سیل آئی ڈی";
            // 
            // txt_salesId
            // 
            this.txt_salesId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_salesId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salesId.Location = new System.Drawing.Point(186, 25);
            this.txt_salesId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_salesId.Name = "txt_salesId";
            this.txt_salesId.ReadOnly = true;
            this.txt_salesId.Size = new System.Drawing.Size(100, 27);
            this.txt_salesId.TabIndex = 35;
            this.txt_salesId.TabStop = false;
            // 
            // txt_tsSales
            // 
            this.txt_tsSales.BackColor = System.Drawing.Color.White;
            this.txt_tsSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tsSales.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsSales.ForeColor = System.Drawing.Color.Purple;
            this.txt_tsSales.Location = new System.Drawing.Point(1121, 155);
            this.txt_tsSales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tsSales.Name = "txt_tsSales";
            this.txt_tsSales.ReadOnly = true;
            this.txt_tsSales.Size = new System.Drawing.Size(137, 29);
            this.txt_tsSales.TabIndex = 29;
            this.txt_tsSales.TabStop = false;
            // 
            // txt_grossSales
            // 
            this.txt_grossSales.BackColor = System.Drawing.Color.White;
            this.txt_grossSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_grossSales.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grossSales.ForeColor = System.Drawing.Color.Green;
            this.txt_grossSales.Location = new System.Drawing.Point(1121, 119);
            this.txt_grossSales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_grossSales.Name = "txt_grossSales";
            this.txt_grossSales.ReadOnly = true;
            this.txt_grossSales.Size = new System.Drawing.Size(137, 29);
            this.txt_grossSales.TabIndex = 31;
            this.txt_grossSales.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(1024, 197);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Stock Volume";
            // 
            // txt_stockVolume
            // 
            this.txt_stockVolume.BackColor = System.Drawing.Color.White;
            this.txt_stockVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stockVolume.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockVolume.ForeColor = System.Drawing.Color.Navy;
            this.txt_stockVolume.Location = new System.Drawing.Point(1121, 191);
            this.txt_stockVolume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_stockVolume.Name = "txt_stockVolume";
            this.txt_stockVolume.ReadOnly = true;
            this.txt_stockVolume.Size = new System.Drawing.Size(137, 29);
            this.txt_stockVolume.TabIndex = 36;
            this.txt_stockVolume.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1120, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 29);
            this.textBox1.TabIndex = 38;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_stockVolume);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_grossSales);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_tsSales);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_totalAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_amountReceived;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_lr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tsLiters;
        private System.Windows.Forms.DateTimePicker dtm_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_liters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_salesId;
        private System.Windows.Forms.Button btn_newAccount;
        private System.Windows.Forms.Button btn_newCompany;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_tsStandard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCompanySuggestions;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_cashAccountId;
        private System.Windows.Forms.TextBox txt_cashAccountName;
        private System.Windows.Forms.ListBox lstAccountSuggestions;
        private System.Windows.Forms.TextBox txt_tsSales;
        private System.Windows.Forms.TextBox txt_grossSales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_stockVolume;
        private System.Windows.Forms.Button btn_goForward;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
    }
}