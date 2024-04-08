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
    public partial class backupData : Form
    {
        public string selectedBackupPath = "";

        public backupData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Backup files (*.bak)|*.bak"; // Filter for backup files
            saveFileDialog.FileName = "dairyDatabase_backup_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak"; // Default file name with timestamp

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedBackupPath = saveFileDialog.FileName;

                BackupRestoreClass backupRestoreClass = new BackupRestoreClass();
                backupRestoreClass.BackupDatabase(selectedBackupPath);
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Backup files (*.bak)|*.bak"; // Filter for backup files
            saveFileDialog.FileName = "dairyDatabase_backup_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak"; // Default file name with timestamp

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedBackupPath = saveFileDialog.FileName;

                BackupRestoreClass backupRestoreClass = new BackupRestoreClass();
                backupRestoreClass.RestoreDatabase(selectedBackupPath);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
