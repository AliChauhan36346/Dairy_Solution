namespace WindowsFormsApp1
{
    partial class IncomeStatement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_endDate = new System.Windows.Forms.DateTimePicker();
            this.dtm_startDate = new System.Windows.Forms.DateTimePicker();
            this.dtm_uptoDate = new System.Windows.Forms.DateTimePicker();
            this.rdo_fromDate = new System.Windows.Forms.RadioButton();
            this.rdo_uptoDate = new System.Windows.Forms.RadioButton();
            this.rdo_toDate = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_salesLtr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_averageSalesRate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_salesAmount = new System.Windows.Forms.Label();
            this.lbl_purchasedLtr = new System.Windows.Forms.Label();
            this.lbl_averagePurchasedRate = new System.Windows.Forms.Label();
            this.lbl_purchaseAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_expenses = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_netProfitLoss = new System.Windows.Forms.Label();
            this.lbl_profitOrLoss = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 56);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(335, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Statement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtm_endDate);
            this.panel2.Controls.Add(this.dtm_startDate);
            this.panel2.Controls.Add(this.dtm_uptoDate);
            this.panel2.Controls.Add(this.rdo_fromDate);
            this.panel2.Controls.Add(this.rdo_uptoDate);
            this.panel2.Controls.Add(this.rdo_toDate);
            this.panel2.Location = new System.Drawing.Point(23, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 150);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "(From start to today)";
            // 
            // dtm_endDate
            // 
            this.dtm_endDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_endDate.Location = new System.Drawing.Point(253, 103);
            this.dtm_endDate.Name = "dtm_endDate";
            this.dtm_endDate.Size = new System.Drawing.Size(120, 27);
            this.dtm_endDate.TabIndex = 9;
            // 
            // dtm_startDate
            // 
            this.dtm_startDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_startDate.Location = new System.Drawing.Point(119, 103);
            this.dtm_startDate.Name = "dtm_startDate";
            this.dtm_startDate.Size = new System.Drawing.Size(118, 27);
            this.dtm_startDate.TabIndex = 8;
            // 
            // dtm_uptoDate
            // 
            this.dtm_uptoDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_uptoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_uptoDate.Location = new System.Drawing.Point(119, 61);
            this.dtm_uptoDate.Name = "dtm_uptoDate";
            this.dtm_uptoDate.Size = new System.Drawing.Size(118, 27);
            this.dtm_uptoDate.TabIndex = 7;
            // 
            // rdo_fromDate
            // 
            this.rdo_fromDate.AutoSize = true;
            this.rdo_fromDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_fromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdo_fromDate.Location = new System.Drawing.Point(11, 103);
            this.rdo_fromDate.Name = "rdo_fromDate";
            this.rdo_fromDate.Size = new System.Drawing.Size(102, 24);
            this.rdo_fromDate.TabIndex = 6;
            this.rdo_fromDate.TabStop = true;
            this.rdo_fromDate.Text = "From Date";
            this.rdo_fromDate.UseVisualStyleBackColor = true;
            this.rdo_fromDate.CheckedChanged += new System.EventHandler(this.rdo_fromDate_CheckedChanged);
            // 
            // rdo_uptoDate
            // 
            this.rdo_uptoDate.AutoSize = true;
            this.rdo_uptoDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_uptoDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdo_uptoDate.Location = new System.Drawing.Point(11, 61);
            this.rdo_uptoDate.Name = "rdo_uptoDate";
            this.rdo_uptoDate.Size = new System.Drawing.Size(100, 24);
            this.rdo_uptoDate.TabIndex = 5;
            this.rdo_uptoDate.TabStop = true;
            this.rdo_uptoDate.Text = "Upto Date";
            this.rdo_uptoDate.UseVisualStyleBackColor = true;
            this.rdo_uptoDate.CheckedChanged += new System.EventHandler(this.rdo_uptoDate_CheckedChanged);
            // 
            // rdo_toDate
            // 
            this.rdo_toDate.AutoSize = true;
            this.rdo_toDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_toDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_toDate.Location = new System.Drawing.Point(11, 19);
            this.rdo_toDate.Name = "rdo_toDate";
            this.rdo_toDate.Size = new System.Drawing.Size(83, 24);
            this.rdo_toDate.TabIndex = 4;
            this.rdo_toDate.TabStop = true;
            this.rdo_toDate.Text = "To Date";
            this.rdo_toDate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(468, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Sales:";
            // 
            // lbl_salesLtr
            // 
            this.lbl_salesLtr.AutoSize = true;
            this.lbl_salesLtr.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesLtr.ForeColor = System.Drawing.Color.Green;
            this.lbl_salesLtr.Location = new System.Drawing.Point(593, 54);
            this.lbl_salesLtr.Name = "lbl_salesLtr";
            this.lbl_salesLtr.Size = new System.Drawing.Size(23, 25);
            this.lbl_salesLtr.TabIndex = 6;
            this.lbl_salesLtr.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(422, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Purchases:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(594, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ltrs";
            // 
            // lbl_averageSalesRate
            // 
            this.lbl_averageSalesRate.AutoSize = true;
            this.lbl_averageSalesRate.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_averageSalesRate.ForeColor = System.Drawing.Color.Olive;
            this.lbl_averageSalesRate.Location = new System.Drawing.Point(688, 54);
            this.lbl_averageSalesRate.Name = "lbl_averageSalesRate";
            this.lbl_averageSalesRate.Size = new System.Drawing.Size(23, 25);
            this.lbl_averageSalesRate.TabIndex = 9;
            this.lbl_averageSalesRate.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(688, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Avg Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(797, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Amount Rs";
            // 
            // lbl_salesAmount
            // 
            this.lbl_salesAmount.AutoSize = true;
            this.lbl_salesAmount.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesAmount.ForeColor = System.Drawing.Color.Blue;
            this.lbl_salesAmount.Location = new System.Drawing.Point(796, 54);
            this.lbl_salesAmount.Name = "lbl_salesAmount";
            this.lbl_salesAmount.Size = new System.Drawing.Size(23, 25);
            this.lbl_salesAmount.TabIndex = 12;
            this.lbl_salesAmount.Text = "0";
            // 
            // lbl_purchasedLtr
            // 
            this.lbl_purchasedLtr.AutoSize = true;
            this.lbl_purchasedLtr.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchasedLtr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_purchasedLtr.Location = new System.Drawing.Point(593, 96);
            this.lbl_purchasedLtr.Name = "lbl_purchasedLtr";
            this.lbl_purchasedLtr.Size = new System.Drawing.Size(23, 25);
            this.lbl_purchasedLtr.TabIndex = 13;
            this.lbl_purchasedLtr.Text = "0";
            // 
            // lbl_averagePurchasedRate
            // 
            this.lbl_averagePurchasedRate.AutoSize = true;
            this.lbl_averagePurchasedRate.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_averagePurchasedRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_averagePurchasedRate.Location = new System.Drawing.Point(687, 95);
            this.lbl_averagePurchasedRate.Name = "lbl_averagePurchasedRate";
            this.lbl_averagePurchasedRate.Size = new System.Drawing.Size(23, 25);
            this.lbl_averagePurchasedRate.TabIndex = 14;
            this.lbl_averagePurchasedRate.Text = "0";
            
            // 
            // lbl_purchaseAmount
            // 
            this.lbl_purchaseAmount.AutoSize = true;
            this.lbl_purchaseAmount.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchaseAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_purchaseAmount.Location = new System.Drawing.Point(796, 95);
            this.lbl_purchaseAmount.Name = "lbl_purchaseAmount";
            this.lbl_purchaseAmount.Size = new System.Drawing.Size(23, 25);
            this.lbl_purchaseAmount.TabIndex = 15;
            this.lbl_purchaseAmount.Text = "0";
            
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(485, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Expenses:";
            // 
            // lbl_expenses
            // 
            this.lbl_expenses.AutoSize = true;
            this.lbl_expenses.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_expenses.Location = new System.Drawing.Point(796, 136);
            this.lbl_expenses.Name = "lbl_expenses";
            this.lbl_expenses.Size = new System.Drawing.Size(23, 25);
            this.lbl_expenses.TabIndex = 17;
            this.lbl_expenses.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(418, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 25);
            this.label16.TabIndex = 18;
            this.label16.Text = "Net Profit / Loss:";
            // 
            // lbl_netProfitLoss
            // 
            this.lbl_netProfitLoss.AutoSize = true;
            this.lbl_netProfitLoss.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_netProfitLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_netProfitLoss.Location = new System.Drawing.Point(796, 177);
            this.lbl_netProfitLoss.Name = "lbl_netProfitLoss";
            this.lbl_netProfitLoss.Size = new System.Drawing.Size(26, 30);
            this.lbl_netProfitLoss.TabIndex = 19;
            this.lbl_netProfitLoss.Text = "0";
            
            // 
            // lbl_profitOrLoss
            // 
            this.lbl_profitOrLoss.AutoSize = true;
            this.lbl_profitOrLoss.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profitOrLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_profitOrLoss.Location = new System.Drawing.Point(860, 202);
            this.lbl_profitOrLoss.Name = "lbl_profitOrLoss";
            this.lbl_profitOrLoss.Size = new System.Drawing.Size(17, 21);
            this.lbl_profitOrLoss.TabIndex = 20;
            this.lbl_profitOrLoss.Text = "?";
            // 
            // IncomeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 247);
            this.Controls.Add(this.lbl_profitOrLoss);
            this.Controls.Add(this.lbl_netProfitLoss);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_expenses);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_purchaseAmount);
            this.Controls.Add(this.lbl_averagePurchasedRate);
            this.Controls.Add(this.lbl_purchasedLtr);
            this.Controls.Add(this.lbl_salesAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_averageSalesRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_salesLtr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "IncomeStatement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Income Statement";
            this.Load += new System.EventHandler(this.IncomeStatement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtm_uptoDate;
        private System.Windows.Forms.RadioButton rdo_fromDate;
        private System.Windows.Forms.RadioButton rdo_uptoDate;
        private System.Windows.Forms.RadioButton rdo_toDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_endDate;
        private System.Windows.Forms.DateTimePicker dtm_startDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_salesLtr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_averageSalesRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_salesAmount;
        private System.Windows.Forms.Label lbl_purchasedLtr;
        private System.Windows.Forms.Label lbl_averagePurchasedRate;
        private System.Windows.Forms.Label lbl_purchaseAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_expenses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_netProfitLoss;
        private System.Windows.Forms.Label lbl_profitOrLoss;
    }
}