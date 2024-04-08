using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class BackupRestoreClass
    {
        Connection dbConnection;
        
        public BackupRestoreClass()
        {
            dbConnection = new Connection();
        }


        public void BackupDatabase(string backupPath)
        {
            try
            {
                dbConnection.openConnection();

                string backupQuery = $"BACKUP DATABASE [{dbConnection.DatabaseName}] TO DISK = '{backupPath}'";

                using (SqlCommand command = new SqlCommand(backupQuery, dbConnection.connection))
                {
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred during backup: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void RestoreDatabase(string backupPath)
        {
            try
            {

                dbConnection.openConnection();

                string restoreQuery = $"USE master; ALTER DATABASE [{dbConnection.DatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [{dbConnection.DatabaseName}] FROM DISK = '{backupPath}' WITH REPLACE; ALTER DATABASE [{dbConnection.DatabaseName}] SET MULTI_USER;";

                using (SqlCommand command = new SqlCommand(restoreQuery, dbConnection.connection))
                {
                    command.ExecuteNonQuery();
                }


                MessageBox.Show("Restore completed successfully.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred during restore: {ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }



    }
}
