namespace WindowsFormsApp1
{
    partial class ProfitLoss
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
            this.btn_view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_profitLoss = new System.Windows.Forms.TextBox();
            this.txt_salesAmount = new System.Windows.Forms.TextBox();
            this.txt_totalExpense = new System.Windows.Forms.TextBox();
            this.txt_purchaseAmount = new System.Windows.Forms.TextBox();
            this.txt_totalPurchase = new System.Windows.Forms.TextBox();
            this.txt_totalSales = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_view);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtm_end);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 74);
            this.panel1.TabIndex = 0;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.White;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(770, 13);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(78, 43);
            this.btn_view.TabIndex = 15;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Profit Loss";
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(621, 22);
            this.dtm_end.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(131, 27);
            this.dtm_end.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(582, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "to";
            // 
            // dtm_start
            // 
            this.dtm_start.CalendarForeColor = System.Drawing.Color.Black;
            this.dtm_start.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_start.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtm_start.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_start.Location = new System.Drawing.Point(432, 22);
            this.dtm_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(134, 27);
            this.dtm_start.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(954, 516);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txt_profitLoss);
            this.panel2.Controls.Add(this.txt_salesAmount);
            this.panel2.Controls.Add(this.txt_totalExpense);
            this.panel2.Controls.Add(this.txt_purchaseAmount);
            this.panel2.Controls.Add(this.txt_totalPurchase);
            this.panel2.Controls.Add(this.txt_totalSales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 615);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 45);
            this.panel2.TabIndex = 2;
            // 
            // txt_profitLoss
            // 
            this.txt_profitLoss.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_profitLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_profitLoss.Location = new System.Drawing.Point(740, 11);
            this.txt_profitLoss.Name = "txt_profitLoss";
            this.txt_profitLoss.Size = new System.Drawing.Size(200, 25);
            this.txt_profitLoss.TabIndex = 8;
            // 
            // txt_salesAmount
            // 
            this.txt_salesAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salesAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_salesAmount.Location = new System.Drawing.Point(620, 11);
            this.txt_salesAmount.Name = "txt_salesAmount";
            this.txt_salesAmount.Size = new System.Drawing.Size(115, 25);
            this.txt_salesAmount.TabIndex = 7;
            // 
            // txt_totalExpense
            // 
            this.txt_totalExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalExpense.Location = new System.Drawing.Point(380, 11);
            this.txt_totalExpense.Name = "txt_totalExpense";
            this.txt_totalExpense.Size = new System.Drawing.Size(115, 25);
            this.txt_totalExpense.TabIndex = 6;
            // 
            // txt_purchaseAmount
            // 
            this.txt_purchaseAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchaseAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_purchaseAmount.Location = new System.Drawing.Point(260, 11);
            this.txt_purchaseAmount.Name = "txt_purchaseAmount";
            this.txt_purchaseAmount.Size = new System.Drawing.Size(115, 25);
            this.txt_purchaseAmount.TabIndex = 5;
            // 
            // txt_totalPurchase
            // 
            this.txt_totalPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalPurchase.Location = new System.Drawing.Point(140, 11);
            this.txt_totalPurchase.Name = "txt_totalPurchase";
            this.txt_totalPurchase.Size = new System.Drawing.Size(115, 25);
            this.txt_totalPurchase.TabIndex = 4;
            // 
            // txt_totalSales
            // 
            this.txt_totalSales.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalSales.Location = new System.Drawing.Point(500, 11);
            this.txt_totalSales.Name = "txt_totalSales";
            this.txt_totalSales.Size = new System.Drawing.Size(115, 25);
            this.txt_totalSales.TabIndex = 3;
            // 
            // ProfitLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProfitLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProfitLoss";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_totalSales;
        private System.Windows.Forms.TextBox txt_purchaseAmount;
        private System.Windows.Forms.TextBox txt_totalPurchase;
        private System.Windows.Forms.TextBox txt_profitLoss;
        private System.Windows.Forms.TextBox txt_salesAmount;
        private System.Windows.Forms.TextBox txt_totalExpense;
    }
}