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
    public partial class Password : Form
    {
        public string enteredPassword { get; private set; }

        public Password()
        {
            InitializeComponent();
        }

        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            enteredPassword=txt_password.Text.Trim();
            DialogResult= DialogResult.OK;
            Close();
        }

        public bool IsPasswordCorrect(string enteredPassword)
        {
            // Check if the entered password matches the stored password
            string correctPassword = "9877890"; // Replace with your actual password
            return enteredPassword == correctPassword;
        }
    }
}
