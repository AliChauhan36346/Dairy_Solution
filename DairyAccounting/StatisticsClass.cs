using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class StatisticsClass
    {
        Connection dbConnection;

        public StatisticsClass()
        {
            dbConnection=new Connection();
        }

        public decimal AverageRate(bool isCustomer)
        {
            decimal averageRate = 0;

            string tableName = "";

            if (isCustomer)
            {
                tableName = "Purchases";
            }
            else
            {
                tableName = "Sales";
            }

            try
            {
                dbConnection.openConnection();

                string query = $"SELECT SUM(amount) AS totalAmount, SUM(liters) AS totalLiters FROM {tableName}";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal totalAmount = 1;
                        decimal totalLiters = 1;
                        // Check if the totalAmount column is not null and retrieve its value
                        if (!reader.IsDBNull(reader.GetOrdinal("totalAmount")))
                        {
                            totalAmount = reader.GetDecimal(reader.GetOrdinal("totalAmount"));
                            // Use totalAmount as needed
                        }

                        // Check if the totalLiters column is not null and retrieve its value
                        if (!reader.IsDBNull(reader.GetOrdinal("totalLiters")))
                        {
                            totalLiters = reader.GetDecimal(reader.GetOrdinal("totalLiters"));
                            // Use totalLiters as needed
                        }

                        averageRate = totalAmount / totalLiters;
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating average rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return averageRate;
        }


        public decimal AverageRateCompany(DateTime startDate, DateTime endDate)
        {
            decimal averageRate = 0;

            try
            {
                dbConnection.openConnection();

                string query = $"SELECT SUM(amount) AS totalAmount, SUM(liters) AS totalLiters FROM Sales WHERE date>=@startDate AND date<=@endDate";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal totalAmount = 0;
                        decimal totalLiters = 0;
                        // Check if the totalAmount column is not null and retrieve its value
                        if (!reader.IsDBNull(reader.GetOrdinal("totalAmount")))
                        {
                            //totalAmount = Convert.ToDecimal(reader.GetDouble(reader.GetOrdinal("totalAmount")));
                            totalAmount = int.Parse(reader["totalAmount"].ToString());
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("totalLiters")))
                        {
                            //totalLiters = Convert.ToDecimal(reader.GetDouble(reader.GetOrdinal("totalLiters")));
                            totalLiters = int.Parse(reader["totalLiters"].ToString());
                        }

                        averageRate = totalAmount / totalLiters;
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating average company rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return averageRate;
        }


        public decimal AverageRateCompanyGrossLtrs(DateTime startDate, DateTime endDate)
        {
            decimal averageRate = 0;

            try
            {
                dbConnection.openConnection();

                string query = $"SELECT SUM(rate * liters) AS totalAmount, SUM(liters) AS totalLiters FROM Sales WHERE date >= @startDate AND date <= @endDate";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal totalAmount = 0;
                        decimal totalLiters = 0;
                        // Check if the totalAmount column is not null and retrieve its value
                        if (!reader.IsDBNull(reader.GetOrdinal("totalAmount")))
                        {
                            //totalAmount = Convert.ToDecimal(reader.GetDouble(reader.GetOrdinal("totalAmount")));
                            totalAmount = decimal.Parse(reader["totalAmount"].ToString());
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("totalLiters")))
                        {
                            //totalLiters = Convert.ToDecimal(reader.GetDouble(reader.GetOrdinal("totalLiters")));
                            totalLiters = int.Parse(reader["totalLiters"].ToString());
                        }

                        averageRate = totalAmount / totalLiters;
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating average company rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return averageRate;
        }
    }
}
