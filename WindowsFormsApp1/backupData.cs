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
            BackupRestoreClass backupRestoreClass = new BackupRestoreClass();
            backupRestoreClass.BackupDatabase(@"D:\");
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
