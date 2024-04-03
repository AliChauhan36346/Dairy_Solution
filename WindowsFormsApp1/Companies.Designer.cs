namespace WindowsFormsApp1
{
    partial class Companies
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
            this.comBtn_addNew = new System.Windows.Forms.Button();
            this.comBtn_Save = new System.Windows.Forms.Button();
            this.comBtn_deleteEntry = new System.Windows.Forms.Button();
            this.comBtn_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_updateCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.compBtn_find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.compTxt_searchCompany = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBtn_addNew
            // 
            this.comBtn_addNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBtn_addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comBtn_addNew.Location = new System.Drawing.Point(497, 3);
            this.comBtn_addNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comBtn_addNew.Name = "comBtn_addNew";
            this.comBtn_addNew.Size = new System.Drawing.Size(71, 42);
            this.comBtn_addNew.TabIndex = 1;
            this.comBtn_addNew.Text = "Add New";
            this.comBtn_addNew.UseVisualStyleBackColor = true;
            this.comBtn_addNew.Click += new System.EventHandler(this.comBtn_addNew_Click);
            // 
            // comBtn_Save
            // 
            this.comBtn_Save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBtn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comBtn_Save.Location = new System.Drawing.Point(426, 3);
            this.comBtn_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comBtn_Save.Name = "comBtn_Save";
            this.comBtn_Save.Size = new System.Drawing.Size(71, 42);
            this.comBtn_Save.TabIndex = 0;
            this.comBtn_Save.Text = "Save";
            this.comBtn_Save.UseVisualStyleBackColor = true;
            this.comBtn_Save.Click += new System.EventHandler(this.comBtn_Save_Click);
            // 
            // comBtn_deleteEntry
            // 
            this.comBtn_deleteEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBtn_deleteEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comBtn_deleteEntry.Location = new System.Drawing.Point(645, 3);
            this.comBtn_deleteEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comBtn_deleteEntry.Name = "comBtn_deleteEntry";
            this.comBtn_deleteEntry.Size = new System.Drawing.Size(71, 42);
            this.comBtn_deleteEntry.TabIndex = 29;
            this.comBtn_deleteEntry.TabStop = false;
            this.comBtn_deleteEntry.Text = "Delete Compny";
            this.comBtn_deleteEntry.UseVisualStyleBackColor = true;
            this.comBtn_deleteEntry.Click += new System.EventHandler(this.comBtn_deleteEntry_Click);
            // 
            // comBtn_dashboard
            // 
            this.comBtn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBtn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comBtn_dashboard.Location = new System.Drawing.Point(574, 3);
            this.comBtn_dashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comBtn_dashboard.Name = "comBtn_dashboard";
            this.comBtn_dashboard.Size = new System.Drawing.Size(71, 42);
            this.comBtn_dashboard.TabIndex = 27;
            this.comBtn_dashboard.TabStop = false;
            this.comBtn_dashboard.Text = "Dashboard";
            this.comBtn_dashboard.UseVisualStyleBackColor = true;
            this.comBtn_dashboard.Click += new System.EventHandler(this.comBtn_dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_updateCompany);
            this.panel1.Controls.Add(this.comBtn_addNew);
            this.panel1.Controls.Add(this.comBtn_Save);
            this.panel1.Controls.Add(this.comBtn_deleteEntry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comBtn_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 51);
            this.panel1.TabIndex = 1;
            // 
            // btn_updateCompany
            // 
            this.btn_updateCompany.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_updateCompany.Location = new System.Drawing.Point(349, 3);
            this.btn_updateCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_updateCompany.Name = "btn_updateCompany";
            this.btn_updateCompany.Size = new System.Drawing.Size(71, 42);
            this.btn_updateCompany.TabIndex = 30;
            this.btn_updateCompany.Text = "Update Company";
            this.btn_updateCompany.UseVisualStyleBackColor = true;
            this.btn_updateCompany.Click += new System.EventHandler(this.btn_updateCompany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Companies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 271);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(49, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(72, 25);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(78, 25);
            this.txt_id.TabIndex = 4;
            this.txt_id.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_rate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_companyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(257, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Info";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(72, 97);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(178, 52);
            this.txt_address.TabIndex = 2;
            this.txt_address.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(34, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rate";
            // 
            // txt_rate
            // 
            this.txt_rate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.Location = new System.Drawing.Point(72, 158);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(78, 25);
            this.txt_rate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companyName.Location = new System.Drawing.Point(72, 60);
            this.txt_companyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(178, 25);
            this.txt_companyName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.compBtn_find);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.compTxt_searchCompany);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(450, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(268, 99);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Companies";
            // 
            // compBtn_find
            // 
            this.compBtn_find.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compBtn_find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.compBtn_find.Location = new System.Drawing.Point(201, 58);
            this.compBtn_find.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.compBtn_find.Name = "compBtn_find";
            this.compBtn_find.Size = new System.Drawing.Size(61, 33);
            this.compBtn_find.TabIndex = 34;
            this.compBtn_find.TabStop = false;
            this.compBtn_find.Text = "Find";
            this.compBtn_find.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id or Name";
            // 
            // compTxt_searchCompany
            // 
            this.compTxt_searchCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compTxt_searchCompany.Location = new System.Drawing.Point(90, 25);
            this.compTxt_searchCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.compTxt_searchCompany.Name = "compTxt_searchCompany";
            this.compTxt_searchCompany.Size = new System.Drawing.Size(171, 25);
            this.compTxt_searchCompany.TabIndex = 6;
            this.compTxt_searchCompany.TabStop = false;
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Companies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.Companies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button comBtn_addNew;
        private System.Windows.Forms.Button comBtn_Save;
        private System.Windows.Forms.Button comBtn_deleteEntry;
        private System.Windows.Forms.Button comBtn_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button compBtn_find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compTxt_searchCompany;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Button btn_updateCompany;
    }
}