using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class profitLoss
    {
        Connection dbConnection;

        public profitLoss()
        {
            dbConnection = new Connection();
        }

        public void totalSales(DateTime startDate, DateTime endDate, out decimal totalSale, out decimal saleAmount)
        {
            saleAmount = 0;
            totalSale = 0;

            try
            {
                dbConnection.openConnection();

                string totalSaleQuery = "SELECT tsLiters, amount FROM Sales WHERE date>=@startDate AND date<=@endDate";

                using (SqlCommand command = new SqlCommand(totalSaleQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal liters = decimal.Parse(reader["tsLiters"].ToString());
                            decimal amount = decimal.Parse(reader["amount"].ToString());

                            totalSale += liters;
                            saleAmount += amount;
                        }
                    }
                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show("Error calculating total sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

        }


        public void totalPurchases(DateTime startDate, DateTime endDate, out decimal totalPurchase, out decimal purchaseAmount)
        {
            purchaseAmount = 0;
            totalPurchase = 0;

            try
            {
                dbConnection.openConnection();

                string totalSaleQuery = "SELECT liters, amount FROM Purchases WHERE date>=@startDate AND date<=@endDate";

                using (SqlCommand command = new SqlCommand(totalSaleQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal liters = decimal.Parse(reader["liters"].ToString());
                            decimal amount = decimal.Parse(reader["amount"].ToString());

                            totalPurchase += liters;
                            purchaseAmount += amount;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total purchases: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

        }

        public void totalExpenses(DateTime startDate, DateTime endDate, out decimal totalExpenses)
        {
            totalExpenses= 0;

            try
            {
                dbConnection.openConnection();

                string totalSaleQuery = "SELECT amount FROM Expense WHERE date>=@startDate AND date<=@endDate";

                using (SqlCommand command = new SqlCommand(totalSaleQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal amount = decimal.Parse(reader["amount"].ToString());

                            totalExpenses += amount;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error error calculating total expenses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

        }
    }
}
