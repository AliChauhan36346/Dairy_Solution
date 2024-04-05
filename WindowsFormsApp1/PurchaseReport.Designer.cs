namespace WindowsFormsApp1
{
    partial class PurchaseReport
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
            this.txt_totalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_avgPurchaseRate = new System.Windows.Forms.Label();
            this.lbl_avgSalesRate = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_time = new System.Windows.Forms.CheckBox();
            this.cmbo_time = new System.Windows.Forms.ComboBox();
            this.chk_dodhi = new System.Windows.Forms.CheckBox();
            this.cmbo_dodhi = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalAmount.Location = new System.Drawing.Point(958, 6);
            this.txt_totalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.Size = new System.Drawing.Size(116, 25);
            this.txt_totalAmount.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(825, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Average Purchase Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(853, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Average Sales Rate:";
            // 
            // lbl_avgPurchaseRate
            // 
            this.lbl_avgPurchaseRate.AutoSize = true;
            this.lbl_avgPurchaseRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgPurchaseRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_avgPurchaseRate.Location = new System.Drawing.Point(1000, 110);
            this.lbl_avgPurchaseRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_avgPurchaseRate.Name = "lbl_avgPurchaseRate";
            this.lbl_avgPurchaseRate.Size = new System.Drawing.Size(51, 20);
            this.lbl_avgPurchaseRate.TabIndex = 17;
            this.lbl_avgPurchaseRate.Text = "label5";
            // 
            // lbl_avgSalesRate
            // 
            this.lbl_avgSalesRate.AutoSize = true;
            this.lbl_avgSalesRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgSalesRate.ForeColor = System.Drawing.Color.Green;
            this.lbl_avgSalesRate.Location = new System.Drawing.Point(1000, 80);
            this.lbl_avgSalesRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_avgSalesRate.Name = "lbl_avgSalesRate";
            this.lbl_avgSalesRate.Size = new System.Drawing.Size(51, 20);
            this.lbl_avgSalesRate.TabIndex = 16;
            this.lbl_avgSalesRate.Text = "label4";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(730, 34);
            this.Print.Margin = new System.Windows.Forms.Padding(5);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(80, 52);
            this.Print.TabIndex = 15;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(649, 34);
            this.btn_display.Margin = new System.Windows.Forms.Padding(5);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(80, 52);
            this.btn_display.TabIndex = 14;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(528, 111);
            this.dtm_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(100, 25);
            this.dtm_end.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(766, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Totals";
            // 
            // txt_Volume
            // 
            this.txt_Volume.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Volume.Location = new System.Drawing.Point(828, 6);
            this.txt_Volume.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(116, 25);
            this.txt_Volume.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Volume);
            this.panel2.Controls.Add(this.txt_totalAmount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 38);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(494, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.dtm_start.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_start.Location = new System.Drawing.Point(384, 111);
            this.dtm_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(100, 25);
            this.dtm_start.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Report";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 167);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1084, 468);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chk_time);
            this.panel1.Controls.Add(this.cmbo_time);
            this.panel1.Controls.Add(this.chk_dodhi);
            this.panel1.Controls.Add(this.cmbo_dodhi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_avgPurchaseRate);
            this.panel1.Controls.Add(this.lbl_avgSalesRate);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.btn_display);
            this.panel1.Controls.Add(this.dtm_end);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 148);
            this.panel1.TabIndex = 17;
            // 
            // chk_time
            // 
            this.chk_time.AutoSize = true;
            this.chk_time.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk_time.Location = new System.Drawing.Point(320, 40);
            this.chk_time.Margin = new System.Windows.Forms.Padding(4);
            this.chk_time.Name = "chk_time";
            this.chk_time.Size = new System.Drawing.Size(56, 21);
            this.chk_time.TabIndex = 25;
            this.chk_time.Text = "Time";
            this.chk_time.UseVisualStyleBackColor = true;
            this.chk_time.CheckedChanged += new System.EventHandler(this.chk_time_CheckedChanged);
            // 
            // cmbo_time
            // 
            this.cmbo_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_time.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_time.FormattingEnabled = true;
            this.cmbo_time.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.cmbo_time.Location = new System.Drawing.Point(384, 38);
            this.cmbo_time.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_time.Name = "cmbo_time";
            this.cmbo_time.Size = new System.Drawing.Size(244, 25);
            this.cmbo_time.TabIndex = 24;
            // 
            // chk_dodhi
            // 
            this.chk_dodhi.AutoSize = true;
            this.chk_dodhi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_dodhi.ForeColor = System.Drawing.Color.Green;
            this.chk_dodhi.Location = new System.Drawing.Point(313, 77);
            this.chk_dodhi.Margin = new System.Windows.Forms.Padding(4);
            this.chk_dodhi.Name = "chk_dodhi";
            this.chk_dodhi.Size = new System.Drawing.Size(63, 21);
            this.chk_dodhi.TabIndex = 21;
            this.chk_dodhi.Text = "Dodhi";
            this.chk_dodhi.UseVisualStyleBackColor = true;
            this.chk_dodhi.CheckedChanged += new System.EventHandler(this.chk_dodhi_CheckedChanged);
            // 
            // cmbo_dodhi
            // 
            this.cmbo_dodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_dodhi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_dodhi.FormattingEnabled = true;
            this.cmbo_dodhi.Location = new System.Drawing.Point(384, 75);
            this.cmbo_dodhi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_dodhi.Name = "cmbo_dodhi";
            this.cmbo_dodhi.Size = new System.Drawing.Size(244, 25);
            this.cmbo_dodhi.TabIndex = 20;
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PurchaseReport";
            this.Load += new System.EventHandler(this.PurchaseReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_totalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_avgPurchaseRate;
        private System.Windows.Forms.Label lbl_avgSalesRate;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_dodhi;
        private System.Windows.Forms.ComboBox cmbo_dodhi;
        private System.Windows.Forms.CheckBox chk_time;
        private System.Windows.Forms.ComboBox cmbo_time;
    }
}