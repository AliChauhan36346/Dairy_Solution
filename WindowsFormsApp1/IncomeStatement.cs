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
    public partial class IncomeStatement : Form
    {
        public IncomeStatement()
        {
            InitializeComponent();
        }

        private void IncomeStatement_Load(object sender, EventArgs e)
        {
            dtm_endDate.Enabled = false;
            dtm_startDate.Enabled = false;
            dtm_uptoDate.Enabled = false;
        }

        private void rdo_uptoDate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_uptoDate.Checked)
            {
                dtm_uptoDate.Enabled=true;
            }
            else
            {
                dtm_uptoDate.Enabled=false;
            }
        }

        private void rdo_fromDate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_fromDate.Checked)
            {
                dtm_startDate.Enabled=true;
                dtm_endDate.Enabled = true;
            }
            else
            {
                dtm_endDate.Enabled=false;
                dtm_startDate.Enabled = false;
            }
        }
    }
}
