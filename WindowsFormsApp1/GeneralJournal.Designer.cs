namespace WindowsFormsApp1
{
    partial class GeneralJournal
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_JournalId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_forwardRec = new System.Windows.Forms.Button();
            this.btn_previousRec = new System.Windows.Forms.Button();
            this.dtm_picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAccountSeggestions = new System.Windows.Forms.ListBox();
            this.txt_discription = new System.Windows.Forms.RichTextBox();
            this.txt_accountId1 = new System.Windows.Forms.TextBox();
            this.txt_accountName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_credit1 = new System.Windows.Forms.TextBox();
            this.txt_debit1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_credit2 = new System.Windows.Forms.TextBox();
            this.txt_debit2 = new System.Windows.Forms.TextBox();
            this.txt_accountName2 = new System.Windows.Forms.TextBox();
            this.txt_accountId2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 62);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(596, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 52);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(677, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 52);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(758, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 52);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAL JOURNAL VOUCHER";
            // 
            // txt_JournalId
            // 
            this.txt_JournalId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_JournalId.Location = new System.Drawing.Point(168, 97);
            this.txt_JournalId.Name = "txt_JournalId";
            this.txt_JournalId.Size = new System.Drawing.Size(103, 25);
            this.txt_JournalId.TabIndex = 1;
            this.txt_JournalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial No";
            // 
            // btn_forwardRec
            // 
            this.btn_forwardRec.Location = new System.Drawing.Point(271, 96);
            this.btn_forwardRec.Name = "btn_forwardRec";
            this.btn_forwardRec.Size = new System.Drawing.Size(41, 27);
            this.btn_forwardRec.TabIndex = 3;
            this.btn_forwardRec.Text = ">>";
            this.btn_forwardRec.UseVisualStyleBackColor = true;
            this.btn_forwardRec.Click += new System.EventHandler(this.btn_forwardRec_Click);
            // 
            // btn_previousRec
            // 
            this.btn_previousRec.Location = new System.Drawing.Point(127, 96);
            this.btn_previousRec.Name = "btn_previousRec";
            this.btn_previousRec.Size = new System.Drawing.Size(41, 27);
            this.btn_previousRec.TabIndex = 4;
            this.btn_previousRec.Text = "<<";
            this.btn_previousRec.UseVisualStyleBackColor = true;
            this.btn_previousRec.Click += new System.EventHandler(this.btn_previousRec_Click);
            // 
            // dtm_picker
            // 
            this.dtm_picker.CalendarForeColor = System.Drawing.Color.Black;
            this.dtm_picker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtm_picker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtm_picker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_picker.Location = new System.Drawing.Point(168, 131);
            this.dtm_picker.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_picker.Name = "dtm_picker";
            this.dtm_picker.Size = new System.Drawing.Size(103, 25);
            this.dtm_picker.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Discription";
            this.label4.UseMnemonic = false;
            // 
            // lstAccountSeggestions
            // 
            this.lstAccountSeggestions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccountSeggestions.FormattingEnabled = true;
            this.lstAccountSeggestions.ItemHeight = 17;
            this.lstAccountSeggestions.Location = new System.Drawing.Point(512, 216);
            this.lstAccountSeggestions.Name = "lstAccountSeggestions";
            this.lstAccountSeggestions.Size = new System.Drawing.Size(288, 174);
            this.lstAccountSeggestions.TabIndex = 19;
            // 
            // txt_discription
            // 
            this.txt_discription.Location = new System.Drawing.Point(168, 164);
            this.txt_discription.Name = "txt_discription";
            this.txt_discription.Size = new System.Drawing.Size(338, 54);
            this.txt_discription.TabIndex = 20;
            this.txt_discription.Text = "";
            // 
            // txt_accountId1
            // 
            this.txt_accountId1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountId1.Location = new System.Drawing.Point(168, 224);
            this.txt_accountId1.Name = "txt_accountId1";
            this.txt_accountId1.Size = new System.Drawing.Size(103, 25);
            this.txt_accountId1.TabIndex = 21;
            this.txt_accountId1.TextChanged += new System.EventHandler(this.txt_accountId1_TextChanged);
            this.txt_accountId1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accountId1_KeyDown);
            // 
            // txt_accountName1
            // 
            this.txt_accountName1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountName1.Location = new System.Drawing.Point(277, 224);
            this.txt_accountName1.Name = "txt_accountName1";
            this.txt_accountName1.Size = new System.Drawing.Size(229, 25);
            this.txt_accountName1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(366, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Credit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(166, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Debit";
            // 
            // txt_credit1
            // 
            this.txt_credit1.Location = new System.Drawing.Point(368, 274);
            this.txt_credit1.Name = "txt_credit1";
            this.txt_credit1.Size = new System.Drawing.Size(138, 23);
            this.txt_credit1.TabIndex = 24;
            this.txt_credit1.TextChanged += new System.EventHandler(this.txt_credit1_TextChanged);
            this.txt_credit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_credit1_KeyDown);
            // 
            // txt_debit1
            // 
            this.txt_debit1.Location = new System.Drawing.Point(168, 274);
            this.txt_debit1.Name = "txt_debit1";
            this.txt_debit1.Size = new System.Drawing.Size(138, 23);
            this.txt_debit1.TabIndex = 23;
            this.txt_debit1.TextChanged += new System.EventHandler(this.txt_debit1_TextChanged);
            this.txt_debit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_debit1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(366, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Credit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(166, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Debit";
            // 
            // txt_credit2
            // 
            this.txt_credit2.Location = new System.Drawing.Point(368, 367);
            this.txt_credit2.Name = "txt_credit2";
            this.txt_credit2.Size = new System.Drawing.Size(138, 23);
            this.txt_credit2.TabIndex = 30;
            this.txt_credit2.TextChanged += new System.EventHandler(this.txt_credit2_TextChanged);
            this.txt_credit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_credit2_KeyDown);
            // 
            // txt_debit2
            // 
            this.txt_debit2.Location = new System.Drawing.Point(168, 367);
            this.txt_debit2.Name = "txt_debit2";
            this.txt_debit2.Size = new System.Drawing.Size(138, 23);
            this.txt_debit2.TabIndex = 29;
            this.txt_debit2.TextChanged += new System.EventHandler(this.txt_debit2_TextChanged);
            this.txt_debit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_debit2_KeyDown);
            // 
            // txt_accountName2
            // 
            this.txt_accountName2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountName2.Location = new System.Drawing.Point(277, 312);
            this.txt_accountName2.Name = "txt_accountName2";
            this.txt_accountName2.Size = new System.Drawing.Size(229, 25);
            this.txt_accountName2.TabIndex = 28;
            // 
            // txt_accountId2
            // 
            this.txt_accountId2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountId2.Location = new System.Drawing.Point(168, 312);
            this.txt_accountId2.Name = "txt_accountId2";
            this.txt_accountId2.Size = new System.Drawing.Size(103, 25);
            this.txt_accountId2.TabIndex = 27;
            this.txt_accountId2.TextChanged += new System.EventHandler(this.txt_accountId2_TextChanged);
            this.txt_accountId2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accountId2_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Account Id";
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Account Id";
            this.label10.UseMnemonic = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(757, 207);
            this.dataGridView1.TabIndex = 35;
            // 
            // GeneralJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_credit2);
            this.Controls.Add(this.txt_debit2);
            this.Controls.Add(this.txt_accountName2);
            this.Controls.Add(this.txt_accountId2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_credit1);
            this.Controls.Add(this.txt_debit1);
            this.Controls.Add(this.txt_accountName1);
            this.Controls.Add(this.txt_accountId1);
            this.Controls.Add(this.txt_discription);
            this.Controls.Add(this.lstAccountSeggestions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtm_picker);
            this.Controls.Add(this.btn_previousRec);
            this.Controls.Add(this.btn_forwardRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_JournalId);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GeneralJournal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "General Journal";
            this.Load += new System.EventHandler(this.GeneralJournal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_JournalId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_forwardRec;
        private System.Windows.Forms.Button btn_previousRec;
        private System.Windows.Forms.DateTimePicker dtm_picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstAccountSeggestions;
        private System.Windows.Forms.RichTextBox txt_discription;
        private System.Windows.Forms.TextBox txt_accountId1;
        private System.Windows.Forms.TextBox txt_accountName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_credit1;
        private System.Windows.Forms.TextBox txt_debit1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_credit2;
        private System.Windows.Forms.TextBox txt_debit2;
        private System.Windows.Forms.TextBox txt_accountName2;
        private System.Windows.Forms.TextBox txt_accountId2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}