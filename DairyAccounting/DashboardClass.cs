using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DairyAccounting
{
    public class DashboardClass
    {
        Connection dbConnection;

        public DashboardClass()
        {
            dbConnection = new Connection();
        }

        public void getAverageLrFat(out string grossReceive,out string avgLr, out string avgFat, DateTime startDate, DateTime endDate)
        {
            avgLr = "";
            avgFat = "";
            grossReceive = "";

            DateTime yesterday= startDate.AddDays(-1);
            try
            {
                dbConnection.openConnection();

                string query = "SELECT AVG(lr), AVG(fat), SUM(grossLiters) FROM ChilarReceive WHERE (date=@yesterday AND time='Evening') OR (date>=@startDate AND date<=@endDate AND time='Morning')";

                using(SqlCommand command=new SqlCommand(query,dbConnection.connection))
                {

                    command.Parameters.AddWithValue("@yesterday", yesterday);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);


                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if(!reader.IsDBNull(0))
                            {
                                avgLr = reader.GetDecimal(0).ToString();
                                avgFat = reader.GetDecimal(1).ToString();
                                grossReceive = reader.GetValue(2).ToString();
                            }
                            else
                            {
                                avgFat = "0";
                                avgLr = "0";
                                grossReceive = "0";
                            }
                           
                        }
                        else
                        {
                            avgFat = "0";
                            avgLr = "0";
                            grossReceive = "0";
                        }

                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error average lr: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        public void getGrossAndTsSales(out string grossSales, out string tsSales, DateTime startDate, DateTime endDate)
        {
            grossSales = "";
            tsSales = "";
            try
            {
                dbConnection.openConnection();

                string query = "SELECT SUM(liters), SUM(tsLiters) FROM Sales WHERE date>=@startDate AND date<=@endDate";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                grossSales = reader.GetValue(0).ToString();
                                tsSales = reader.GetValue(1).ToString();
                            }
                            else
                            {
                                grossSales = "0";
                                tsSales = "0";
                            }

                        }
                        else
                        {
                            grossSales = "0";
                            tsSales = "0";
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sum gross and ts volume!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getPurchaseVolume(out string purchaseVolume, DateTime startDate, DateTime endDate)
        {
            purchaseVolume = "";

            DateTime yesterday = startDate.AddDays(-1);

            try
            {
                dbConnection.openConnection();

                string query = "SELECT SUM(liters) FROM Purchases WHERE (date=@yesterday AND time='Evening') OR (date>=@startDate AND date<=@endDate AND time='Morning')";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {

                    command.Parameters.AddWithValue("@yesterday", yesterday);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                purchaseVolume = reader.GetValue(0).ToString();
                            }
                            else
                            {
                                purchaseVolume="0";
                            }

                        }
                        else
                        {
                            purchaseVolume = "0";
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sum gross and ts volume!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getAccountOpeningBalance(DateTime beforeDate, out decimal openingAmount)
        {
            openingAmount = 0;

            try
            {
                dbConnection.openConnection();

                string previousBalanceQuery = @"
                SELECT ISNULL(SUM(totalAmount), 0) AS totalAmount
                FROM (
                    SELECT -amount AS totalAmount FROM Payments WHERE date < @beforeDate
                    UNION ALL
                    SELECT amount AS totalAmount FROM Receipts WHERE date < @beforeDate
                    UNION ALL
                    SELECT amountReceived AS totalAmount FROM Sales WHERE date < @beforeDate
                    UNION ALL
                    SELECT -amount AS totalAmount FROM Expense WHERE date < @beforeDate
                ) AS TransactionAmounts
                ";

                using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@beforeDate", beforeDate);

                    openingAmount = Convert.ToDecimal(command.ExecuteScalar());

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error calculating opening balance for cash accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

        }

        public void GetTotalPaymentAmount(DateTime startDate, DateTime endDate, out decimal totalPaymentAmount)
        {
            totalPaymentAmount = 0;

            try
            {
                dbConnection.openConnection();

                string previousBalanceQuery = @"
                SELECT ISNULL(SUM(totalAmount), 0) AS totalAmount
                FROM (
                    SELECT amount AS totalAmount FROM Payments WHERE date>=@startDate AND date<=@endDate
                    UNION ALL
                    SELECT amount AS totalAmount FROM Expense WHERE date>=@startDate AND date<=@endDate
                ) AS CombinedAmounts";

                using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    totalPaymentAmount = Convert.ToDecimal(command.ExecuteScalar());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total payment amount for cash accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


        public void GetTotalReceiptAmount(DateTime startDate, DateTime endDate, out decimal totalReceiptAmount)
        {
            totalReceiptAmount = 0;

            try
            {
                dbConnection.openConnection();

                string previousBalanceQuery = @"
                SELECT ISNULL(SUM(totalAmount), 0) AS totalAmount
                FROM (
                    SELECT amount AS totalAmount FROM Receipts WHERE date>=@startDate AND date<=@endDate
                    UNION ALL
                    SELECT amountReceived AS totalAmount FROM Sales WHERE date>=@startDate AND date<=@endDate
                ) AS CombinedAmounts";

                using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    totalReceiptAmount = Convert.ToDecimal(command.ExecuteScalar());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total receipt amount for cash accounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }



    }
}
