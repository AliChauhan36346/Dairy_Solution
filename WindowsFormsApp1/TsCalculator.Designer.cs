namespace WindowsFormsApp1
{
    partial class TsCalculator
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
            this.txt_tsStandard = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_liters = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tsLiters = new System.Windows.Forms.TextBox();
            this.btn_calculatTs = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 51);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ts-Calculator";
            // 
            // txt_tsStandard
            // 
            this.txt_tsStandard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsStandard.Location = new System.Drawing.Point(117, 161);
            this.txt_tsStandard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tsStandard.Name = "txt_tsStandard";
            this.txt_tsStandard.Size = new System.Drawing.Size(132, 27);
            this.txt_tsStandard.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(14, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "ts-standard";
            // 
            // txt_fat
            // 
            this.txt_fat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fat.Location = new System.Drawing.Point(117, 127);
            this.txt_fat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fat.Name = "txt_fat";
            this.txt_fat.Size = new System.Drawing.Size(132, 27);
            this.txt_fat.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fat%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "LR";
            // 
            // txt_lr
            // 
            this.txt_lr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lr.Location = new System.Drawing.Point(116, 93);
            this.txt_lr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_lr.Name = "txt_lr";
            this.txt_lr.Size = new System.Drawing.Size(133, 27);
            this.txt_lr.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Gross Liters";
            // 
            // txt_liters
            // 
            this.txt_liters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_liters.Location = new System.Drawing.Point(116, 59);
            this.txt_liters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_liters.Name = "txt_liters";
            this.txt_liters.Size = new System.Drawing.Size(133, 27);
            this.txt_liters.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(28, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ts Ltrs";
            // 
            // txt_tsLiters
            // 
            this.txt_tsLiters.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tsLiters.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tsLiters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_tsLiters.Location = new System.Drawing.Point(84, 282);
            this.txt_tsLiters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tsLiters.Name = "txt_tsLiters";
            this.txt_tsLiters.Size = new System.Drawing.Size(203, 28);
            this.txt_tsLiters.TabIndex = 46;
            this.txt_tsLiters.TabStop = false;
            this.txt_tsLiters.TextChanged += new System.EventHandler(this.txt_tsLiters_TextChanged);
            // 
            // btn_calculatTs
            // 
            this.btn_calculatTs.BackColor = System.Drawing.Color.White;
            this.btn_calculatTs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculatTs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_calculatTs.Location = new System.Drawing.Point(116, 194);
            this.btn_calculatTs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_calculatTs.Name = "btn_calculatTs";
            this.btn_calculatTs.Size = new System.Drawing.Size(133, 42);
            this.btn_calculatTs.TabIndex = 47;
            this.btn_calculatTs.Text = "Calculate Ts";
            this.btn_calculatTs.UseVisualStyleBackColor = false;
            this.btn_calculatTs.Click += new System.EventHandler(this.btn_calculatTs_Click);
            // 
            // TsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 319);
            this.Controls.Add(this.btn_calculatTs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tsLiters);
            this.Controls.Add(this.txt_tsStandard);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_fat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_liters);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TsCalculator";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TsCalculator";
            this.Load += new System.EventHandler(this.TsCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tsStandard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_fat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_liters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tsLiters;
        private System.Windows.Forms.Button btn_calculatTs;
    }
}