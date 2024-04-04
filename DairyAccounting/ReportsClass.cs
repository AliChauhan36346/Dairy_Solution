using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class ReportsClass
    {
        Connection dbConnection;

        public ReportsClass()
        {
            dbConnection = new Connection();
        }

        public void GetSalesReport(DataGridView dataGridView, DateTime startDate, DateTime endDate, 
            out decimal Volume, out decimal tsVolume, out decimal tAmount)
        {
            DataTable salesReport=new DataTable();

            salesReport.Columns.Add("Sales Id");
            salesReport.Columns.Add("Date");
            salesReport.Columns.Add("Company Id");
            salesReport.Columns.Add("Company Name");
            salesReport.Columns.Add("Volume");
            salesReport.Columns.Add("Lr");
            salesReport.Columns.Add("Fat");
            salesReport.Columns.Add("Ts Volume");
            salesReport.Columns.Add("Amount");

            Volume = 0;
            tsVolume = 0;
            tAmount = 0;

            try
            {
                dbConnection.openConnection();

                string salesReportQuery = "SELECT salesId, date, companyId, company, liters, lr, fat, " +
                    "tsLiters, amount FROM Sales WHERE date>=@startDate AND date<=@endDate";

                using (SqlCommand command = new SqlCommand(salesReportQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            int salesId = int.Parse(reader["salesId"].ToString());
                            int companyId = int.Parse(reader["companyId"].ToString());
                            string companyName = reader["company"].ToString();
                            decimal liters = decimal.Parse(reader["liters"].ToString());
                            decimal lr = decimal.Parse(reader["lr"].ToString());
                            decimal fat = decimal.Parse(reader["fat"].ToString());
                            decimal tsLiters = decimal.Parse(reader["tsLiters"].ToString());
                            decimal amount= decimal.Parse(reader["amount"].ToString());


                            Volume += liters;
                            tsVolume += tsLiters;
                            tAmount += amount;

                            salesReport.Rows.Add(salesId,date,companyId,companyName, liters, lr, fat, tsVolume, amount);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error creating sales report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = salesReport;

            dataGridView.Columns["Sales Id"].Width = 70;
            dataGridView.Columns["Date"].Width = 75;
            dataGridView.Columns["Company Id"].Width = 85;
            dataGridView.Columns["Company Name"].Width = 150;
            dataGridView.Columns["Volume"].Width = 90;
            dataGridView.Columns["Lr"].Width = 60;
            dataGridView.Columns["Fat"].Width = 60;
            dataGridView.Columns["Ts Volume"].Width = 90;
            dataGridView.Columns["Amount"].Width = 110;
        }
    }
}
