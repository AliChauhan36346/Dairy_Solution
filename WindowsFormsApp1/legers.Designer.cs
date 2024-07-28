namespace WindowsFormsApp1
{
    partial class legers
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
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_cashPayment = new System.Windows.Forms.Button();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.chkBox_fromDate = new System.Windows.Forms.CheckBox();
            this.btn_milkCard = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_endDate = new System.Windows.Forms.DateTimePicker();
            this.dtm_startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_accountName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalBalance = new System.Windows.Forms.TextBox();
            this.txt_totalCredit = new System.Windows.Forms.TextBox();
            this.txt_totalDebit = new System.Windows.Forms.TextBox();
            this.lstSuggestions = new System.Windows.Forms.ListBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl_forwardBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.Location = new System.Drawing.Point(878, 36);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(88, 39);
            this.btn_dashboard.TabIndex = 27;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Legers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(972, 473);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Controls.Add(this.btn_cashPayment);
            this.panel1.Controls.Add(this.txtAccountId);
            this.panel1.Controls.Add(this.chkBox_fromDate);
            this.panel1.Controls.Add(this.btn_milkCard);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_display);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtm_endDate);
            this.panel1.Controls.Add(this.dtm_startDate);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_accountName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 125);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.White;
            this.btn_purchase.Location = new System.Drawing.Point(4, 81);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(103, 39);
            this.btn_purchase.TabIndex = 32;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // btn_cashPayment
            // 
            this.btn_cashPayment.BackColor = System.Drawing.Color.White;
            this.btn_cashPayment.Location = new System.Drawing.Point(4, 40);
            this.btn_cashPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cashPayment.Name = "btn_cashPayment";
            this.btn_cashPayment.Size = new System.Drawing.Size(103, 39);
            this.btn_cashPayment.TabIndex = 31;
            this.btn_cashPayment.Text = "Cash Payment";
            this.btn_cashPayment.UseVisualStyleBackColor = false;
            this.btn_cashPayment.Click += new System.EventHandler(this.btn_cashPayment_Click);
            // 
            // txtAccountId
            // 
            this.txtAccountId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountId.Location = new System.Drawing.Point(367, 38);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(100, 27);
            this.txtAccountId.TabIndex = 0;
            this.txtAccountId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountId.TextChanged += new System.EventHandler(this.txtAccountId_TextChanged);
            this.txtAccountId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountId_KeyDown);
            this.txtAccountId.Leave += new System.EventHandler(this.txtAccountId_Leave);
            // 
            // chkBox_fromDate
            // 
            this.chkBox_fromDate.AutoSize = true;
            this.chkBox_fromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_fromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBox_fromDate.Location = new System.Drawing.Point(370, 86);
            this.chkBox_fromDate.Name = "chkBox_fromDate";
            this.chkBox_fromDate.Size = new System.Drawing.Size(92, 21);
            this.chkBox_fromDate.TabIndex = 30;
            this.chkBox_fromDate.Text = "From Date";
            this.chkBox_fromDate.UseVisualStyleBackColor = true;
            this.chkBox_fromDate.CheckedChanged += new System.EventHandler(this.chkBox_fromDate_CheckedChanged);
            // 
            // btn_milkCard
            // 
            this.btn_milkCard.BackColor = System.Drawing.Color.White;
            this.btn_milkCard.Location = new System.Drawing.Point(734, 74);
            this.btn_milkCard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_milkCard.Name = "btn_milkCard";
            this.btn_milkCard.Size = new System.Drawing.Size(68, 39);
            this.btn_milkCard.TabIndex = 28;
            this.btn_milkCard.Text = "M-Card";
            this.btn_milkCard.UseVisualStyleBackColor = false;
            this.btn_milkCard.Click += new System.EventHandler(this.btn_milkCard_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(806, 36);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(68, 39);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.White;
            this.btn_display.Location = new System.Drawing.Point(734, 36);
            this.btn_display.Margin = new System.Windows.Forms.Padding(4);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(68, 39);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "to";
            // 
            // dtm_endDate
            // 
            this.dtm_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_endDate.Location = new System.Drawing.Point(614, 83);
            this.dtm_endDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtm_endDate.Name = "dtm_endDate";
            this.dtm_endDate.Size = new System.Drawing.Size(112, 25);
            this.dtm_endDate.TabIndex = 5;
            // 
            // dtm_startDate
            // 
            this.dtm_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_startDate.Location = new System.Drawing.Point(470, 83);
            this.dtm_startDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtm_startDate.Name = "dtm_startDate";
            this.dtm_startDate.Size = new System.Drawing.Size(109, 25);
            this.dtm_startDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(232, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Account";
            // 
            // txt_accountName
            // 
            this.txt_accountName.BackColor = System.Drawing.Color.White;
            this.txt_accountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountName.Location = new System.Drawing.Point(470, 38);
            this.txt_accountName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_accountName.Name = "txt_accountName";
            this.txt_accountName.ReadOnly = true;
            this.txt_accountName.Size = new System.Drawing.Size(256, 27);
            this.txt_accountName.TabIndex = 1;
            this.txt_accountName.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_totalBalance);
            this.panel2.Controls.Add(this.txt_totalCredit);
            this.panel2.Controls.Add(this.txt_totalDebit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 632);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 45);
            this.panel2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(490, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Totals Rs";
            // 
            // txt_totalBalance
            // 
            this.txt_totalBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_totalBalance.Location = new System.Drawing.Point(784, 8);
            this.txt_totalBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalBalance.Name = "txt_totalBalance";
            this.txt_totalBalance.Size = new System.Drawing.Size(179, 27);
            this.txt_totalBalance.TabIndex = 2;
            // 
            // txt_totalCredit
            // 
            this.txt_totalCredit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalCredit.ForeColor = System.Drawing.Color.Green;
            this.txt_totalCredit.Location = new System.Drawing.Point(681, 8);
            this.txt_totalCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalCredit.Name = "txt_totalCredit";
            this.txt_totalCredit.Size = new System.Drawing.Size(99, 27);
            this.txt_totalCredit.TabIndex = 1;
            // 
            // txt_totalDebit
            // 
            this.txt_totalDebit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_totalDebit.Location = new System.Drawing.Point(578, 8);
            this.txt_totalDebit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalDebit.Name = "txt_totalDebit";
            this.txt_totalDebit.Size = new System.Drawing.Size(99, 27);
            this.txt_totalDebit.TabIndex = 0;
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.FormattingEnabled = true;
            this.lstSuggestions.ItemHeight = 17;
            this.lstSuggestions.Location = new System.Drawing.Point(369, 68);
            this.lstSuggestions.Margin = new System.Windows.Forms.Padding(4);
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(360, 310);
            this.lstSuggestions.TabIndex = 40;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lbl_forwardBalance
            // 
            this.lbl_forwardBalance.AutoSize = true;
            this.lbl_forwardBalance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forwardBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_forwardBalance.Location = new System.Drawing.Point(619, 134);
            this.lbl_forwardBalance.Name = "lbl_forwardBalance";
            this.lbl_forwardBalance.Size = new System.Drawing.Size(71, 19);
            this.lbl_forwardBalance.TabIndex = 41;
            this.lbl_forwardBalance.Text = "Balance";
            // 
            // legers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 677);
            this.Controls.Add(this.lstSuggestions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_forwardBalance);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "legers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "legers";
            this.Load += new System.EventHandler(this.legers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_accountName;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_endDate;
        private System.Windows.Forms.DateTimePicker dtm_startDate;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalBalance;
        private System.Windows.Forms.TextBox txt_totalCredit;
        private System.Windows.Forms.TextBox txt_totalDebit;
        private System.Windows.Forms.Button btn_milkCard;
        private System.Windows.Forms.ListBox lstSuggestions;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbl_forwardBalance;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.CheckBox chkBox_fromDate;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_cashPayment;
    }
}