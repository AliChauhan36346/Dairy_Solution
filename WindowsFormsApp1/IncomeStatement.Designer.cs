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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 56);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(369, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 7);
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
            this.panel2.Location = new System.Drawing.Point(33, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 190);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(249, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "(From start to today)";
            // 
            // dtm_endDate
            // 
            this.dtm_endDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_endDate.Location = new System.Drawing.Point(258, 122);
            this.dtm_endDate.Name = "dtm_endDate";
            this.dtm_endDate.Size = new System.Drawing.Size(120, 27);
            this.dtm_endDate.TabIndex = 9;
            // 
            // dtm_startDate
            // 
            this.dtm_startDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_startDate.Location = new System.Drawing.Point(124, 122);
            this.dtm_startDate.Name = "dtm_startDate";
            this.dtm_startDate.Size = new System.Drawing.Size(118, 27);
            this.dtm_startDate.TabIndex = 8;
            // 
            // dtm_uptoDate
            // 
            this.dtm_uptoDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_uptoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_uptoDate.Location = new System.Drawing.Point(124, 73);
            this.dtm_uptoDate.Name = "dtm_uptoDate";
            this.dtm_uptoDate.Size = new System.Drawing.Size(118, 27);
            this.dtm_uptoDate.TabIndex = 7;
            // 
            // rdo_fromDate
            // 
            this.rdo_fromDate.AutoSize = true;
            this.rdo_fromDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_fromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdo_fromDate.Location = new System.Drawing.Point(16, 122);
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
            this.rdo_uptoDate.Location = new System.Drawing.Point(16, 73);
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
            this.rdo_toDate.Location = new System.Drawing.Point(16, 24);
            this.rdo_toDate.Name = "rdo_toDate";
            this.rdo_toDate.Size = new System.Drawing.Size(83, 24);
            this.rdo_toDate.TabIndex = 4;
            this.rdo_toDate.TabStop = true;
            this.rdo_toDate.Text = "To Date";
            this.rdo_toDate.UseVisualStyleBackColor = true;
            // 
            // IncomeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 316);
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
    }
}