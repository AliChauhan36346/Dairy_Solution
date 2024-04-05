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
    public partial class TsCalculator : Form
    {
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();

        public TsCalculator()
        {
            InitializeComponent();
        }

        private void TsCalculator_Load(object sender, EventArgs e)
        {
            txt_tsStandard.Text = "13";
        }

        private void txt_tsLiters_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculatTs_Click(object sender, EventArgs e)
        {
            decimal grossliters;
            decimal tsLiters;
            int ts;
            decimal lr;
            decimal fat;


            if(!decimal.TryParse(txt_liters.Text, out grossliters))
            {
                return;
            }
            if(!int.TryParse(txt_tsStandard.Text, out ts))
            {
                return;
            }
            if(!decimal.TryParse(txt_lr.Text, out lr))
            {
                return;
            }
            if(!decimal.TryParse(txt_fat.Text, out fat))
            {

                return;
            }

            tsLiters = commonFunctions.tsCalculator(lr, fat, grossliters, ts);

            tsLiters=Math.Round(tsLiters, 2);

            txt_tsLiters.Text=tsLiters.ToString();
        }
    }
}
