namespace WindowsFormsApp1
{
    partial class Parchi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parchi));
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.cmbo_dodhi = new System.Windows.Forms.ComboBox();
            this.Btn_dashboard = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_thermalPrint = new System.Windows.Forms.CheckBox();
            this.btn_printCusList = new System.Windows.Forms.Button();
            this.rdo_pringDialog = new System.Windows.Forms.RadioButton();
            this.rdo_printPreview = new System.Windows.Forms.RadioButton();
            this.btn_paymentList = new System.Windows.Forms.Button();
            this.chk_dodhiWise = new System.Windows.Forms.CheckBox();
            this.chk_singleCustomer = new System.Windows.Forms.CheckBox();
            this.txt_accountName = new System.Windows.Forms.TextBox();
            this.txt_accountId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtm_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtm_start = new System.Windows.Forms.DateTimePicker();
            this.btn_printAndAddPayments = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_totalLiters = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalParchiAmount = new System.Windows.Forms.TextBox();
            this.txt_totalLitersAmount = new System.Windows.Forms.TextBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lstAccountSuggestions = new System.Windows.Forms.ListBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printDialog3 = new System.Windows.Forms.PrintDialog();
            this.printDocument4 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_print.Location = new System.Drawing.Point(864, 20);
            this.btn_print.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(69, 46);
            this.btn_print.TabIndex = 41;
            this.btn_print.TabStop = false;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.White;
            this.btn_display.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_display.Location = new System.Drawing.Point(795, 20);
            this.btn_display.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(69, 46);
            this.btn_display.TabIndex = 40;
            this.btn_display.TabStop = false;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // cmbo_dodhi
            // 
            this.cmbo_dodhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_dodhi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_dodhi.FormattingEnabled = true;
            this.cmbo_dodhi.Location = new System.Drawing.Point(457, 20);
            this.cmbo_dodhi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbo_dodhi.Name = "cmbo_dodhi";
            this.cmbo_dodhi.Size = new System.Drawing.Size(329, 28);
            this.cmbo_dodhi.TabIndex = 34;
            this.cmbo_dodhi.SelectedIndexChanged += new System.EventHandler(this.cmbo_dodhi_SelectedIndexChanged);
            // 
            // Btn_dashboard
            // 
            this.Btn_dashboard.BackColor = System.Drawing.Color.White;
            this.Btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_dashboard.Location = new System.Drawing.Point(933, 20);
            this.Btn_dashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_dashboard.Name = "Btn_dashboard";
            this.Btn_dashboard.Size = new System.Drawing.Size(75, 46);
            this.Btn_dashboard.TabIndex = 27;
            this.Btn_dashboard.TabStop = false;
            this.Btn_dashboard.Text = "Dashboard";
            this.Btn_dashboard.UseVisualStyleBackColor = false;
            this.Btn_dashboard.Click += new System.EventHandler(this.Btn_dashboard_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(0, 145);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1354, 502);
            this.dataGridView2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parchi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chk_thermalPrint);
            this.panel1.Controls.Add(this.btn_printCusList);
            this.panel1.Controls.Add(this.rdo_pringDialog);
            this.panel1.Controls.Add(this.rdo_printPreview);
            this.panel1.Controls.Add(this.btn_paymentList);
            this.panel1.Controls.Add(this.chk_dodhiWise);
            this.panel1.Controls.Add(this.chk_singleCustomer);
            this.panel1.Controls.Add(this.txt_accountName);
            this.panel1.Controls.Add(this.txt_accountId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtm_end);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtm_start);
            this.panel1.Controls.Add(this.btn_printAndAddPayments);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_display);
            this.panel1.Controls.Add(this.cmbo_dodhi);
            this.panel1.Controls.Add(this.Btn_dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 134);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chk_thermalPrint
            // 
            this.chk_thermalPrint.AutoSize = true;
            this.chk_thermalPrint.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_thermalPrint.ForeColor = System.Drawing.Color.Sienna;
            this.chk_thermalPrint.Location = new System.Drawing.Point(1149, 20);
            this.chk_thermalPrint.Name = "chk_thermalPrint";
            this.chk_thermalPrint.Size = new System.Drawing.Size(139, 25);
            this.chk_thermalPrint.TabIndex = 128;
            this.chk_thermalPrint.Text = "Thermal Print";
            this.chk_thermalPrint.UseVisualStyleBackColor = true;
            // 
            // btn_printCusList
            // 
            this.btn_printCusList.BackColor = System.Drawing.Color.White;
            this.btn_printCusList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printCusList.ForeColor = System.Drawing.Color.Green;
            this.btn_printCusList.Location = new System.Drawing.Point(883, 68);
            this.btn_printCusList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_printCusList.Name = "btn_printCusList";
            this.btn_printCusList.Size = new System.Drawing.Size(95, 52);
            this.btn_printCusList.TabIndex = 127;
            this.btn_printCusList.TabStop = false;
            this.btn_printCusList.Text = "print Customer List";
            this.btn_printCusList.UseVisualStyleBackColor = false;
            this.btn_printCusList.Click += new System.EventHandler(this.btn_printCusList_Click);
            // 
            // rdo_pringDialog
            // 
            this.rdo_pringDialog.AutoSize = true;
            this.rdo_pringDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_pringDialog.Location = new System.Drawing.Point(1149, 90);
            this.rdo_pringDialog.Name = "rdo_pringDialog";
            this.rdo_pringDialog.Size = new System.Drawing.Size(106, 21);
            this.rdo_pringDialog.TabIndex = 126;
            this.rdo_pringDialog.TabStop = true;
            this.rdo_pringDialog.Text = "Print Diaglog";
            this.rdo_pringDialog.UseVisualStyleBackColor = true;
            // 
            // rdo_printPreview
            // 
            this.rdo_printPreview.AutoSize = true;
            this.rdo_printPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_printPreview.Location = new System.Drawing.Point(1149, 63);
            this.rdo_printPreview.Name = "rdo_printPreview";
            this.rdo_printPreview.Size = new System.Drawing.Size(108, 21);
            this.rdo_printPreview.TabIndex = 125;
            this.rdo_printPreview.TabStop = true;
            this.rdo_printPreview.Text = "Print Preview";
            this.rdo_printPreview.UseVisualStyleBackColor = true;
            // 
            // btn_paymentList
            // 
            this.btn_paymentList.BackColor = System.Drawing.Color.White;
            this.btn_paymentList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_paymentList.Location = new System.Drawing.Point(796, 68);
            this.btn_paymentList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_paymentList.Name = "btn_paymentList";
            this.btn_paymentList.Size = new System.Drawing.Size(87, 52);
            this.btn_paymentList.TabIndex = 124;
            this.btn_paymentList.TabStop = false;
            this.btn_paymentList.Text = "Print Payment List";
            this.btn_paymentList.UseVisualStyleBackColor = false;
            this.btn_paymentList.Click += new System.EventHandler(this.btn_paymentList_Click);
            // 
            // chk_dodhiWise
            // 
            this.chk_dodhiWise.AutoSize = true;
            this.chk_dodhiWise.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_dodhiWise.Location = new System.Drawing.Point(350, 24);
            this.chk_dodhiWise.Name = "chk_dodhiWise";
            this.chk_dodhiWise.Size = new System.Drawing.Size(96, 21);
            this.chk_dodhiWise.TabIndex = 123;
            this.chk_dodhiWise.Text = "Dodhi Wise";
            this.chk_dodhiWise.UseVisualStyleBackColor = true;
            this.chk_dodhiWise.CheckedChanged += new System.EventHandler(this.chk_dodhiWise_CheckedChanged);
            // 
            // chk_singleCustomer
            // 
            this.chk_singleCustomer.AutoSize = true;
            this.chk_singleCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_singleCustomer.Location = new System.Drawing.Point(324, 62);
            this.chk_singleCustomer.Name = "chk_singleCustomer";
            this.chk_singleCustomer.Size = new System.Drawing.Size(122, 21);
            this.chk_singleCustomer.TabIndex = 122;
            this.chk_singleCustomer.Text = "Single customer";
            this.chk_singleCustomer.UseVisualStyleBackColor = true;
            this.chk_singleCustomer.CheckedChanged += new System.EventHandler(this.chk_singleCustomer_CheckedChanged);
            // 
            // txt_accountName
            // 
            this.txt_accountName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_accountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountName.Location = new System.Drawing.Point(555, 58);
            this.txt_accountName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_accountName.Name = "txt_accountName";
            this.txt_accountName.ReadOnly = true;
            this.txt_accountName.Size = new System.Drawing.Size(231, 27);
            this.txt_accountName.TabIndex = 120;
            this.txt_accountName.TabStop = false;
            // 
            // txt_accountId
            // 
            this.txt_accountId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountId.Location = new System.Drawing.Point(456, 58);
            this.txt_accountId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_accountId.Name = "txt_accountId";
            this.txt_accountId.Size = new System.Drawing.Size(96, 27);
            this.txt_accountId.TabIndex = 119;
            this.txt_accountId.TextChanged += new System.EventHandler(this.txt_accountId_TextChanged);
            this.txt_accountId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accountId_KeyDown);
            this.txt_accountId.Leave += new System.EventHandler(this.txt_accountId_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(365, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "From date";
            // 
            // dtm_end
            // 
            this.dtm_end.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_end.Location = new System.Drawing.Point(605, 93);
            this.dtm_end.Margin = new System.Windows.Forms.Padding(4);
            this.dtm_end.Name = "dtm_end";
            this.dtm_end.Size = new System.Drawing.Size(106, 27);
            this.dtm_end.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(573, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "to";
            // 
            // dtm_start
            // 
            this.dtm_start.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_start.Location = new System.Drawing.Point(457, 93);
            this.dtm_start.Margin = new System.Windows.Forms.Padding(4);
            this.dtm_start.Name = "dtm_start";
            this.dtm_start.Size = new System.Drawing.Size(106, 27);
            this.dtm_start.TabIndex = 44;
            // 
            // btn_printAndAddPayments
            // 
            this.btn_printAndAddPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_printAndAddPayments.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printAndAddPayments.ForeColor = System.Drawing.Color.White;
            this.btn_printAndAddPayments.Location = new System.Drawing.Point(7, 74);
            this.btn_printAndAddPayments.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_printAndAddPayments.Name = "btn_printAndAddPayments";
            this.btn_printAndAddPayments.Size = new System.Drawing.Size(96, 52);
            this.btn_printAndAddPayments.TabIndex = 42;
            this.btn_printAndAddPayments.TabStop = false;
            this.btn_printAndAddPayments.Text = "Add Payments";
            this.btn_printAndAddPayments.UseVisualStyleBackColor = false;
            this.btn_printAndAddPayments.Click += new System.EventHandler(this.btn_printAndAddPayments_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txt_totalLiters);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_totalParchiAmount);
            this.panel2.Controls.Add(this.txt_totalLitersAmount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 648);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1354, 41);
            this.panel2.TabIndex = 40;
            // 
            // txt_totalLiters
            // 
            this.txt_totalLiters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalLiters.ForeColor = System.Drawing.Color.Green;
            this.txt_totalLiters.Location = new System.Drawing.Point(560, 7);
            this.txt_totalLiters.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalLiters.Name = "txt_totalLiters";
            this.txt_totalLiters.Size = new System.Drawing.Size(94, 27);
            this.txt_totalLiters.TabIndex = 5;
            this.txt_totalLiters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(471, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Totals";
            // 
            // txt_totalParchiAmount
            // 
            this.txt_totalParchiAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalParchiAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_totalParchiAmount.Location = new System.Drawing.Point(775, 7);
            this.txt_totalParchiAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalParchiAmount.Name = "txt_totalParchiAmount";
            this.txt_totalParchiAmount.Size = new System.Drawing.Size(111, 27);
            this.txt_totalParchiAmount.TabIndex = 2;
            this.txt_totalParchiAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_totalLitersAmount
            // 
            this.txt_totalLitersAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalLitersAmount.ForeColor = System.Drawing.Color.Red;
            this.txt_totalLitersAmount.Location = new System.Drawing.Point(659, 7);
            this.txt_totalLitersAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalLitersAmount.Name = "txt_totalLitersAmount";
            this.txt_totalLitersAmount.Size = new System.Drawing.Size(110, 27);
            this.txt_totalLitersAmount.TabIndex = 1;
            this.txt_totalLitersAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lstAccountSuggestions
            // 
            this.lstAccountSuggestions.FormattingEnabled = true;
            this.lstAccountSuggestions.ItemHeight = 17;
            this.lstAccountSuggestions.Location = new System.Drawing.Point(457, 87);
            this.lstAccountSuggestions.Name = "lstAccountSuggestions";
            this.lstAccountSuggestions.Size = new System.Drawing.Size(330, 208);
            this.lstAccountSuggestions.TabIndex = 41;
            this.lstAccountSuggestions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAccountSuggestions_MouseDoubleClick);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(429, 299);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(296, 25);
            this.lbl_status.TabIndex = 47;
            this.lbl_status.Text = "Please Wait, Adding Payments...";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // printDialog3
            // 
            this.printDialog3.UseEXDialog = true;
            // 
            // printDocument4
            // 
            this.printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument4_PrintPage);
            // 
            // Parchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 689);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lstAccountSuggestions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Parchi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parchi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Parchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ComboBox cmbo_dodhi;
        private System.Windows.Forms.Button Btn_dashboard;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_printAndAddPayments;
        private System.Windows.Forms.DateTimePicker dtm_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtm_start;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalParchiAmount;
        private System.Windows.Forms.TextBox txt_totalLitersAmount;
        private System.Windows.Forms.TextBox txt_totalLiters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_accountName;
        private System.Windows.Forms.TextBox txt_accountId;
        private System.Windows.Forms.CheckBox chk_singleCustomer;
        private System.Windows.Forms.CheckBox chk_dodhiWise;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ListBox lstAccountSuggestions;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btn_paymentList;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RadioButton rdo_pringDialog;
        private System.Windows.Forms.RadioButton rdo_printPreview;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Button btn_printCusList;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.PrintDialog printDialog3;
        private System.Drawing.Printing.PrintDocument printDocument4;
        private System.Windows.Forms.CheckBox chk_thermalPrint;
    }
}