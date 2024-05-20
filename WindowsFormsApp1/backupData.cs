using DairyAccounting;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class backupData : Form
    {
        BackupRestoreClass backupRestore=new BackupRestoreClass();

        public backupData()
        {
            InitializeComponent();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            backupRestore.BackupDatabase("alsdja");

            /*SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Backup files (*.bak)|*.bak",
                FileName = "dairyDatabase_backup_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedBackupPath = saveFileDialog.FileName;

                BackupRestoreClass backupRestoreClass = new BackupRestoreClass();
                backupRestoreClass.BackupDatabase(selectedBackupPath);
            }*/
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Backup files (*.bak)|*.bak"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedBackupPath = openFileDialog.FileName;

                BackupRestoreClass backupRestoreClass = new BackupRestoreClass();
                backupRestoreClass.RestoreDatabase(selectedBackupPath);
            }
        }
    }
}
