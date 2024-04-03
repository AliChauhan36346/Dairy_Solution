namespace WindowsFormsApp1
{
    partial class Change_Dodhi
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
            this.label1 = new System.Windows.Forms.Label();
            this.chk_changeDodhiAll = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbo_currentDodhi = new System.Windows.Forms.ComboBox();
            this.cmbo_newDodhi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_updateDodhi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 9, 2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 56);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Customers Dodhi";
            // 
            // chk_changeDodhiAll
            // 
            this.chk_changeDodhiAll.AutoSize = true;
            this.chk_changeDodhiAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_changeDodhiAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk_changeDodhiAll.Location = new System.Drawing.Point(10, 252);
            this.chk_changeDodhiAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_changeDodhiAll.Name = "chk_changeDodhiAll";
            this.chk_changeDodhiAll.Size = new System.Drawing.Size(237, 24);
            this.chk_changeDodhiAll.TabIndex = 6;
            this.chk_changeDodhiAll.Text = "Change from entire database";
            this.chk_changeDodhiAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 60);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecting this checkbox will allow you to update dodhi\r\nfrom all tabels such as C" +
    "ustomer, Chilar receive,\r\nPurhases.";
            // 
            // cmbo_currentDodhi
            // 
            this.cmbo_currentDodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_currentDodhi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_currentDodhi.FormattingEnabled = true;
            this.cmbo_currentDodhi.Location = new System.Drawing.Point(121, 78);
            this.cmbo_currentDodhi.Name = "cmbo_currentDodhi";
            this.cmbo_currentDodhi.Size = new System.Drawing.Size(235, 28);
            this.cmbo_currentDodhi.TabIndex = 10;
            // 
            // cmbo_newDodhi
            // 
            this.cmbo_newDodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_newDodhi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_newDodhi.FormattingEnabled = true;
            this.cmbo_newDodhi.Location = new System.Drawing.Point(121, 133);
            this.cmbo_newDodhi.Name = "cmbo_newDodhi";
            this.cmbo_newDodhi.Size = new System.Drawing.Size(235, 28);
            this.cmbo_newDodhi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Current Dodhi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "New Dodhi";
            // 
            // btn_updateDodhi
            // 
            this.btn_updateDodhi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDodhi.Location = new System.Drawing.Point(252, 177);
            this.btn_updateDodhi.Name = "btn_updateDodhi";
            this.btn_updateDodhi.Size = new System.Drawing.Size(104, 47);
            this.btn_updateDodhi.TabIndex = 14;
            this.btn_updateDodhi.Text = "Update Dodhi";
            this.btn_updateDodhi.UseVisualStyleBackColor = true;
            this.btn_updateDodhi.Click += new System.EventHandler(this.btn_updateDodhi_Click);
            // 
            // Change_Dodhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 354);
            this.Controls.Add(this.btn_updateDodhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_newDodhi);
            this.Controls.Add(this.cmbo_currentDodhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_changeDodhiAll);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_Dodhi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change_Dodhi";
            this.Load += new System.EventHandler(this.Change_Dodhi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_changeDodhiAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbo_currentDodhi;
        private System.Windows.Forms.ComboBox cmbo_newDodhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_updateDodhi;
    }
}