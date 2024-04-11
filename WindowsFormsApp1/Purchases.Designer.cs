namespace WindowsFormsApp1
{
    partial class Purchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.txt_totalReceive = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_totalPurchase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_accountBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_newCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dodhiId = new System.Windows.Forms.TextBox();
            this.txt_dodhiName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.rdo_evening = new System.Windows.Forms.RadioButton();
            this.rdo_morning = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_totalAmount = new System.Windows.Forms.TextBox();
            this.dtm_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_liters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_purchaseId = new System.Windows.Forms.TextBox();
            this.lstCustomersSuggestion = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_difference = new System.Windows.Forms.TextBox();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.btn_goForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addNew
            // 
            this.btn_addNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew.ForeColor = System.Drawing.Color.Black;
            this.btn_addNew.Location = new System.Drawing.Point(734, 3);
            this.btn_addNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(88, 56);
            this.btn_addNew.TabIndex = 31;
            this.btn_addNew.TabStop = false;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(647, 3);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 56);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(917, 3);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 56);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "Delete Record";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(560, 3);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 56);
            this.btn_update.TabIndex = 28;
            this.btn_update.TabStop = false;
            this.btn_update.Text = "Update Record";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(830, 3);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(88, 56);
            this.btn_dashboard.TabIndex = 27;
            this.btn_dashboard.TabStop = false;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // txt_totalReceive
            // 
            this.txt_totalReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_totalReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalReceive.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalReceive.ForeColor = System.Drawing.Color.Green;
            this.txt_totalReceive.Location = new System.Drawing.Point(873, 143);
            this.txt_totalReceive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_totalReceive.Name = "txt_totalReceive";
            this.txt_totalReceive.ReadOnly = true;
            this.txt_totalReceive.Size = new System.Drawing.Size(132, 27);
            this.txt_totalReceive.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(747, 189);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Total Purchases";
            // 
            // txt_totalPurchase
            // 
            this.txt_totalPurchase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_totalPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalPurchase.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPurchase.ForeColor = System.Drawing.Color.Navy;
            this.txt_totalPurchase.Location = new System.Drawing.Point(873, 185);
            this.txt_totalPurchase.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_totalPurchase.Name = "txt_totalPurchase";
            this.txt_totalPurchase.ReadOnly = true;
            this.txt_totalPurchase.Size = new System.Drawing.Size(132, 27);
            this.txt_totalPurchase.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(764, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Total Receive";
            // 
            // txt_accountBalance
            // 
            this.txt_accountBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_accountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_accountBalance.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountBalance.ForeColor = System.Drawing.Color.White;
            this.txt_accountBalance.Location = new System.Drawing.Point(873, 101);
            this.txt_accountBalance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_accountBalance.Name = "txt_accountBalance";
            this.txt_accountBalance.ReadOnly = true;
            this.txt_accountBalance.Size = new System.Drawing.Size(132, 27);
            this.txt_accountBalance.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchases";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(0, 376);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 302);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_newCustomer);
            this.panel1.Controls.Add(this.btn_addNew);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 65);
            this.panel1.TabIndex = 33;
            // 
            // btn_newCustomer
            // 
            this.btn_newCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_newCustomer.Location = new System.Drawing.Point(465, 3);
            this.btn_newCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_newCustomer.Name = "btn_newCustomer";
            this.btn_newCustomer.Size = new System.Drawing.Size(88, 56);
            this.btn_newCustomer.TabIndex = 62;
            this.btn_newCustomer.TabStop = false;
            this.btn_newCustomer.Text = "New Customer";
            this.btn_newCustomer.UseVisualStyleBackColor = true;
            this.btn_newCustomer.Click += new System.EventHandler(this.btn_newCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(730, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Customer Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_goForward);
            this.groupBox1.Controls.Add(this.txt_dodhiId);
            this.groupBox1.Controls.Add(this.btn_goBack);
            this.groupBox1.Controls.Add(this.txt_dodhiName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.rdo_evening);
            this.groupBox1.Controls.Add(this.rdo_morning);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_totalAmount);
            this.groupBox1.Controls.Add(this.dtm_picker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_customerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_liters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_rate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_purchaseId);
            this.groupBox1.Location = new System.Drawing.Point(14, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(421, 282);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Info";
            // 
            // txt_dodhiId
            // 
            this.txt_dodhiId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dodhiId.Location = new System.Drawing.Point(139, 194);
            this.txt_dodhiId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_dodhiId.Name = "txt_dodhiId";
            this.txt_dodhiId.Size = new System.Drawing.Size(77, 27);
            this.txt_dodhiId.TabIndex = 88;
            this.txt_dodhiId.TextChanged += new System.EventHandler(this.txt_dodhiId_TextChanged);
            // 
            // txt_dodhiName
            // 
            this.txt_dodhiName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dodhiName.Location = new System.Drawing.Point(221, 194);
            this.txt_dodhiName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_dodhiName.Name = "txt_dodhiName";
            this.txt_dodhiName.Size = new System.Drawing.Size(190, 27);
            this.txt_dodhiName.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(90, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "Dodhi";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(139, 62);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(79, 27);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // rdo_evening
            // 
            this.rdo_evening.AutoSize = true;
            this.rdo_evening.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_evening.ForeColor = System.Drawing.Color.Green;
            this.rdo_evening.Location = new System.Drawing.Point(311, 151);
            this.rdo_evening.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdo_evening.Name = "rdo_evening";
            this.rdo_evening.Size = new System.Drawing.Size(87, 25);
            this.rdo_evening.TabIndex = 84;
            this.rdo_evening.Text = "Evening";
            this.rdo_evening.UseVisualStyleBackColor = true;
            // 
            // rdo_morning
            // 
            this.rdo_morning.AutoSize = true;
            this.rdo_morning.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_morning.ForeColor = System.Drawing.Color.Green;
            this.rdo_morning.Location = new System.Drawing.Point(311, 109);
            this.rdo_morning.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdo_morning.Name = "rdo_morning";
            this.rdo_morning.Size = new System.Drawing.Size(91, 25);
            this.rdo_morning.TabIndex = 83;
            this.rdo_morning.Text = "Morning";
            this.rdo_morning.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(41, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Total Amount";
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalAmount.ForeColor = System.Drawing.Color.Navy;
            this.txt_totalAmount.Location = new System.Drawing.Point(139, 240);
            this.txt_totalAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.ReadOnly = true;
            this.txt_totalAmount.Size = new System.Drawing.Size(272, 27);
            this.txt_totalAmount.TabIndex = 81;
            this.txt_totalAmount.TabStop = false;
            // 
            // dtm_picker
            // 
            this.dtm_picker.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_picker.Location = new System.Drawing.Point(221, 21);
            this.dtm_picker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtm_picker.Name = "dtm_picker";
            this.dtm_picker.Size = new System.Drawing.Size(93, 27);
            this.dtm_picker.TabIndex = 79;
            this.dtm_picker.TabStop = false;
            this.dtm_picker.Value = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(54, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Customer Id";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.Location = new System.Drawing.Point(221, 62);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(190, 27);
            this.txt_customerName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(94, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Liters";
            // 
            // txt_liters
            // 
            this.txt_liters.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_liters.Location = new System.Drawing.Point(139, 107);
            this.txt_liters.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_liters.Name = "txt_liters";
            this.txt_liters.Size = new System.Drawing.Size(143, 27);
            this.txt_liters.TabIndex = 2;
            this.txt_liters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_liters_KeyDown);
            this.txt_liters.Leave += new System.EventHandler(this.txt_liters_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(99, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Rate";
            // 
            // txt_rate
            // 
            this.txt_rate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.Location = new System.Drawing.Point(139, 152);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(143, 27);
            this.txt_rate.TabIndex = 3;
            this.txt_rate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_rate_KeyDown);
            this.txt_rate.Leave += new System.EventHandler(this.txt_rate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(58, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Purchase Id";
            // 
            // txt_purchaseId
            // 
            this.txt_purchaseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_purchaseId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchaseId.Location = new System.Drawing.Point(139, 21);
            this.txt_purchaseId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_purchaseId.Name = "txt_purchaseId";
            this.txt_purchaseId.ReadOnly = true;
            this.txt_purchaseId.Size = new System.Drawing.Size(77, 27);
            this.txt_purchaseId.TabIndex = 69;
            this.txt_purchaseId.TabStop = false;
            // 
            // lstCustomersSuggestion
            // 
            this.lstCustomersSuggestion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomersSuggestion.FormattingEnabled = true;
            this.lstCustomersSuggestion.ItemHeight = 17;
            this.lstCustomersSuggestion.Location = new System.Drawing.Point(506, 156);
            this.lstCustomersSuggestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCustomersSuggestion.Name = "lstCustomersSuggestion";
            this.lstCustomersSuggestion.Size = new System.Drawing.Size(272, 191);
            this.lstCustomersSuggestion.TabIndex = 70;
            this.lstCustomersSuggestion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCustomersSuggestion_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(786, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Difference";
            // 
            // txt_difference
            // 
            this.txt_difference.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_difference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_difference.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_difference.ForeColor = System.Drawing.Color.Red;
            this.txt_difference.Location = new System.Drawing.Point(873, 227);
            this.txt_difference.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_difference.Name = "txt_difference";
            this.txt_difference.ReadOnly = true;
            this.txt_difference.Size = new System.Drawing.Size(132, 27);
            this.txt_difference.TabIndex = 70;
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(322, 18);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(45, 31);
            this.btn_goBack.TabIndex = 72;
            this.btn_goBack.Text = "<<";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // btn_goForward
            // 
            this.btn_goForward.Location = new System.Drawing.Point(368, 18);
            this.btn_goForward.Name = "btn_goForward";
            this.btn_goForward.Size = new System.Drawing.Size(45, 31);
            this.btn_goForward.TabIndex = 73;
            this.btn_goForward.Text = ">>";
            this.btn_goForward.UseVisualStyleBackColor = true;
            this.btn_goForward.Click += new System.EventHandler(this.btn_goForward_Click);
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 678);
            this.Controls.Add(this.lstCustomersSuggestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_difference);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_totalReceive);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_totalPurchase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_accountBalance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Purchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.TextBox txt_totalReceive;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_totalPurchase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_accountBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_newCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_evening;
        private System.Windows.Forms.RadioButton rdo_morning;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_totalAmount;
        private System.Windows.Forms.DateTimePicker dtm_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_liters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_purchaseId;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstCustomersSuggestion;
        private System.Windows.Forms.TextBox txt_dodhiId;
        private System.Windows.Forms.TextBox txt_dodhiName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_difference;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Button btn_goForward;
    }
}