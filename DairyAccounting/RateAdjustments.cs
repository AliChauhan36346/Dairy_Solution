using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class RateAdjustments
    {
        Connection dbConnection;

        

        public RateAdjustments()
        {
            dbConnection = new Connection();
        }
        // increment,decriment,new   //filteration like dohdi  //to store accountid,d id etc  //changes   //tell from which table changes will made
        public void adjustRate(string increaseOrDecrease, string filter, int filterIdOrAccountId,string address, decimal rate, int accountBelongsTo)
        {
            string fromTable;
            string whereChange;

            // from which table the changes made
            fromTable = (accountBelongsTo == 0) ? "CustomersTbl" : "CompaniesTbl";

            // for filtration
            switch (filter)
            {
                case "dodhi":
                    whereChange = "WHERE dodhiId=@dodhiId";
                    break;
                case "address":
                    whereChange = "WHERE address LIKE @address";
                    break;
                case "single":
                    whereChange = (accountBelongsTo == 0) ? "WHERE customerId=@customerId" : "WHERE companyId=@companyId";
                    break;
                default:
                    whereChange = "";
                    break;
            }

            try
            {
                dbConnection.openConnection();

                string rateChangeQuery;

                if (increaseOrDecrease == "increment")
                {
                    rateChangeQuery = $"UPDATE {fromTable} SET rate=rate+@RateChange {whereChange}";
                }
                else if (increaseOrDecrease == "decrement")
                {
                    rateChangeQuery = $"UPDATE {fromTable} SET rate=rate-@RateChange {whereChange}";
                }
                else
                {
                    rateChangeQuery = $"UPDATE {fromTable} SET rate=@rateChange {whereChange}";
                }

                using (SqlCommand command = new SqlCommand(rateChangeQuery, dbConnection.connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@RateChange", rate);

                    if (filter == "dodhi")
                    {
                        command.Parameters.AddWithValue("@dodhiId", filterIdOrAccountId);
                    }
                    else if (filter == "address")
                    {
                        command.Parameters.AddWithValue("@address", "%" + filterIdOrAccountId + "%");

                    }
                    else if (filter == "single")
                    {
                        if (accountBelongsTo == 0)
                        {
                            command.Parameters.AddWithValue("@customerId", filterIdOrAccountId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@companyId", filterIdOrAccountId);
                        }
                    }
                    

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Rate updated successfully for the selected accounts.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

    }
}
