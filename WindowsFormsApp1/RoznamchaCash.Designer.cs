namespace WindowsFormsApp1
{
    partial class RoznamchaCash
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_receipts = new System.Windows.Forms.Button();
            this.btn_Payments = new System.Windows.Forms.Button();
            this.chk_expense = new System.Windows.Forms.CheckBox();
            this.btn_roznamcha = new System.Windows.Forms.Button();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_receiptTotal = new System.Windows.Forms.TextBox();
            this.txt_paymentTotal = new System.Windows.Forms.TextBox();
            this.lbl_openingBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_datagridId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roznamcha Cash";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_receipts);
            this.panel1.Controls.Add(this.btn_Payments);
            this.panel1.Controls.Add(this.chk_expense);
            this.panel1.Controls.Add(this.btn_roznamcha);
            this.panel1.Controls.Add(this.dtm_end);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 96);
            this.panel1.TabIndex = 1;
            // 
            // btn_receipts
            // 
            this.btn_receipts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receipts.Location = new System.Drawing.Point(875, 49);
            this.btn_receipts.Margin = new System.Windows.Forms.Padding(5);
            this.btn_receipts.Name = "btn_receipts";
            this.btn_receipts.Size = new System.Drawing.Size(100, 36);
            this.btn_receipts.TabIndex = 23;
            this.btn_receipts.Text = "Receipts";
            this.btn_receipts.UseVisualStyleBackColor = true;
            this.btn_receipts.Click += new System.EventHandler(this.btn_receipts_Click);
            // 
            // btn_Payments
            // 
            this.btn_Payments.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payments.Location = new System.Drawing.Point(875, 8);
            this.btn_Payments.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Payments.Name = "btn_Payments";
            this.btn_Payments.Size = new System.Drawing.Size(100, 36);
            this.btn_Payments.TabIndex = 22;
            this.btn_Payments.Text = "Payments";
            this.btn_Payments.UseVisualStyleBackColor = true;
            this.btn_Payments.Click += new System.EventHandler(this.btn_Payments_Click);
            // 
            // chk_expense
            // 
            this.chk_expense.AutoSize = true;
            this.chk_expense.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_expense.ForeColor = System.Drawing.Color.Blue;
            this.chk_expense.Location = new System.Drawing.Point(354, 61);
            this.chk_expense.Name = "chk_expense";
            this.chk_expense.Size = new System.Drawing.Size(141, 24);
            this.chk_expense.TabIndex = 4;
            this.chk_expense.Text = "Include Expense";
            this.chk_expense.UseVisualStyleBackColor = true;
            // 
            // btn_roznamcha
            // 
            this.btn_roznamcha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roznamcha.Location = new System.Drawing.Point(711, 13);
            this.btn_roznamcha.Margin = new System.Windows.Forms.Padding(5);
            this.btn_roznamcha.Name = "btn_roznamcha";
            this.btn_roznamcha.Size = new System.Drawing.Size(96, 59);
            this.btn_roznamcha.TabIndex = 21;
            this.btn_roznamcha.Text = "Display\r\nRoznamcha";
            this.btn_roznamcha.UseVisualStyleBackColor = true;
            this.btn_roznamcha.Click += new System.EventHandler(this.btn_roznamcha_Click);
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(546, 21);
            this.dtm_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(135, 27);
            this.dtm_end.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(506, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "to";
            // 
            // dtm_start
            // 
            this.dtm_start.CalendarForeColor = System.Drawing.Color.Black;
            this.dtm_start.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_start.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtm_start.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_start.Location = new System.Drawing.Point(354, 21);
            this.dtm_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(139, 27);
            this.dtm_start.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 487);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txt_balance);
            this.panel2.Controls.Add(this.txt_receiptTotal);
            this.panel2.Controls.Add(this.txt_paymentTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 46);
            this.panel2.TabIndex = 3;
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_balance.Location = new System.Drawing.Point(1107, 11);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(110, 26);
            this.txt_balance.TabIndex = 8;
            // 
            // txt_receiptTotal
            // 
            this.txt_receiptTotal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receiptTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_receiptTotal.Location = new System.Drawing.Point(1004, 11);
            this.txt_receiptTotal.Name = "txt_receiptTotal";
            this.txt_receiptTotal.Size = new System.Drawing.Size(97, 26);
            this.txt_receiptTotal.TabIndex = 7;
            // 
            // txt_paymentTotal
            // 
            this.txt_paymentTotal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_paymentTotal.Location = new System.Drawing.Point(901, 11);
            this.txt_paymentTotal.Name = "txt_paymentTotal";
            this.txt_paymentTotal.Size = new System.Drawing.Size(97, 26);
            this.txt_paymentTotal.TabIndex = 6;
            // 
            // lbl_openingBalance
            // 
            this.lbl_openingBalance.AutoSize = true;
            this.lbl_openingBalance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_openingBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_openingBalance.Location = new System.Drawing.Point(900, 118);
            this.lbl_openingBalance.Name = "lbl_openingBalance";
            this.lbl_openingBalance.Size = new System.Drawing.Size(191, 18);
            this.lbl_openingBalance.TabIndex = 4;
            this.lbl_openingBalance.Text = "Accounts Opening Balance is: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 90;
            this.label5.Text = "Search here";
            // 
            // txt_datagridId
            // 
            this.txt_datagridId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datagridId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_datagridId.Location = new System.Drawing.Point(108, 109);
            this.txt_datagridId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_datagridId.Name = "txt_datagridId";
            this.txt_datagridId.Size = new System.Drawing.Size(268, 27);
            this.txt_datagridId.TabIndex = 89;
            this.txt_datagridId.TextChanged += new System.EventHandler(this.txt_datagridId_TextChanged);
            // 
            // RoznamchaCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_datagridId);
            this.Controls.Add(this.lbl_openingBalance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoznamchaCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RoznamchaCash";
            this.Load += new System.EventHandler(this.RoznamchaCash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_roznamcha;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.CheckBox chk_expense;
        private System.Windows.Forms.TextBox txt_receiptTotal;
        private System.Windows.Forms.TextBox txt_paymentTotal;
        private System.Windows.Forms.Label lbl_openingBalance;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Button btn_receipts;
        private System.Windows.Forms.Button btn_Payments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_datagridId;
    }
}