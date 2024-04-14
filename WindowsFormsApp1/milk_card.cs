using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class milk_card : Form
    {
        AccountsLegersClass accountsLegersClass = new AccountsLegersClass();
        CommonFunctionsClass CommonFunctions = new CommonFunctionsClass();
        public int id;

        public milk_card()
        {
            InitializeComponent();
        }

        private void milk_card_Load(object sender, EventArgs e)
        {
            lstAccountSuggestions.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_accountId.Text, out id))
            {

            }

            accountsLegersClass.GetCustomerMilkCard(id, dtm_startDate.Value.Date, dtm_endDate.Value.Date,
                out decimal morningTotal, out decimal eveningTotal, out decimal milkTotal,
                out decimal totalMilkAmount, dataGridView2);

            txt_totalLiters.Text = milkTotal.ToString();
            txt_totalMorning.Text = morningTotal.ToString();
            totalEvening.Text = eveningTotal.ToString();
            totalMilkAmount = Math.Round(totalMilkAmount, 1);
            txt_totalAmount.Text = totalMilkAmount.ToString();
        }

        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            CommonFunctions.ShowAccountSuggestions(txt_accountId, lstAccountSuggestions, "customer");
        }

        private void txt_accountId_KeyDown(object sender, KeyEventArgs e)
        {
            CommonFunctions.HandleAccountSuggestionKeyDown(txt_accountId, txt_accountName, lstAccountSuggestions, e);
            
        }
    }
}
