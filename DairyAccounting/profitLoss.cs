using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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


        // calculates profit loss for one day

        public void oneDayProfitLoss(DateTime date, out decimal totalPurchase, out decimal purchaseAmount, 
            out decimal totalExpense, out decimal totalSale, out decimal salesAmount, out decimal profitLoss)
        {
            totalPurchase = 0;
            purchaseAmount = 0;
            totalExpense = 0;
            totalSale = 0;
            salesAmount = 0;
            profitLoss = 0;


            totalPurchases(date, date, out totalPurchase, out purchaseAmount);
            totalExpenses(date, date, out totalExpense);
            totalSales(date, date, out totalSale, out salesAmount);

            profitLoss = salesAmount - (purchaseAmount + totalExpense);
        }

        // Gives profit loss for the selected period
        public void profitLossInRow(DateTime startDate, DateTime endDate, DataGridView dataGridView ,out decimal GtotalPurchase, out decimal GpurchaseAmount,
            out decimal GtotalExpense, out decimal GtotalSale, out decimal GsaleAmount, out decimal GprofitLoss)
        {

            GtotalPurchase = 0;
            GpurchaseAmount = 0;
            GtotalExpense = 0;
            GtotalSale = 0;
            GsaleAmount = 0;
            GprofitLoss = 0;


            decimal totalPurchase = 0;
            decimal purchaseAmount = 0;
            decimal totalExpense = 0;
            decimal totalSale = 0;
            decimal saleAmount = 0;
            decimal profitLoss = 0;



            string incomeStatus = "";

            DataTable profitLossTable= new DataTable();

            profitLossTable.Columns.Add("Date");
            profitLossTable.Columns.Add("Total Purchase");
            profitLossTable.Columns.Add("Purchase Amount");
            profitLossTable.Columns.Add("Total Expense");
            profitLossTable.Columns.Add("Total Sales");
            profitLossTable.Columns.Add("Sales Amount");
            profitLossTable.Columns.Add("Profit/Loss");

            
            DateTime date= startDate;



            while(date<=endDate)
            {
                oneDayProfitLoss(date, out totalPurchase, out purchaseAmount, out totalExpense, out totalSale, out saleAmount, out profitLoss);

                incomeStatus = profitLoss > 0 ? "Profit" : "Loss";

                profitLossTable.Rows.Add(date.ToString("dd/MM/yyyy"), totalPurchase, purchaseAmount, totalExpense, totalSale, saleAmount, profitLoss + " " + incomeStatus);

                GtotalPurchase += totalPurchase;
                GpurchaseAmount += purchaseAmount;
                GtotalExpense += totalExpense;
                GtotalSale += totalSale;
                GsaleAmount += saleAmount;
                GprofitLoss += profitLoss;

                totalPurchase = 0;
                purchaseAmount = 0;
                totalExpense = 0;
                totalSale = 0;
                saleAmount = 0;
                profitLoss = 0;

                date =date.AddDays(1);
            }

            dataGridView.DataSource= profitLossTable;

            dataGridView.Columns["Date"].Width = 100;
            dataGridView.Columns["Total Purchase"].Width = 120;
            dataGridView.Columns["Purchase Amount"].Width = 120;
            dataGridView.Columns["Total Expense"].Width = 120;
            dataGridView.Columns["Total Sales"].Width = 120;
            dataGridView.Columns["Sales Amount"].Width = 120;
            dataGridView.Columns["Profit/Loss"].Width = 190;

            // Set column colors
            // set the headers colors
            dataGridView.Columns["Date"].HeaderCell.Style.BackColor = Color.LightBlue;           
            dataGridView.Columns["Total Purchase"].HeaderCell.Style.BackColor = Color.LightBlue;
            dataGridView.Columns["Purchase Amount"].HeaderCell.Style.BackColor = Color.LightBlue;
            dataGridView.Columns["Total Expense"].HeaderCell.Style.BackColor = Color.LightBlue;
            dataGridView.Columns["Total Sales"].HeaderCell.Style.BackColor = Color.LightBlue;
            dataGridView.Columns["Sales Amount"].HeaderCell.Style.BackColor = Color.LightBlue;
            dataGridView.Columns["Profit/Loss"].HeaderCell.Style.BackColor = Color.LightBlue;
            //dataGridView.Columns["Profit/Loss"].DefaultCellStyle.ForeColor = Color.Black;

            dataGridView.EnableHeadersVisualStyles = false;


        }
        

    }
}
