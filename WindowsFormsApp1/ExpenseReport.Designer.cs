namespace WindowsFormsApp1
{
    partial class ExpenseReport
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
            this.Compare = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.chk_filter = new System.Windows.Forms.CheckBox();
            this.cmbo_type = new System.Windows.Forms.ComboBox();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_totalAmount = new System.Windows.Forms.TextBox();
            this.Compare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Compare
            // 
            this.Compare.BackColor = System.Drawing.Color.Silver;
            this.Compare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Compare.Controls.Add(this.button2);
            this.Compare.Controls.Add(this.btn_display);
            this.Compare.Controls.Add(this.chk_filter);
            this.Compare.Controls.Add(this.cmbo_type);
            this.Compare.Controls.Add(this.dtm_end);
            this.Compare.Controls.Add(this.label2);
            this.Compare.Controls.Add(this.dtm_start);
            this.Compare.Controls.Add(this.label1);
            this.Compare.Dock = System.Windows.Forms.DockStyle.Top;
            this.Compare.Location = new System.Drawing.Point(0, 0);
            this.Compare.Margin = new System.Windows.Forms.Padding(4);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(933, 110);
            this.Compare.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Compare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(668, 21);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 40);
            this.btn_display.TabIndex = 17;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // chk_filter
            // 
            this.chk_filter.AutoSize = true;
            this.chk_filter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_filter.ForeColor = System.Drawing.Color.Green;
            this.chk_filter.Location = new System.Drawing.Point(281, 23);
            this.chk_filter.Name = "chk_filter";
            this.chk_filter.Size = new System.Drawing.Size(63, 24);
            this.chk_filter.TabIndex = 16;
            this.chk_filter.Text = "Filter";
            this.chk_filter.UseVisualStyleBackColor = true;
            // 
            // cmbo_type
            // 
            this.cmbo_type.FormattingEnabled = true;
            this.cmbo_type.Items.AddRange(new object[] {
            "Electricity",
            "Labour",
            "Vehical Repairing",
            "Petrol",
            "Chilar Repairing",
            "Other"});
            this.cmbo_type.Location = new System.Drawing.Point(387, 23);
            this.cmbo_type.Name = "cmbo_type";
            this.cmbo_type.Size = new System.Drawing.Size(275, 25);
            this.cmbo_type.TabIndex = 15;
            // 
            // dtm_end
            // 
            this.dtm_end.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_end.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(549, 61);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(113, 27);
            this.dtm_end.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 64);
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
            this.dtm_start.Location = new System.Drawing.Point(387, 61);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(115, 27);
            this.dtm_start.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 460);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.txt_totalAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 43);
            this.panel1.TabIndex = 2;
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalAmount.Location = new System.Drawing.Point(825, 10);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.Size = new System.Drawing.Size(100, 27);
            this.txt_totalAmount.TabIndex = 0;
            // 
            // ExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Compare);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpenseReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExpenseReport";
            this.Compare.ResumeLayout(false);
            this.Compare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Compare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbo_type;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.CheckBox chk_filter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_totalAmount;
    }
}