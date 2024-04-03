namespace WindowsFormsApp1
{
    partial class Clear_Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clear_Transactions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_clearEntities = new System.Windows.Forms.CheckBox();
            this.btn_clearAllTransactions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 62);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clear Transactions";
            // 
            // chk_clearEntities
            // 
            this.chk_clearEntities.AutoSize = true;
            this.chk_clearEntities.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_clearEntities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk_clearEntities.Location = new System.Drawing.Point(16, 81);
            this.chk_clearEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_clearEntities.Name = "chk_clearEntities";
            this.chk_clearEntities.Size = new System.Drawing.Size(160, 24);
            this.chk_clearEntities.TabIndex = 5;
            this.chk_clearEntities.Text = "Clear Entities Also";
            this.chk_clearEntities.UseVisualStyleBackColor = true;
            this.chk_clearEntities.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_clearAllTransactions
            // 
            this.btn_clearAllTransactions.Location = new System.Drawing.Point(317, 310);
            this.btn_clearAllTransactions.Name = "btn_clearAllTransactions";
            this.btn_clearAllTransactions.Size = new System.Drawing.Size(98, 64);
            this.btn_clearAllTransactions.TabIndex = 6;
            this.btn_clearAllTransactions.Text = "Clear All Transactions";
            this.btn_clearAllTransactions.UseVisualStyleBackColor = true;
            this.btn_clearAllTransactions.Click += new System.EventHandler(this.btn_clearAllTransactions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 80);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecting this checkbox will allow you to clear all entities\r\nassociated with the" +
    " selected options, such as customer\r\naccounts, company records, and other relate" +
    "d data.";
            // 
            // Clear_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 386);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clearAllTransactions);
            this.Controls.Add(this.chk_clearEntities);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clear_Transactions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clear Transactions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_clearEntities;
        private System.Windows.Forms.Button btn_clearAllTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}