using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RoznamchaCash : Form
    {
        ReportsClass reportsClass=new ReportsClass();

        public RoznamchaCash()
        {
            InitializeComponent();
        }

        decimal paymentTotal = 0;
        decimal receiptTotal = 0;
        decimal balance = 0;
        decimal openingBalance;

        private void btn_roznamcha_Click(object sender, EventArgs e)
        {
            if (chk_expense.Checked)
            {
                reportsClass.RoznamchaCash(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out paymentTotal, out receiptTotal, out balance, out openingBalance, true);
            }
            else
            {
                reportsClass.RoznamchaCash(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out paymentTotal, out receiptTotal, out balance, out openingBalance, false);
            }

            txt_paymentTotal.Text = paymentTotal.ToString();
            txt_receiptTotal.Text = receiptTotal.ToString();
            txt_balance.Text=balance.ToString();

            if (openingBalance > 0)
            {
                lbl_openingBalance.Text = "Accounts Opening Balance is: " + openingBalance.ToString() + " Credit";
            }
            else
            {
                lbl_openingBalance.Text = "Accounts Opening Balance is: " + openingBalance.ToString() + " Debit";
            }
        }

        private void RoznamchaCash_Load(object sender, EventArgs e)
        {
            chk_expense.Checked = true;

            reportsClass.RoznamchaCash(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out paymentTotal, out receiptTotal, out balance, out openingBalance, true);

            txt_paymentTotal.Text = paymentTotal.ToString();
            txt_receiptTotal.Text = receiptTotal.ToString();

            txt_balance.Text = balance > 0 ? balance.ToString() + " Cr" : Math.Abs(balance).ToString() + " Dr";

            if(openingBalance>0)
            {
                lbl_openingBalance.Text = "Accounts Opening Balance is: " + Math.Abs(openingBalance).ToString() + " Credit";
                
            }
            else
            {
                lbl_openingBalance.Text = "Accounts Opening Balance is: " + Math.Abs(openingBalance).ToString() + " Debit";
            }

        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.ShowDialog();
        }

        private void btn_receipts_Click(object sender, EventArgs e)
        {
            Receipts_Form receipts_Form= new Receipts_Form();
            receipts_Form.ShowDialog();
        }

        private void txt_datagridId_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Customer/Company Name] LIKE '%" + txt_datagridId.Text.Trim() + "%'");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if(selectedIndex>=0 && selectedIndex<dataGridView1.Rows.Count)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    string transactionId = selectedRow.Cells["Trans.Id"].Value.ToString();

                    // Find the index where the digits start
                    int index = 0;
                    for (int i = 0; i < transactionId.Length; i++)
                    {
                        if (char.IsDigit(transactionId[i]))
                        {
                            index = i;
                            break;
                        }
                    }

                    // Separate the number part and the other part
                    string formCode = transactionId.Substring(0, index); // "pv"
                    string numberPart = transactionId.Substring(index); // "12"

                    int id = int.Parse(numberPart);

                    
                    if (formCode == "CPV")
                    {
                        Payments payments = new Payments();
                        payments.isFromOtherForm = true;
                        payments.paymentId = id;
                        payments.ShowDialog();
                    }
                    else if (formCode == "CRV")
                    {
                        Receipts_Form receipts = new Receipts_Form();
                        receipts.isFromOtherForm = true;
                        receipts.receiptId = id;
                        receipts.ShowDialog();
                    }
                    else if (formCode == "SV")
                    {
                        Sales sales = new Sales();
                        sales.isFromOtherForm = true;
                        sales.salesId = id;
                        sales.ShowDialog();
                    }
                }
            }
        }
    }
}
