using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class BackupRestoreClass
    {
        private readonly string hardcodedDatabaseName = "DairyManagmentDataBase"; // Hardcoded database name without the .mdf extension
        Connection dbConnection;

        public BackupRestoreClass()
        {
            dbConnection = new Connection();
        }

        

        


        public void BackupDatabase(string backupPath)
        {
            if (string.IsNullOrEmpty(backupPath))
            {
                MessageBox.Show("Backup path is not specified.", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbConnection.openConnection();

                string dbName = dbConnection.DatabaseName;
                string backupQuery = @"BACKUP DATABASE DairyManagmentDatabase TO DISK = 'C:\my_db_backup.bak'";

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
            if (string.IsNullOrEmpty(backupPath))
            {
                MessageBox.Show("Backup path is not specified.", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dbConnection.openConnection();

                // Use the hardcoded database name
                string restoreQuery = $@"
                    USE master; 
                    ALTER DATABASE [{hardcodedDatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; 
                    RESTORE DATABASE [{hardcodedDatabaseName}] FROM DISK = '{backupPath}' WITH REPLACE; 
                    ALTER DATABASE [{hardcodedDatabaseName}] SET MULTI_USER;";

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
