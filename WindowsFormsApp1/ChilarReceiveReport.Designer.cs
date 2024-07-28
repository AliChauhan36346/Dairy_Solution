namespace WindowsFormsApp1
{
    partial class ChilarReceiveReport
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
            this.chk_time = new System.Windows.Forms.CheckBox();
            this.cmbo_time = new System.Windows.Forms.ComboBox();
            this.cmbo_dodhi = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saleReport = new System.Windows.Forms.Button();
            this.btn_purchaseReport = new System.Windows.Forms.Button();
            this.btn_roznamcha = new System.Windows.Forms.Button();
            this.btn_ChilarReceive = new System.Windows.Forms.Button();
            this.chk_dodhi = new System.Windows.Forms.CheckBox();
            this.Print = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_totalPurchased = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalReive = new System.Windows.Forms.TextBox();
            this.txt_lossAndStatus = new System.Windows.Forms.TextBox();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.txt_tsVolume = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_time
            // 
            this.chk_time.AutoSize = true;
            this.chk_time.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk_time.Location = new System.Drawing.Point(320, 20);
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
            this.cmbo_time.Location = new System.Drawing.Point(384, 18);
            this.cmbo_time.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_time.Name = "cmbo_time";
            this.cmbo_time.Size = new System.Drawing.Size(244, 25);
            this.cmbo_time.TabIndex = 24;
            // 
            // cmbo_dodhi
            // 
            this.cmbo_dodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_dodhi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_dodhi.FormattingEnabled = true;
            this.cmbo_dodhi.Location = new System.Drawing.Point(384, 55);
            this.cmbo_dodhi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_dodhi.Name = "cmbo_dodhi";
            this.cmbo_dodhi.Size = new System.Drawing.Size(244, 25);
            this.cmbo_dodhi.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 179);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(666, 456);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_saleReport);
            this.panel1.Controls.Add(this.btn_purchaseReport);
            this.panel1.Controls.Add(this.btn_roznamcha);
            this.panel1.Controls.Add(this.btn_ChilarReceive);
            this.panel1.Controls.Add(this.chk_time);
            this.panel1.Controls.Add(this.cmbo_time);
            this.panel1.Controls.Add(this.chk_dodhi);
            this.panel1.Controls.Add(this.cmbo_dodhi);
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
            this.panel1.Size = new System.Drawing.Size(1213, 130);
            this.panel1.TabIndex = 20;
            // 
            // btn_saleReport
            // 
            this.btn_saleReport.BackColor = System.Drawing.Color.White;
            this.btn_saleReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleReport.Location = new System.Drawing.Point(837, 68);
            this.btn_saleReport.Margin = new System.Windows.Forms.Padding(5);
            this.btn_saleReport.Name = "btn_saleReport";
            this.btn_saleReport.Size = new System.Drawing.Size(92, 48);
            this.btn_saleReport.TabIndex = 29;
            this.btn_saleReport.Text = "Sale Report";
            this.btn_saleReport.UseVisualStyleBackColor = false;
            this.btn_saleReport.Click += new System.EventHandler(this.btn_saleReport_Click);
            // 
            // btn_purchaseReport
            // 
            this.btn_purchaseReport.BackColor = System.Drawing.Color.White;
            this.btn_purchaseReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchaseReport.Location = new System.Drawing.Point(837, 17);
            this.btn_purchaseReport.Margin = new System.Windows.Forms.Padding(5);
            this.btn_purchaseReport.Name = "btn_purchaseReport";
            this.btn_purchaseReport.Size = new System.Drawing.Size(92, 48);
            this.btn_purchaseReport.TabIndex = 28;
            this.btn_purchaseReport.Text = "Purchase Report";
            this.btn_purchaseReport.UseVisualStyleBackColor = false;
            this.btn_purchaseReport.Click += new System.EventHandler(this.btn_purchaseReport_Click);
            // 
            // btn_roznamcha
            // 
            this.btn_roznamcha.BackColor = System.Drawing.Color.White;
            this.btn_roznamcha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roznamcha.Location = new System.Drawing.Point(743, 68);
            this.btn_roznamcha.Margin = new System.Windows.Forms.Padding(5);
            this.btn_roznamcha.Name = "btn_roznamcha";
            this.btn_roznamcha.Size = new System.Drawing.Size(92, 48);
            this.btn_roznamcha.TabIndex = 27;
            this.btn_roznamcha.Text = "Roznamcha";
            this.btn_roznamcha.UseVisualStyleBackColor = false;
            this.btn_roznamcha.Click += new System.EventHandler(this.btn_roznamcha_Click);
            // 
            // btn_ChilarReceive
            // 
            this.btn_ChilarReceive.BackColor = System.Drawing.Color.White;
            this.btn_ChilarReceive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChilarReceive.Location = new System.Drawing.Point(743, 17);
            this.btn_ChilarReceive.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ChilarReceive.Name = "btn_ChilarReceive";
            this.btn_ChilarReceive.Size = new System.Drawing.Size(92, 48);
            this.btn_ChilarReceive.TabIndex = 26;
            this.btn_ChilarReceive.Text = "Chilar Receive";
            this.btn_ChilarReceive.UseVisualStyleBackColor = false;
            this.btn_ChilarReceive.Click += new System.EventHandler(this.btn_ChilarReceive_Click);
            // 
            // chk_dodhi
            // 
            this.chk_dodhi.AutoSize = true;
            this.chk_dodhi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_dodhi.ForeColor = System.Drawing.Color.Green;
            this.chk_dodhi.Location = new System.Drawing.Point(313, 57);
            this.chk_dodhi.Margin = new System.Windows.Forms.Padding(4);
            this.chk_dodhi.Name = "chk_dodhi";
            this.chk_dodhi.Size = new System.Drawing.Size(63, 21);
            this.chk_dodhi.TabIndex = 21;
            this.chk_dodhi.Text = "Dodhi";
            this.chk_dodhi.UseVisualStyleBackColor = true;
            this.chk_dodhi.CheckedChanged += new System.EventHandler(this.chk_dodhi_CheckedChanged);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.White;
            this.Print.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(644, 68);
            this.Print.Margin = new System.Windows.Forms.Padding(5);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(77, 48);
            this.Print.TabIndex = 15;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.White;
            this.btn_display.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.Location = new System.Drawing.Point(644, 17);
            this.btn_display.Margin = new System.Windows.Forms.Padding(5);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(77, 48);
            this.btn_display.TabIndex = 14;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(528, 91);
            this.dtm_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(100, 25);
            this.dtm_end.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(494, 93);
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
            this.dtm_start.Location = new System.Drawing.Point(384, 91);
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
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receive Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(320, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Totals";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.txt_totalPurchased);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_totalReive);
            this.panel2.Controls.Add(this.txt_lossAndStatus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Volume);
            this.panel2.Controls.Add(this.txt_tsVolume);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 38);
            this.panel2.TabIndex = 22;
            // 
            // txt_totalPurchased
            // 
            this.txt_totalPurchased.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPurchased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalPurchased.Location = new System.Drawing.Point(893, 6);
            this.txt_totalPurchased.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalPurchased.Name = "txt_totalPurchased";
            this.txt_totalPurchased.Size = new System.Drawing.Size(80, 25);
            this.txt_totalPurchased.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(821, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Totals";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_totalReive
            // 
            this.txt_totalReive.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalReive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalReive.Location = new System.Drawing.Point(979, 6);
            this.txt_totalReive.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalReive.Name = "txt_totalReive";
            this.txt_totalReive.Size = new System.Drawing.Size(80, 25);
            this.txt_totalReive.TabIndex = 5;
            // 
            // txt_lossAndStatus
            // 
            this.txt_lossAndStatus.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lossAndStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lossAndStatus.Location = new System.Drawing.Point(1065, 6);
            this.txt_lossAndStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lossAndStatus.Name = "txt_lossAndStatus";
            this.txt_lossAndStatus.Size = new System.Drawing.Size(140, 25);
            this.txt_lossAndStatus.TabIndex = 4;
            // 
            // txt_Volume
            // 
            this.txt_Volume.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Volume.Location = new System.Drawing.Point(384, 6);
            this.txt_Volume.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(80, 25);
            this.txt_Volume.TabIndex = 2;
            // 
            // txt_tsVolume
            // 
            this.txt_tsVolume.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tsVolume.Location = new System.Drawing.Point(571, 6);
            this.txt_tsVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tsVolume.Name = "txt_tsVolume";
            this.txt_tsVolume.Size = new System.Drawing.Size(90, 25);
            this.txt_tsVolume.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(692, 179);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 456);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(-1, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Chilar Receive Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(690, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Dodhi Loss Report";
            // 
            // ChilarReceiveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 674);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChilarReceiveReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChilarReceiveReport";
            this.Load += new System.EventHandler(this.ChilarReceiveReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_time;
        private System.Windows.Forms.ComboBox cmbo_time;
        private System.Windows.Forms.ComboBox cmbo_dodhi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_dodhi;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.TextBox txt_tsVolume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalReive;
        private System.Windows.Forms.TextBox txt_lossAndStatus;
        private System.Windows.Forms.TextBox txt_totalPurchased;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_saleReport;
        private System.Windows.Forms.Button btn_purchaseReport;
        private System.Windows.Forms.Button btn_roznamcha;
        private System.Windows.Forms.Button btn_ChilarReceive;
    }
}