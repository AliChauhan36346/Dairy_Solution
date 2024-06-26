namespace WindowsFormsApp1
{
    partial class Dodhi_change
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updateDodhi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbo_newDodhi = new System.Windows.Forms.ComboBox();
            this.cmbo_currentDodhi = new System.Windows.Forms.ComboBox();
            this.chk_changeDodhiAll = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(403, 116);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(364, 361);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Customers Dodhi";
            // 
            // btn_updateDodhi
            // 
            this.btn_updateDodhi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDodhi.Location = new System.Drawing.Point(270, 215);
            this.btn_updateDodhi.Name = "btn_updateDodhi";
            this.btn_updateDodhi.Size = new System.Drawing.Size(108, 47);
            this.btn_updateDodhi.TabIndex = 19;
            this.btn_updateDodhi.Text = "Update Dodhi";
            this.btn_updateDodhi.UseVisualStyleBackColor = true;
            this.btn_updateDodhi.Click += new System.EventHandler(this.btn_updateDodhi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(37, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "New Dodhi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Current Dodhi";
            // 
            // cmbo_newDodhi
            // 
            this.cmbo_newDodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_newDodhi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_newDodhi.FormattingEnabled = true;
            this.cmbo_newDodhi.Location = new System.Drawing.Point(127, 171);
            this.cmbo_newDodhi.Name = "cmbo_newDodhi";
            this.cmbo_newDodhi.Size = new System.Drawing.Size(251, 28);
            this.cmbo_newDodhi.TabIndex = 16;
            // 
            // cmbo_currentDodhi
            // 
            this.cmbo_currentDodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_currentDodhi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_currentDodhi.FormattingEnabled = true;
            this.cmbo_currentDodhi.Location = new System.Drawing.Point(127, 116);
            this.cmbo_currentDodhi.Name = "cmbo_currentDodhi";
            this.cmbo_currentDodhi.Size = new System.Drawing.Size(251, 28);
            this.cmbo_currentDodhi.TabIndex = 15;
            this.cmbo_currentDodhi.SelectedIndexChanged += new System.EventHandler(this.cmbo_currentDodhi_SelectedIndexChanged);
            // 
            // chk_changeDodhiAll
            // 
            this.chk_changeDodhiAll.AutoSize = true;
            this.chk_changeDodhiAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_changeDodhiAll.ForeColor = System.Drawing.Color.Blue;
            this.chk_changeDodhiAll.Location = new System.Drawing.Point(19, 388);
            this.chk_changeDodhiAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_changeDodhiAll.Name = "chk_changeDodhiAll";
            this.chk_changeDodhiAll.Size = new System.Drawing.Size(107, 24);
            this.chk_changeDodhiAll.TabIndex = 20;
            this.chk_changeDodhiAll.Text = "Change All";
            this.chk_changeDodhiAll.UseVisualStyleBackColor = true;
            this.chk_changeDodhiAll.CheckedChanged += new System.EventHandler(this.chk_changeDodhiAll_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selecting this checkbox will allow you to update dodhi\r\nof all customers displaye" +
    "d above";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(492, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 25);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Search here";
            // 
            // Dodhi_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_changeDodhiAll);
            this.Controls.Add(this.btn_updateDodhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_newDodhi);
            this.Controls.Add(this.cmbo_currentDodhi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Dodhi_change";
            this.Text = "Dodhi_change";
            this.Load += new System.EventHandler(this.Dodhi_change_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_updateDodhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbo_newDodhi;
        private System.Windows.Forms.ComboBox cmbo_currentDodhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_changeDodhiAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}