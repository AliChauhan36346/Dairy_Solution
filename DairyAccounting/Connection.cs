﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace DairyAccounting
{
    internal class Connection
    {
        // Connection string for SQL Server database connection
        //private readonly string connectionString = @"Data Source=DESKTOP-6T1BFNC\SQLEXPRESS;Initial Catalog=dairyDataBase;Integrated Security=True";
        private readonly string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename= |DataDirectory|\DairyManagmentDataBase.mdf; Integrated Security = true; Connect Timeout=30");


        // SqlConnection object
        public SqlConnection connection;

        // Constructor for connection class
        public Connection()
        {
            connection = new SqlConnection(connectionString);
        }

        public void openConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening connection with database " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void closeConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing connection with database" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string DatabaseName
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                return Path.GetFileNameWithoutExtension(builder.AttachDBFilename);
            }
        }

    }
}
