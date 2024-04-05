using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void GetPurchaseReport(DataGridView dataGridView, DateTime startDate, DateTime endDate, 
            int dodhiId, string time, out decimal Volume, out decimal tAmount)
        {
            DataTable purchaseReport = new DataTable();

            purchaseReport.Columns.Add("Purchase Id");
            purchaseReport.Columns.Add("Date");
            purchaseReport.Columns.Add("Customer Id");
            purchaseReport.Columns.Add("Customer Name");
            purchaseReport.Columns.Add("Dodhi Name");
            purchaseReport.Columns.Add("Time");
            purchaseReport.Columns.Add("Volume");
            purchaseReport.Columns.Add("Amount");
            

            Volume = 0;
            tAmount = 0;
            string condition = "";

            if(dodhiId!=-1 && time=="")
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId";
            }
            else if(time!="" && dodhiId==-1)
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND time=@time";
            }
            else if(dodhiId != -1 && time != "")
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId AND time=@time";
            }
            else
            {
                condition = "WHERE date>=@startDate AND date<=@endDate";
            }

            try
            {
                dbConnection.openConnection();

                string purchaseReportQuery = $"SELECT purchaseId, date, customerID, customerName, dodhi, time, liters, amount FROM Purchases {condition}";

                using (SqlCommand command = new SqlCommand(purchaseReportQuery, dbConnection.connection))
                {
                    if (dodhiId != -1 && time == "")
                    {
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    else if (time != "" && dodhiId == -1)
                    {
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    else if (dodhiId != -1 && time != "")
                    {
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }


                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            int purchaseId = int.Parse(reader["purchaseId"].ToString());
                            int customerId = int.Parse(reader["customerId"].ToString());
                            string customerName = reader["customerName"].ToString();
                            string dodhi = reader["dodhi"].ToString();
                            string cTime = reader["time"].ToString();
                            decimal liters = decimal.Parse(reader["liters"].ToString());
                            decimal amount = decimal.Parse(reader["amount"].ToString());


                            Volume += liters;
                            tAmount += amount;

                            purchaseReport.Rows.Add(purchaseId, date, customerId, customerName, dodhi, cTime, liters, amount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating purchase report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = purchaseReport;

            dataGridView.Columns["Purchase Id"].Width = 70;
            dataGridView.Columns["Date"].Width = 70;
            dataGridView.Columns["Customer Id"].Width = 75;
            dataGridView.Columns["customer Name"].Width = 150;
            dataGridView.Columns["Dodhi Name"].Width = 120;
            dataGridView.Columns["Time"].Width = 70;
            dataGridView.Columns["Volume"].Width = 80;
            dataGridView.Columns["Amount"].Width = 120;
        }
    }
}
