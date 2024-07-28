namespace WindowsFormsApp1
{
    partial class DailyBasisChilarReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saleReport = new System.Windows.Forms.Button();
            this.btn_purchaseReport = new System.Windows.Forms.Button();
            this.btn_roznamcha = new System.Windows.Forms.Button();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_totalSale = new System.Windows.Forms.TextBox();
            this.txt_totalReceive = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_saleReport);
            this.panel1.Controls.Add(this.btn_purchaseReport);
            this.panel1.Controls.Add(this.btn_roznamcha);
            this.panel1.Controls.Add(this.dtm_end);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 85);
            this.panel1.TabIndex = 1;
            // 
            // btn_saleReport
            // 
            this.btn_saleReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_saleReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleReport.Location = new System.Drawing.Point(768, 39);
            this.btn_saleReport.Margin = new System.Windows.Forms.Padding(5);
            this.btn_saleReport.Name = "btn_saleReport";
            this.btn_saleReport.Size = new System.Drawing.Size(125, 35);
            this.btn_saleReport.TabIndex = 31;
            this.btn_saleReport.Text = "Chilar Receive";
            this.btn_saleReport.UseVisualStyleBackColor = false;
            // 
            // btn_purchaseReport
            // 
            this.btn_purchaseReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_purchaseReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchaseReport.Location = new System.Drawing.Point(768, 4);
            this.btn_purchaseReport.Margin = new System.Windows.Forms.Padding(5);
            this.btn_purchaseReport.Name = "btn_purchaseReport";
            this.btn_purchaseReport.Size = new System.Drawing.Size(125, 35);
            this.btn_purchaseReport.TabIndex = 30;
            this.btn_purchaseReport.Text = "Roznamcha Chilar";
            this.btn_purchaseReport.UseVisualStyleBackColor = false;
            // 
            // btn_roznamcha
            // 
            this.btn_roznamcha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_roznamcha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roznamcha.Location = new System.Drawing.Point(658, 4);
            this.btn_roznamcha.Name = "btn_roznamcha";
            this.btn_roznamcha.Size = new System.Drawing.Size(98, 70);
            this.btn_roznamcha.TabIndex = 17;
            this.btn_roznamcha.Text = "Display\r\nReport";
            this.btn_roznamcha.UseVisualStyleBackColor = false;
            this.btn_roznamcha.Click += new System.EventHandler(this.btn_roznamcha_Click);
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(531, 9);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(113, 27);
            this.dtm_end.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(494, 12);
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
            this.dtm_start.Location = new System.Drawing.Point(367, 9);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(110, 27);
            this.dtm_start.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Basis Chilar Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_balance);
            this.panel2.Controls.Add(this.txt_totalSale);
            this.panel2.Controls.Add(this.txt_totalReceive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 41);
            this.panel2.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(69, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Totals";
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_balance.Location = new System.Drawing.Point(505, 7);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(155, 25);
            this.txt_balance.TabIndex = 3;
            // 
            // txt_totalSale
            // 
            this.txt_totalSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalSale.Location = new System.Drawing.Point(266, 8);
            this.txt_totalSale.Name = "txt_totalSale";
            this.txt_totalSale.Size = new System.Drawing.Size(126, 25);
            this.txt_totalSale.TabIndex = 1;
            // 
            // txt_totalReceive
            // 
            this.txt_totalReceive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalReceive.Location = new System.Drawing.Point(135, 8);
            this.txt_totalReceive.Name = "txt_totalReceive";
            this.txt_totalReceive.Size = new System.Drawing.Size(126, 25);
            this.txt_totalReceive.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 459);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DailyBasisChilarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DailyBasisChilarReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DailyBasisChilarReport";
            this.Load += new System.EventHandler(this.DailyBasisChilarReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saleReport;
        private System.Windows.Forms.Button btn_purchaseReport;
        private System.Windows.Forms.Button btn_roznamcha;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_totalSale;
        private System.Windows.Forms.TextBox txt_totalReceive;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}