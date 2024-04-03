using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public partial class cashAccountSelectionForm : Form
    {
        AddAccounts accounts = new AddAccounts();
        public string SelectedCashAccount { get; private set; }

        public cashAccountSelectionForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cashAccountSelectionForm_Load(object sender, EventArgs e)
        {
            List<string> cashAccounts = new List<string>();

            cashAccounts=accounts.GetAccounts();

            foreach (string account in cashAccounts)
            {
                cmbo_cashAccount.Items.Add(account);
            }

        }

        private void btn_addPayment_Click(object sender, EventArgs e)
        {
            if (cmbo_cashAccount.SelectedIndex != -1)
            {
                SelectedCashAccount = cmbo_cashAccount.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a cash account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
