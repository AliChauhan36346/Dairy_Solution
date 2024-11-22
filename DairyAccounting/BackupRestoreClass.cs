using System;
using System.Data.SqlClient;
using System.IO;
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



        public bool BackupDatabaseFiles()
        {
            try
            {
                // Temporarily close the database connection to release the files
                dbConnection.closeConnection(); // Ensure this properly closes all connections

                // Show FolderBrowserDialog to select the folder
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select a folder to save the database backup";

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the selected folder path
                        string selectedPath = folderBrowserDialog.SelectedPath;

                        // Create a new subfolder for each backup with date and time in the name
                        string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                        string backupFolderPath = Path.Combine(selectedPath, $"dairyBackup-{timestamp}");

                        // Ensure the backup folder is created
                        Directory.CreateDirectory(backupFolderPath);

                        // Define paths for the source database files
                        string sourceMdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DairyManagmentDataBase.mdf");
                        string sourceLdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DairyManagmentDataBase_log.ldf");

                        // Define paths for the backup files in the new folder
                        string destMdfPath = Path.Combine(backupFolderPath, $"DairyManagmentDataBase_{timestamp}.mdf");
                        string destLdfPath = Path.Combine(backupFolderPath, $"DairyManagmentDataBase_log_{timestamp}.ldf");

                        // Copy the .mdf and .ldf files to the backup folder
                        File.Copy(sourceMdfPath, destMdfPath, true);
                        File.Copy(sourceLdfPath, destLdfPath, true);

                        MessageBox.Show($"Database files backed up successfully at: {backupFolderPath}", "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Backup canceled by the user.", "Backup Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during file backup: " + ex.Message);
                return false;
            }
            finally
            {
                // Reopen the connection after the backup
                dbConnection.openConnection();
            }
        }

        public bool BackupDatabase(string backupFolderPath)
        {
            try
            {
                // Get the timestamped backup file name
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string backupFileName = $"dairyBackup-{timestamp}.bak";
                string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

                // SQL command to perform the backup
                string backupCommandText = $"BACKUP DATABASE [DairyManagmentDataBase] TO DISK = '{backupFilePath}' WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                // Open the connection

                dbConnection.openConnection();

                // Execute the backup command
                using (SqlCommand command = new SqlCommand(backupCommandText, dbConnection.connection))
                {
                    command.ExecuteNonQuery();
                }
                

                MessageBox.Show("Backup completed successfully at: " + backupFilePath, "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during backup: " + ex.Message, "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
