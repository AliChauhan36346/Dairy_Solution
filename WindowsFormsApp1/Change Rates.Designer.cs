namespace WindowsFormsApp1
{
    partial class Change_Rates
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_customerId = new System.Windows.Forms.TextBox();
            this.group_customerRate = new System.Windows.Forms.GroupBox();
            this.lst_accountSuggestions = new System.Windows.Forms.ListBox();
            this.rdo_singleCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_decrementRate = new System.Windows.Forms.RadioButton();
            this.rdo_incrementRate = new System.Windows.Forms.RadioButton();
            this.rdo_newRate = new System.Windows.Forms.RadioButton();
            this.rdo_byAddress = new System.Windows.Forms.RadioButton();
            this.rdo_dodhiWise = new System.Windows.Forms.RadioButton();
            this.rdo_allCustomerRate = new System.Windows.Forms.RadioButton();
            this.btn_updateChanges = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newRate = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.cmbo_byAddress = new System.Windows.Forms.ComboBox();
            this.cmbo_byDodhi = new System.Windows.Forms.ComboBox();
            this.rdo_customerRateChange = new System.Windows.Forms.RadioButton();
            this.rdo_companyRateChange = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.group_customerRate.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 58);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(356, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rate list";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate Adjustments";
            // 
            // txt_customerId
            // 
            this.txt_customerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_customerId.Location = new System.Drawing.Point(122, 271);
            this.txt_customerId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customerId.Name = "txt_customerId";
            this.txt_customerId.Size = new System.Drawing.Size(81, 25);
            this.txt_customerId.TabIndex = 4;
            this.txt_customerId.TextChanged += new System.EventHandler(this.txt_customerId_TextChanged);
            this.txt_customerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customerId_KeyDown);
            this.txt_customerId.Leave += new System.EventHandler(this.txt_customerId_Leave);
            // 
            // group_customerRate
            // 
            this.group_customerRate.Controls.Add(this.lst_accountSuggestions);
            this.group_customerRate.Controls.Add(this.rdo_singleCustomer);
            this.group_customerRate.Controls.Add(this.groupBox3);
            this.group_customerRate.Controls.Add(this.rdo_byAddress);
            this.group_customerRate.Controls.Add(this.rdo_dodhiWise);
            this.group_customerRate.Controls.Add(this.rdo_allCustomerRate);
            this.group_customerRate.Controls.Add(this.btn_updateChanges);
            this.group_customerRate.Controls.Add(this.label3);
            this.group_customerRate.Controls.Add(this.txt_newRate);
            this.group_customerRate.Controls.Add(this.txt_customerName);
            this.group_customerRate.Controls.Add(this.cmbo_byAddress);
            this.group_customerRate.Controls.Add(this.cmbo_byDodhi);
            this.group_customerRate.Controls.Add(this.txt_customerId);
            this.group_customerRate.Location = new System.Drawing.Point(30, 155);
            this.group_customerRate.Margin = new System.Windows.Forms.Padding(4);
            this.group_customerRate.Name = "group_customerRate";
            this.group_customerRate.Padding = new System.Windows.Forms.Padding(4);
            this.group_customerRate.Size = new System.Drawing.Size(381, 360);
            this.group_customerRate.TabIndex = 6;
            this.group_customerRate.TabStop = false;
            this.group_customerRate.Text = "Customers Rate";
            // 
            // lst_accountSuggestions
            // 
            this.lst_accountSuggestions.FormattingEnabled = true;
            this.lst_accountSuggestions.ItemHeight = 17;
            this.lst_accountSuggestions.Location = new System.Drawing.Point(122, 63);
            this.lst_accountSuggestions.Name = "lst_accountSuggestions";
            this.lst_accountSuggestions.Size = new System.Drawing.Size(233, 208);
            this.lst_accountSuggestions.TabIndex = 28;
            // 
            // rdo_singleCustomer
            // 
            this.rdo_singleCustomer.AutoSize = true;
            this.rdo_singleCustomer.ForeColor = System.Drawing.Color.Black;
            this.rdo_singleCustomer.Location = new System.Drawing.Point(13, 271);
            this.rdo_singleCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_singleCustomer.Name = "rdo_singleCustomer";
            this.rdo_singleCustomer.Size = new System.Drawing.Size(101, 21);
            this.rdo_singleCustomer.TabIndex = 27;
            this.rdo_singleCustomer.TabStop = true;
            this.rdo_singleCustomer.Text = "Single Cu/Co";
            this.rdo_singleCustomer.UseVisualStyleBackColor = true;
            this.rdo_singleCustomer.CheckedChanged += new System.EventHandler(this.rdo_singleCustomer_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_decrementRate);
            this.groupBox3.Controls.Add(this.rdo_incrementRate);
            this.groupBox3.Controls.Add(this.rdo_newRate);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(113, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 124);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Basis";
            // 
            // rdo_decrementRate
            // 
            this.rdo_decrementRate.AutoSize = true;
            this.rdo_decrementRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_decrementRate.ForeColor = System.Drawing.Color.Red;
            this.rdo_decrementRate.Location = new System.Drawing.Point(6, 57);
            this.rdo_decrementRate.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_decrementRate.Name = "rdo_decrementRate";
            this.rdo_decrementRate.Size = new System.Drawing.Size(136, 21);
            this.rdo_decrementRate.TabIndex = 25;
            this.rdo_decrementRate.TabStop = true;
            this.rdo_decrementRate.Text = "Decriment Rate (-)";
            this.rdo_decrementRate.UseVisualStyleBackColor = true;
            // 
            // rdo_incrementRate
            // 
            this.rdo_incrementRate.AutoSize = true;
            this.rdo_incrementRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_incrementRate.ForeColor = System.Drawing.Color.Green;
            this.rdo_incrementRate.Location = new System.Drawing.Point(6, 27);
            this.rdo_incrementRate.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_incrementRate.Name = "rdo_incrementRate";
            this.rdo_incrementRate.Size = new System.Drawing.Size(140, 21);
            this.rdo_incrementRate.TabIndex = 24;
            this.rdo_incrementRate.TabStop = true;
            this.rdo_incrementRate.Text = "Increment Rate (+)";
            this.rdo_incrementRate.UseVisualStyleBackColor = true;
            // 
            // rdo_newRate
            // 
            this.rdo_newRate.AutoSize = true;
            this.rdo_newRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_newRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdo_newRate.Location = new System.Drawing.Point(6, 87);
            this.rdo_newRate.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_newRate.Name = "rdo_newRate";
            this.rdo_newRate.Size = new System.Drawing.Size(84, 21);
            this.rdo_newRate.TabIndex = 23;
            this.rdo_newRate.TabStop = true;
            this.rdo_newRate.Text = "New Rate";
            this.rdo_newRate.UseVisualStyleBackColor = true;
            // 
            // rdo_byAddress
            // 
            this.rdo_byAddress.AutoSize = true;
            this.rdo_byAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdo_byAddress.Location = new System.Drawing.Point(23, 226);
            this.rdo_byAddress.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_byAddress.Name = "rdo_byAddress";
            this.rdo_byAddress.Size = new System.Drawing.Size(91, 21);
            this.rdo_byAddress.TabIndex = 25;
            this.rdo_byAddress.TabStop = true;
            this.rdo_byAddress.Text = "By Address";
            this.rdo_byAddress.UseVisualStyleBackColor = true;
            this.rdo_byAddress.CheckedChanged += new System.EventHandler(this.rdo_byAddress_CheckedChanged);
            // 
            // rdo_dodhiWise
            // 
            this.rdo_dodhiWise.AutoSize = true;
            this.rdo_dodhiWise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_dodhiWise.Location = new System.Drawing.Point(36, 180);
            this.rdo_dodhiWise.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_dodhiWise.Name = "rdo_dodhiWise";
            this.rdo_dodhiWise.Size = new System.Drawing.Size(78, 21);
            this.rdo_dodhiWise.TabIndex = 24;
            this.rdo_dodhiWise.TabStop = true;
            this.rdo_dodhiWise.Text = "By Dodhi";
            this.rdo_dodhiWise.UseVisualStyleBackColor = true;
            this.rdo_dodhiWise.CheckedChanged += new System.EventHandler(this.rdo_dodhiWise_CheckedChanged);
            // 
            // rdo_allCustomerRate
            // 
            this.rdo_allCustomerRate.AutoSize = true;
            this.rdo_allCustomerRate.ForeColor = System.Drawing.Color.Green;
            this.rdo_allCustomerRate.Location = new System.Drawing.Point(16, 144);
            this.rdo_allCustomerRate.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_allCustomerRate.Name = "rdo_allCustomerRate";
            this.rdo_allCustomerRate.Size = new System.Drawing.Size(275, 21);
            this.rdo_allCustomerRate.TabIndex = 23;
            this.rdo_allCustomerRate.TabStop = true;
            this.rdo_allCustomerRate.Text = "All Customers OR Companies Rate Change";
            this.rdo_allCustomerRate.UseVisualStyleBackColor = true;
            // 
            // btn_updateChanges
            // 
            this.btn_updateChanges.BackColor = System.Drawing.Color.White;
            this.btn_updateChanges.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_updateChanges.Location = new System.Drawing.Point(211, 315);
            this.btn_updateChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateChanges.Name = "btn_updateChanges";
            this.btn_updateChanges.Size = new System.Drawing.Size(144, 30);
            this.btn_updateChanges.TabIndex = 19;
            this.btn_updateChanges.Text = "Update Changes...";
            this.btn_updateChanges.UseVisualStyleBackColor = false;
            this.btn_updateChanges.Click += new System.EventHandler(this.btn_updateChanges_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(57, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "New Rate";
            // 
            // txt_newRate
            // 
            this.txt_newRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_newRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newRate.ForeColor = System.Drawing.Color.White;
            this.txt_newRate.Location = new System.Drawing.Point(122, 318);
            this.txt_newRate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newRate.Name = "txt_newRate";
            this.txt_newRate.Size = new System.Drawing.Size(81, 25);
            this.txt_newRate.TabIndex = 17;
            // 
            // txt_customerName
            // 
            this.txt_customerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_customerName.Location = new System.Drawing.Point(208, 271);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(146, 25);
            this.txt_customerName.TabIndex = 15;
            // 
            // cmbo_byAddress
            // 
            this.cmbo_byAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_byAddress.FormattingEnabled = true;
            this.cmbo_byAddress.Location = new System.Drawing.Point(122, 225);
            this.cmbo_byAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_byAddress.Name = "cmbo_byAddress";
            this.cmbo_byAddress.Size = new System.Drawing.Size(231, 25);
            this.cmbo_byAddress.TabIndex = 14;
            // 
            // cmbo_byDodhi
            // 
            this.cmbo_byDodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_byDodhi.FormattingEnabled = true;
            this.cmbo_byDodhi.Location = new System.Drawing.Point(122, 179);
            this.cmbo_byDodhi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_byDodhi.Name = "cmbo_byDodhi";
            this.cmbo_byDodhi.Size = new System.Drawing.Size(231, 25);
            this.cmbo_byDodhi.TabIndex = 12;
            // 
            // rdo_customerRateChange
            // 
            this.rdo_customerRateChange.AutoSize = true;
            this.rdo_customerRateChange.BackColor = System.Drawing.Color.Linen;
            this.rdo_customerRateChange.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_customerRateChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_customerRateChange.Location = new System.Drawing.Point(124, 115);
            this.rdo_customerRateChange.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_customerRateChange.Name = "rdo_customerRateChange";
            this.rdo_customerRateChange.Size = new System.Drawing.Size(203, 25);
            this.rdo_customerRateChange.TabIndex = 7;
            this.rdo_customerRateChange.TabStop = true;
            this.rdo_customerRateChange.Text = "Customers Rate Change";
            this.rdo_customerRateChange.UseVisualStyleBackColor = false;
            this.rdo_customerRateChange.CheckedChanged += new System.EventHandler(this.rdo_customerRateChange_CheckedChanged);
            // 
            // rdo_companyRateChange
            // 
            this.rdo_companyRateChange.AutoSize = true;
            this.rdo_companyRateChange.BackColor = System.Drawing.Color.Azure;
            this.rdo_companyRateChange.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_companyRateChange.ForeColor = System.Drawing.Color.Blue;
            this.rdo_companyRateChange.Location = new System.Drawing.Point(124, 71);
            this.rdo_companyRateChange.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_companyRateChange.Name = "rdo_companyRateChange";
            this.rdo_companyRateChange.Size = new System.Drawing.Size(207, 25);
            this.rdo_companyRateChange.TabIndex = 12;
            this.rdo_companyRateChange.TabStop = true;
            this.rdo_companyRateChange.Text = "Companies Rate Change";
            this.rdo_companyRateChange.UseVisualStyleBackColor = false;
            this.rdo_companyRateChange.CheckedChanged += new System.EventHandler(this.rdo_companyRateChange_CheckedChanged);
            // 
            // Change_Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 528);
            this.Controls.Add(this.rdo_companyRateChange);
            this.Controls.Add(this.rdo_customerRateChange);
            this.Controls.Add(this.group_customerRate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_Rates";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change_Rates";
            this.Load += new System.EventHandler(this.Change_Rates_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group_customerRate.ResumeLayout(false);
            this.group_customerRate.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customerId;
        private System.Windows.Forms.GroupBox group_customerRate;
        private System.Windows.Forms.ComboBox cmbo_byDodhi;
        private System.Windows.Forms.RadioButton rdo_customerRateChange;
        private System.Windows.Forms.ComboBox cmbo_byAddress;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newRate;
        private System.Windows.Forms.Button btn_updateChanges;
        private System.Windows.Forms.RadioButton rdo_byAddress;
        private System.Windows.Forms.RadioButton rdo_dodhiWise;
        private System.Windows.Forms.RadioButton rdo_allCustomerRate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_decrementRate;
        private System.Windows.Forms.RadioButton rdo_incrementRate;
        private System.Windows.Forms.RadioButton rdo_newRate;
        private System.Windows.Forms.RadioButton rdo_singleCustomer;
        private System.Windows.Forms.RadioButton rdo_companyRateChange;
        private System.Windows.Forms.ListBox lst_accountSuggestions;
        private System.Windows.Forms.Button button1;
    }
}