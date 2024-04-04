namespace WindowsFormsApp1
{
    partial class customer_balances
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
            this.chk_addressWise = new System.Windows.Forms.CheckBox();
            this.chk_dodhiWise = new System.Windows.Forms.CheckBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.cmbo_addressWise = new System.Windows.Forms.ComboBox();
            this.cmbo_dodhiWise = new System.Windows.Forms.ComboBox();
            this.Btn_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_debit = new System.Windows.Forms.TextBox();
            this.txt_credit = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chk_addressWise);
            this.panel1.Controls.Add(this.chk_dodhiWise);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_display);
            this.panel1.Controls.Add(this.cmbo_addressWise);
            this.panel1.Controls.Add(this.cmbo_dodhiWise);
            this.panel1.Controls.Add(this.Btn_dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 101);
            this.panel1.TabIndex = 3;
            // 
            // chk_addressWise
            // 
            this.chk_addressWise.AutoSize = true;
            this.chk_addressWise.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_addressWise.ForeColor = System.Drawing.Color.Green;
            this.chk_addressWise.Location = new System.Drawing.Point(309, 57);
            this.chk_addressWise.Name = "chk_addressWise";
            this.chk_addressWise.Size = new System.Drawing.Size(119, 24);
            this.chk_addressWise.TabIndex = 43;
            this.chk_addressWise.Text = "Address Wise";
            this.chk_addressWise.UseVisualStyleBackColor = true;
            this.chk_addressWise.CheckedChanged += new System.EventHandler(this.chk_addressWise_CheckedChanged);
            // 
            // chk_dodhiWise
            // 
            this.chk_dodhiWise.AutoSize = true;
            this.chk_dodhiWise.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_dodhiWise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chk_dodhiWise.Location = new System.Drawing.Point(322, 22);
            this.chk_dodhiWise.Name = "chk_dodhiWise";
            this.chk_dodhiWise.Size = new System.Drawing.Size(106, 24);
            this.chk_dodhiWise.TabIndex = 42;
            this.chk_dodhiWise.Text = "Dodhi Wise";
            this.chk_dodhiWise.UseVisualStyleBackColor = true;
            this.chk_dodhiWise.CheckedChanged += new System.EventHandler(this.chk_dodhiWise_CheckedChanged);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_print.Location = new System.Drawing.Point(720, 19);
            this.btn_print.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(78, 50);
            this.btn_print.TabIndex = 41;
            this.btn_print.TabStop = false;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_display.Location = new System.Drawing.Point(641, 19);
            this.btn_display.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(78, 50);
            this.btn_display.TabIndex = 40;
            this.btn_display.TabStop = false;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // cmbo_addressWise
            // 
            this.cmbo_addressWise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_addressWise.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_addressWise.FormattingEnabled = true;
            this.cmbo_addressWise.Location = new System.Drawing.Point(432, 55);
            this.cmbo_addressWise.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_addressWise.Name = "cmbo_addressWise";
            this.cmbo_addressWise.Size = new System.Drawing.Size(193, 28);
            this.cmbo_addressWise.TabIndex = 36;
            // 
            // cmbo_dodhiWise
            // 
            this.cmbo_dodhiWise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_dodhiWise.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_dodhiWise.FormattingEnabled = true;
            this.cmbo_dodhiWise.Location = new System.Drawing.Point(432, 20);
            this.cmbo_dodhiWise.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_dodhiWise.Name = "cmbo_dodhiWise";
            this.cmbo_dodhiWise.Size = new System.Drawing.Size(193, 28);
            this.cmbo_dodhiWise.TabIndex = 34;
            // 
            // Btn_dashboard
            // 
            this.Btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_dashboard.Location = new System.Drawing.Point(799, 19);
            this.Btn_dashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_dashboard.Name = "Btn_dashboard";
            this.Btn_dashboard.Size = new System.Drawing.Size(102, 50);
            this.Btn_dashboard.TabIndex = 27;
            this.Btn_dashboard.TabStop = false;
            this.Btn_dashboard.Text = "Dashboard";
            this.Btn_dashboard.UseVisualStyleBackColor = true;
            this.Btn_dashboard.Click += new System.EventHandler(this.Btn_dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers Balances";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 112);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(979, 527);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_debit);
            this.panel2.Controls.Add(this.txt_credit);
            this.panel2.Controls.Add(this.txt_balance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 39);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(443, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totals Rs";
            // 
            // txt_debit
            // 
            this.txt_debit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_debit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_debit.Location = new System.Drawing.Point(527, 6);
            this.txt_debit.Name = "txt_debit";
            this.txt_debit.Size = new System.Drawing.Size(116, 25);
            this.txt_debit.TabIndex = 2;
            // 
            // txt_credit
            // 
            this.txt_credit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_credit.Location = new System.Drawing.Point(649, 6);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.Size = new System.Drawing.Size(116, 25);
            this.txt_credit.TabIndex = 1;
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_balance.Location = new System.Drawing.Point(771, 6);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(201, 25);
            this.txt_balance.TabIndex = 0;
            // 
            // customer_balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customer_balances";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "customer_balances";
            this.Load += new System.EventHandler(this.customer_balances_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbo_dodhiWise;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ComboBox cmbo_addressWise;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox chk_addressWise;
        private System.Windows.Forms.CheckBox chk_dodhiWise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_debit;
        private System.Windows.Forms.TextBox txt_credit;
        private System.Windows.Forms.TextBox txt_balance;
    }
}