using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MilkCardCompany : Form
    {
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();

        AccountsLegersClass legersClass = new AccountsLegersClass();

        public int id = -1;
        public string name;
        public DateTime startDate;
        public DateTime endDate;

        public MilkCardCompany()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_id, lstAccountSuggestions, "company");
        }

        private void MilkCardCompany_Load(object sender, EventArgs e)
        {
            lstAccountSuggestions.Visible = false;
            dtm_start.Value = startDate;
            dtm_end.Value = endDate;

            if(id!=-1)
            {
                txt_companyName.Text = name;
                txt_id.Text = id.ToString();
                
                legersClass.getCompanyMilkCard(id, dtm_start.Value.Date, dtm_end.Value.Date, out decimal grossLtrs,
                    out decimal tsLtrs, out decimal totalAmount, dataGridView1);

                txt_volume.Text = grossLtrs.ToString();
                txt_tsVolume.Text = tsLtrs.ToString();
                txt_amount.Text= totalAmount.ToString();
                
            }
            

            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_id, txt_companyName, lstAccountSuggestions, e);

            if(e.KeyCode == Keys.Enter)
            {
                lstAccountSuggestions.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_id.Text,out int id))
            {
                return;
            }

            legersClass.getCompanyMilkCard(id, dtm_start.Value.Date, dtm_end.Value.Date, out decimal grossLtrs,
                        out decimal tsLtrs, out decimal totalAmount, dataGridView1);

            txt_volume.Text = grossLtrs.ToString();
            txt_tsVolume.Text = tsLtrs.ToString();
            txt_amount.Text = totalAmount.ToString();
        }
    }
}
