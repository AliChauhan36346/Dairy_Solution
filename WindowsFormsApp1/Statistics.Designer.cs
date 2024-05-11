namespace WindowsFormsApp1
{
    partial class Statistics
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_avgSaleRate = new System.Windows.Forms.Label();
            this.lbl_avgPurchaseRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_avgPurchaseVolume = new System.Windows.Forms.Label();
            this.lbl_avgSalesVolume = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.avg_chilarLoss = new System.Windows.Forms.Label();
            this.avg_tsLoss = new System.Windows.Forms.Label();
            this.avg_dodhiLoss = new System.Windows.Forms.Label();
            this.lbl_avgSRate = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_custCount = new System.Windows.Forms.Label();
            this.lbl_activeCustCount = new System.Windows.Forms.Label();
            this.cmbo_dodhi = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 55);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(57, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "AVERAGE TS SALES RATE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(120, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "AVERAGES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(46, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "AVERAGE PURCHASE RATE:";
            // 
            // lbl_avgSaleRate
            // 
            this.lbl_avgSaleRate.AutoSize = true;
            this.lbl_avgSaleRate.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgSaleRate.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_avgSaleRate.Location = new System.Drawing.Point(259, 196);
            this.lbl_avgSaleRate.Name = "lbl_avgSaleRate";
            this.lbl_avgSaleRate.Size = new System.Drawing.Size(42, 20);
            this.lbl_avgSaleRate.TabIndex = 5;
            this.lbl_avgSaleRate.Text = "AVG";
            // 
            // lbl_avgPurchaseRate
            // 
            this.lbl_avgPurchaseRate.AutoSize = true;
            this.lbl_avgPurchaseRate.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgPurchaseRate.ForeColor = System.Drawing.Color.Teal;
            this.lbl_avgPurchaseRate.Location = new System.Drawing.Point(259, 224);
            this.lbl_avgPurchaseRate.Name = "lbl_avgPurchaseRate";
            this.lbl_avgPurchaseRate.Size = new System.Drawing.Size(42, 20);
            this.lbl_avgPurchaseRate.TabIndex = 6;
            this.lbl_avgPurchaseRate.Text = "AVG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(21, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "AVERAGE PURCHASE VOLUME:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(56, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "AVERAGE SALES VOLUME:";
            // 
            // lbl_avgPurchaseVolume
            // 
            this.lbl_avgPurchaseVolume.AutoSize = true;
            this.lbl_avgPurchaseVolume.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgPurchaseVolume.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_avgPurchaseVolume.Location = new System.Drawing.Point(259, 299);
            this.lbl_avgPurchaseVolume.Name = "lbl_avgPurchaseVolume";
            this.lbl_avgPurchaseVolume.Size = new System.Drawing.Size(42, 20);
            this.lbl_avgPurchaseVolume.TabIndex = 10;
            this.lbl_avgPurchaseVolume.Text = "AVG";
            // 
            // lbl_avgSalesVolume
            // 
            this.lbl_avgSalesVolume.AutoSize = true;
            this.lbl_avgSalesVolume.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgSalesVolume.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_avgSalesVolume.Location = new System.Drawing.Point(259, 272);
            this.lbl_avgSalesVolume.Name = "lbl_avgSalesVolume";
            this.lbl_avgSalesVolume.Size = new System.Drawing.Size(42, 20);
            this.lbl_avgSalesVolume.TabIndex = 9;
            this.lbl_avgSalesVolume.Text = "AVG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(73, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "AVERAGE CHILAR LOSS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(109, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "AVERAGE TS LOSS:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label15.Location = new System.Drawing.Point(78, 408);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "AVERAGE DODHI LOSS:";
            // 
            // avg_chilarLoss
            // 
            this.avg_chilarLoss.AutoSize = true;
            this.avg_chilarLoss.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_chilarLoss.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.avg_chilarLoss.Location = new System.Drawing.Point(259, 380);
            this.avg_chilarLoss.Name = "avg_chilarLoss";
            this.avg_chilarLoss.Size = new System.Drawing.Size(42, 20);
            this.avg_chilarLoss.TabIndex = 18;
            this.avg_chilarLoss.Text = "AVG";
            // 
            // avg_tsLoss
            // 
            this.avg_tsLoss.AutoSize = true;
            this.avg_tsLoss.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_tsLoss.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.avg_tsLoss.Location = new System.Drawing.Point(259, 353);
            this.avg_tsLoss.Name = "avg_tsLoss";
            this.avg_tsLoss.Size = new System.Drawing.Size(42, 20);
            this.avg_tsLoss.TabIndex = 17;
            this.avg_tsLoss.Text = "AVG";
            // 
            // avg_dodhiLoss
            // 
            this.avg_dodhiLoss.AutoSize = true;
            this.avg_dodhiLoss.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_dodhiLoss.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.avg_dodhiLoss.Location = new System.Drawing.Point(259, 408);
            this.avg_dodhiLoss.Name = "avg_dodhiLoss";
            this.avg_dodhiLoss.Size = new System.Drawing.Size(42, 20);
            this.avg_dodhiLoss.TabIndex = 19;
            this.avg_dodhiLoss.Text = "AVG";
            // 
            // lbl_avgSRate
            // 
            this.lbl_avgSRate.AutoSize = true;
            this.lbl_avgSRate.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgSRate.ForeColor = System.Drawing.Color.Teal;
            this.lbl_avgSRate.Location = new System.Drawing.Point(259, 168);
            this.lbl_avgSRate.Name = "lbl_avgSRate";
            this.lbl_avgSRate.Size = new System.Drawing.Size(42, 20);
            this.lbl_avgSRate.TabIndex = 21;
            this.lbl_avgSRate.Text = "AVG";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Teal;
            this.label20.Location = new System.Drawing.Point(80, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "AVERAGE SALES RATE:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(568, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 30);
            this.label21.TabIndex = 22;
            this.label21.Text = "TOTALS";
            // 
            // lbl_custCount
            // 
            this.lbl_custCount.AutoSize = true;
            this.lbl_custCount.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custCount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_custCount.Location = new System.Drawing.Point(504, 120);
            this.lbl_custCount.Name = "lbl_custCount";
            this.lbl_custCount.Size = new System.Drawing.Size(217, 20);
            this.lbl_custCount.TabIndex = 23;
            this.lbl_custCount.Text = "TOTAL CUSTOMERS COUNT:";
            // 
            // lbl_activeCustCount
            // 
            this.lbl_activeCustCount.AutoSize = true;
            this.lbl_activeCustCount.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activeCustCount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_activeCustCount.Location = new System.Drawing.Point(446, 147);
            this.lbl_activeCustCount.Name = "lbl_activeCustCount";
            this.lbl_activeCustCount.Size = new System.Drawing.Size(275, 20);
            this.lbl_activeCustCount.TabIndex = 24;
            this.lbl_activeCustCount.Text = "TOTAL ACTIVE CUSTOMERS COUNT:";
            // 
            // cmbo_dodhi
            // 
            this.cmbo_dodhi.FormattingEnabled = true;
            this.cmbo_dodhi.Location = new System.Drawing.Point(389, 196);
            this.cmbo_dodhi.Name = "cmbo_dodhi";
            this.cmbo_dodhi.Size = new System.Drawing.Size(200, 25);
            this.cmbo_dodhi.TabIndex = 31;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Green;
            this.label28.Location = new System.Drawing.Point(595, 197);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 20);
            this.label28.TabIndex = 32;
            this.label28.Text = "Customers count:";
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(187, 120);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(113, 27);
            this.dtm_end.TabIndex = 35;
            this.dtm_end.ValueChanged += new System.EventHandler(this.dtm_end_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(154, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "to";
            // 
            // dtm_start
            // 
            this.dtm_start.CalendarForeColor = System.Drawing.Color.Black;
            this.dtm_start.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_start.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtm_start.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_start.Location = new System.Drawing.Point(25, 120);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(115, 27);
            this.dtm_start.TabIndex = 34;
            this.dtm_start.ValueChanged += new System.EventHandler(this.dtm_start_ValueChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 588);
            this.Controls.Add(this.dtm_end);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtm_start);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cmbo_dodhi);
            this.Controls.Add(this.lbl_activeCustCount);
            this.Controls.Add(this.lbl_custCount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbl_avgSRate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.avg_dodhiLoss);
            this.Controls.Add(this.avg_chilarLoss);
            this.Controls.Add(this.avg_tsLoss);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_avgPurchaseVolume);
            this.Controls.Add(this.lbl_avgSalesVolume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_avgPurchaseRate);
            this.Controls.Add(this.lbl_avgSaleRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_avgSaleRate;
        private System.Windows.Forms.Label lbl_avgPurchaseRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_avgPurchaseVolume;
        private System.Windows.Forms.Label lbl_avgSalesVolume;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label avg_chilarLoss;
        private System.Windows.Forms.Label avg_tsLoss;
        private System.Windows.Forms.Label avg_dodhiLoss;
        private System.Windows.Forms.Label lbl_avgSRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_custCount;
        private System.Windows.Forms.Label lbl_activeCustCount;
        private System.Windows.Forms.ComboBox cmbo_dodhi;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtm_start;
    }
}