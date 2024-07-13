namespace WindowsFormsApp1
{
    partial class Roznamcha
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
            this.btn_saleReport = new System.Windows.Forms.Button();
            this.btn_purchaseReport = new System.Windows.Forms.Button();
            this.btn_roznamcha = new System.Windows.Forms.Button();
            this.chk_Morning = new System.Windows.Forms.CheckBox();
            this.chkEvening = new System.Windows.Forms.CheckBox();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totalVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tsDifference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_volumeDifference = new System.Windows.Forms.TextBox();
            this.txt_tsSale = new System.Windows.Forms.TextBox();
            this.txt_sale = new System.Windows.Forms.TextBox();
            this.txt_evening = new System.Windows.Forms.TextBox();
            this.txt_morning = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_saleReport);
            this.panel1.Controls.Add(this.btn_purchaseReport);
            this.panel1.Controls.Add(this.btn_roznamcha);
            this.panel1.Controls.Add(this.chk_Morning);
            this.panel1.Controls.Add(this.chkEvening);
            this.panel1.Controls.Add(this.dtm_end);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 85);
            this.panel1.TabIndex = 0;
            // 
            // btn_saleReport
            // 
            this.btn_saleReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleReport.Location = new System.Drawing.Point(744, 39);
            this.btn_saleReport.Margin = new System.Windows.Forms.Padding(5);
            this.btn_saleReport.Name = "btn_saleReport";
            this.btn_saleReport.Size = new System.Drawing.Size(114, 35);
            this.btn_saleReport.TabIndex = 31;
            this.btn_saleReport.Text = "Chilar Receive";
            this.btn_saleReport.UseVisualStyleBackColor = true;
            this.btn_saleReport.Click += new System.EventHandler(this.btn_saleReport_Click);
            // 
            // btn_purchaseReport
            // 
            this.btn_purchaseReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchaseReport.Location = new System.Drawing.Point(744, 4);
            this.btn_purchaseReport.Margin = new System.Windows.Forms.Padding(5);
            this.btn_purchaseReport.Name = "btn_purchaseReport";
            this.btn_purchaseReport.Size = new System.Drawing.Size(114, 35);
            this.btn_purchaseReport.TabIndex = 30;
            this.btn_purchaseReport.Text = "Receive Report";
            this.btn_purchaseReport.UseVisualStyleBackColor = true;
            this.btn_purchaseReport.Click += new System.EventHandler(this.btn_purchaseReport_Click);
            // 
            // btn_roznamcha
            // 
            this.btn_roznamcha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roznamcha.Location = new System.Drawing.Point(634, 4);
            this.btn_roznamcha.Name = "btn_roznamcha";
            this.btn_roznamcha.Size = new System.Drawing.Size(98, 70);
            this.btn_roznamcha.TabIndex = 17;
            this.btn_roznamcha.Text = "Display\r\nRoznamcha";
            this.btn_roznamcha.UseVisualStyleBackColor = true;
            this.btn_roznamcha.Click += new System.EventHandler(this.btn_roznamcha_Click);
            // 
            // chk_Morning
            // 
            this.chk_Morning.AutoSize = true;
            this.chk_Morning.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Morning.ForeColor = System.Drawing.Color.Green;
            this.chk_Morning.Location = new System.Drawing.Point(507, 46);
            this.chk_Morning.Name = "chk_Morning";
            this.chk_Morning.Size = new System.Drawing.Size(92, 25);
            this.chk_Morning.TabIndex = 16;
            this.chk_Morning.Text = "Morning";
            this.chk_Morning.UseVisualStyleBackColor = true;
            // 
            // chkEvening
            // 
            this.chkEvening.AutoSize = true;
            this.chkEvening.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkEvening.Location = new System.Drawing.Point(343, 46);
            this.chkEvening.Name = "chkEvening";
            this.chkEvening.Size = new System.Drawing.Size(88, 25);
            this.chkEvening.TabIndex = 15;
            this.chkEvening.Text = "Evening";
            this.chkEvening.UseVisualStyleBackColor = true;
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(507, 9);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(113, 27);
            this.dtm_end.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(470, 12);
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
            this.dtm_start.Location = new System.Drawing.Point(343, 9);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(115, 27);
            this.dtm_start.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roznamcha Chilar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(967, 478);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_totalVolume);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_tsDifference);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_volumeDifference);
            this.panel2.Controls.Add(this.txt_tsSale);
            this.panel2.Controls.Add(this.txt_sale);
            this.panel2.Controls.Add(this.txt_evening);
            this.panel2.Controls.Add(this.txt_morning);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 597);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 90);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(462, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Volume";
            // 
            // txt_totalVolume
            // 
            this.txt_totalVolume.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalVolume.ForeColor = System.Drawing.Color.Green;
            this.txt_totalVolume.Location = new System.Drawing.Point(574, 51);
            this.txt_totalVolume.Name = "txt_totalVolume";
            this.txt_totalVolume.Size = new System.Drawing.Size(116, 25);
            this.txt_totalVolume.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(715, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ts Difference";
            // 
            // txt_tsDifference
            // 
            this.txt_tsDifference.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsDifference.ForeColor = System.Drawing.Color.Red;
            this.txt_tsDifference.Location = new System.Drawing.Point(824, 53);
            this.txt_tsDifference.Name = "txt_tsDifference";
            this.txt_tsDifference.Size = new System.Drawing.Size(116, 25);
            this.txt_tsDifference.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Difference Volume";
            // 
            // txt_volumeDifference
            // 
            this.txt_volumeDifference.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_volumeDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_volumeDifference.Location = new System.Drawing.Point(158, 15);
            this.txt_volumeDifference.Name = "txt_volumeDifference";
            this.txt_volumeDifference.Size = new System.Drawing.Size(64, 25);
            this.txt_volumeDifference.TabIndex = 6;
            // 
            // txt_tsSale
            // 
            this.txt_tsSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tsSale.Location = new System.Drawing.Point(824, 13);
            this.txt_tsSale.Name = "txt_tsSale";
            this.txt_tsSale.Size = new System.Drawing.Size(116, 25);
            this.txt_tsSale.TabIndex = 3;
            // 
            // txt_sale
            // 
            this.txt_sale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sale.Location = new System.Drawing.Point(700, 13);
            this.txt_sale.Name = "txt_sale";
            this.txt_sale.Size = new System.Drawing.Size(116, 25);
            this.txt_sale.TabIndex = 2;
            // 
            // txt_evening
            // 
            this.txt_evening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_evening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_evening.Location = new System.Drawing.Point(575, 13);
            this.txt_evening.Name = "txt_evening";
            this.txt_evening.Size = new System.Drawing.Size(116, 25);
            this.txt_evening.TabIndex = 1;
            // 
            // txt_morning
            // 
            this.txt_morning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_morning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_morning.Location = new System.Drawing.Point(450, 13);
            this.txt_morning.Name = "txt_morning";
            this.txt_morning.Size = new System.Drawing.Size(116, 25);
            this.txt_morning.TabIndex = 0;
            // 
            // Roznamcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Roznamcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Roznamcha";
            this.Load += new System.EventHandler(this.Roznamcha_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.TextBox txt_tsSale;
        private System.Windows.Forms.TextBox txt_sale;
        private System.Windows.Forms.TextBox txt_evening;
        private System.Windows.Forms.TextBox txt_morning;
        private System.Windows.Forms.CheckBox chkEvening;
        private System.Windows.Forms.CheckBox chk_Morning;
        private System.Windows.Forms.Button btn_roznamcha;
        private System.Windows.Forms.Button btn_saleReport;
        private System.Windows.Forms.Button btn_purchaseReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_volumeDifference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tsDifference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalVolume;
    }
}