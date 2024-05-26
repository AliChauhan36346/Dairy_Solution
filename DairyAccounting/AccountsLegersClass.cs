using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class AccountsLegersClass
    {
        Connection dbConnection;

        public AccountsLegersClass()
        {
            dbConnection = new Connection();
        }



        // Method to retrieve IDs and names for all account types

        public void GetCustomerLedger(DataGridView dataGridView, int id, DateTime fromDate, DateTime toDate, out decimal totalDebit, out decimal totalCredit, out decimal totalBalance, out string bStatus, out decimal balanceBroughtForward, out string forwardString)
        {
            DataTable ledgerTable = new DataTable();
            ledgerTable.Columns.Add("Date");
            ledgerTable.Columns.Add("Tran.No");
            ledgerTable.Columns.Add("Description");
            ledgerTable.Columns.Add("Debit");
            ledgerTable.Columns.Add("Credit");
            ledgerTable.Columns.Add("Balance");
            ledgerTable.Columns.Add("Status");



            decimal runningBalance = 0;
            totalBalance = 0;
            totalDebit = 0;
            totalCredit = 0;
            balanceBroughtForward = 0;
            forwardString = "";

            bStatus = "";

            try
            {
                dbConnection.openConnection();

                // Calculate balance brought forward
                string queryBalance = @"
                    SELECT ISNULL(SUM(debit), 0) AS debitSum, ISNULL(SUM(credit), 0) AS creditSum
                    FROM (
                    SELECT 0 AS debit, amount AS credit
                    FROM Purchases 
                    WHERE customerID = @id AND date < @fromDate

                    UNION ALL

                    SELECT debit AS debit, credit AS credit FROM OpeningBalances WHERE accountId=@id

                    UNION ALL

                    SELECT debit AS debit, credit AS credit FROM JournalVoucher WHERE accountId=@id AND date<@fromDate

                    UNION ALL

                    SELECT 0 AS debit, amountReceived AS credit
                    FROM Sales 
                    WHERE (companyId = @id OR accountId=@Id) AND date < @fromDate
                    AND amountReceived <> 0

                    UNION ALL

                    SELECT amount AS debit, 0 AS credit
                    FROM Sales 
                    WHERE (companyId = @id OR accountId=@Id) AND date < @fromDate

                    UNION ALL

                    SELECT 0 AS debit, amount AS credit
                    FROM Receipts 
                    WHERE (accountId = @id OR cashAccountId=@Id) AND date < @fromDate

                    UNION ALL

                    SELECT amount AS debit, 0 AS credit
                    FROM Payments 
                    WHERE (accountId = @id OR cashAccountId=@Id) AND date < @fromDate
                    ) AS subquery";

                using (SqlCommand balanceCommand = new SqlCommand(queryBalance, dbConnection.connection))
                {
                    balanceCommand.Parameters.AddWithValue("@id", id);
                    balanceCommand.Parameters.AddWithValue("@fromDate", fromDate);

                    using (SqlDataReader balanceReader = balanceCommand.ExecuteReader())
                    {
                        if (balanceReader.Read())
                        {
                            decimal.TryParse(balanceReader["creditSum"].ToString(), out balanceBroughtForward);
                            balanceBroughtForward -= decimal.Parse(balanceReader["debitSum"].ToString());
                        }
                    }
                }

                runningBalance += balanceBroughtForward;
                if (balanceBroughtForward > 0)
                {
                    forwardString = "Credit";
                }
                else
                {
                    forwardString = "Debit";
                }


                string query = @"
                SELECT date, 'PV' + CAST(purchaseID AS NVARCHAR(50)) AS transactionNo, 
                CAST(liters AS NVARCHAR(50)) + ' ltrs @' + CAST(rate AS NVARCHAR(50)) + ' = ' + CAST(amount AS NVARCHAR(50)) AS description, 
                NULL AS debit, 
                amount AS credit
                FROM Purchases 
                WHERE customerID = @id AND date >= @fromDate AND date <= @toDate

                UNION ALL

                SELECT date, 'JV' + CAST(journalId AS NVARCHAR(50)) AS transactionNo, discription AS discription, debit AS debit, credit AS credit FROM JournalVoucher
                WHERE accountId=@id AND date>=@fromDate AND date<=@toDate

                UNION ALL

                SELECT date, 'SV' + CAST(salesId AS NVARCHAR(50)) AS transactionNo,
                       'Cash received during sales' AS description,
                       NULL AS debit,
                       CAST(amountReceived AS NVARCHAR(50)) AS credit
                FROM Sales 
                WHERE (companyId = @id OR accountId=@id) AND date >= @fromDate AND date <= @toDate 
                AND amountReceived <> 0 

                UNION ALL

                SELECT date, 'SV' + CAST(salesId AS NVARCHAR(50)) AS transactionNo,
                       CAST(lr AS NVARCHAR(50)) + 'lr ' + CAST(fat AS NVARCHAR(50)) + 'fat ' + ' = Ts: ' + CAST(tsLiters AS NVARCHAR(50)) + 'ltrs @Rs.' + CAST(rate AS NVARCHAR(50)) + ' = Rs.' + CAST(amount AS NVARCHAR(50)) AS description,
                       CAST(amount AS NVARCHAR(50)) AS debit,
                       NULL AS credit
                FROM Sales 
                WHERE companyId = @id AND date >= @fromDate AND date <= @toDate 

                UNION ALL

                SELECT date, 'CRV' + CAST(receiptId AS NVARCHAR(50)) AS transactionNo, 
                       discription AS description, 
                       NULL AS debit, 
                       amount AS credit
                FROM Receipts 
                WHERE (accountId = @id OR cashAccountId=@id) AND date >= @fromDate AND date <= @toDate 

                UNION ALL

                SELECT date, 'CPV' + CAST(PaymentId AS NVARCHAR(50)) AS transactionNo, 
                       discription AS description, 
                       amount AS debit, 
                       NULL AS credit
                FROM Payments 
                WHERE (accountId = @id OR cashAccountId=@id) AND date >= @fromDate AND date <= @toDate

                ORDER BY date";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yy"); // Change the format as needed
                            string transactionNo = reader["transactionNo"].ToString();
                            string description = reader["description"].ToString();
                            string debit = reader["debit"].ToString();
                            string credit = reader["credit"].ToString();
                            decimal transactionDebit = string.IsNullOrEmpty(debit) ? 0 : decimal.Parse(debit);
                            decimal transactionCredit = string.IsNullOrEmpty(credit) ? 0 : decimal.Parse(credit);

                            // Update running balance
                            runningBalance += transactionCredit - transactionDebit;

                            // Set status based on balance
                            string status = runningBalance >= 0 ? "credit" : "debit";

                            bStatus = status;


                            runningBalance = Math.Round(runningBalance, 1);


                            // Add row to ledger table
                            ledgerTable.Rows.Add(date, transactionNo, description, debit, credit, Math.Abs(runningBalance), status);

                            // Update total debit and credit
                            totalDebit += transactionDebit;
                            totalCredit += transactionCredit;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving account ledger: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            // Update the UI
            totalBalance = Math.Abs(runningBalance);

            dataGridView.DataSource = ledgerTable;


            dataGridView.Columns["Date"].Width = 85;
            dataGridView.Columns["Tran.No"].Width = 80;
            dataGridView.Columns["Description"].Width = 330;
            dataGridView.Columns["Debit"].Width = 90;
            dataGridView.Columns["Credit"].Width = 90;
            dataGridView.Columns["Balance"].Width = 100;
            dataGridView.Columns["Status"].Width = 80;
        }







        public void GetCustomerMilkCard(int id, DateTime startDate, DateTime endDate,
            out decimal morningTotal, out decimal eveningTotal, out decimal milkTotal,
            out decimal totalMilkAmount, DataGridView dataGridView)
        {
            morningTotal = 0;
            eveningTotal = 0;
            milkTotal = 0;
            totalMilkAmount = 0;

            DataTable milkCard = new DataTable();

            milkCard.Columns.Add("Date");
            milkCard.Columns.Add("Morning");
            milkCard.Columns.Add("Evening");
            milkCard.Columns.Add("Total");
            milkCard.Columns.Add("Rate");
            milkCard.Columns.Add("Amount");

            try
            {
                dbConnection.openConnection();

                string query = "SELECT date, time, liters, amount, rate FROM Purchases WHERE " +
                    "customerID=@customerId AND date>=@startDate AND date<=@endDate ORDER BY date";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", id);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            string time = reader["time"].ToString().Trim();
                            decimal liters = decimal.Parse(reader["liters"].ToString());
                            decimal rate = decimal.Parse(reader["rate"].ToString());
                            decimal amount = decimal.Parse(reader["amount"].ToString());

                            if(time=="Morning")
                            {
                                morningTotal += liters;
                                milkTotal += liters;
                                totalMilkAmount += amount;

                                milkCard.Rows.Add(date, liters, "", milkTotal, rate, amount);
                            }
                            else
                            {
                                eveningTotal += liters;
                                milkTotal += liters;
                                totalMilkAmount += amount;

                                milkCard.Rows.Add(date, "", liters, milkTotal, rate, amount);
                            }
                            
                        }
                    }
                }

                dataGridView.DataSource = milkCard;

                dataGridView.Columns["Date"].Width = 100;
                dataGridView.Columns["Morning"].Width = 85;
                dataGridView.Columns["Evening"].Width = 85;
                dataGridView.Columns["Total"].Width = 90;
                dataGridView.Columns["Rate"].Width = 80;
                dataGridView.Columns["Amount"].Width = 100;
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("Error retrieving milk card data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


        public void getCompanyMilkCard(int id, DateTime startDate, DateTime endDate, out decimal grossLtrs,
            out decimal tsLtrs, out decimal totalAmount, DataGridView dataGridView)
        {
            grossLtrs = 0;
            tsLtrs = 0;
            totalAmount = 0;

            DataTable milkCard = new DataTable();

            milkCard.Columns.Add("Date");
            milkCard.Columns.Add("Volume");
            milkCard.Columns.Add("Fat%");
            milkCard.Columns.Add("LR");
            milkCard.Columns.Add("Ts Volume");
            milkCard.Columns.Add("Rate");
            milkCard.Columns.Add("Amount");

            try
            {
                dbConnection.openConnection();

                string query = "SELECT date, liters, lr, fat, tsLiters, rate, amount FROM Sales WHERE companyId=@id AND date>=@startDate AND date<=@endDate ORDER BY date";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                        decimal volume = decimal.Parse(reader["liters"].ToString());
                        decimal fat = decimal.Parse(reader["fat"].ToString());
                        decimal lr = decimal.Parse(reader["lr"].ToString());
                        decimal tsVolume = decimal.Parse(reader["tsLiters"].ToString());
                        decimal rate = decimal.Parse(reader["rate"].ToString());
                        decimal amount = decimal.Parse(reader["amount"].ToString());

                        milkCard.Rows.Add(date, volume, fat, lr, tsVolume, rate, amount);

                        grossLtrs += volume;
                        tsLtrs += tsVolume;
                        totalAmount += amount;

                    }
                }

                dataGridView.DataSource = milkCard;

                dataGridView.Columns["Date"].Width = 90;
                dataGridView.Columns["Volume"].Width = 100;
                dataGridView.Columns["Fat%"].Width = 70;
                dataGridView.Columns["LR"].Width = 70;
                dataGridView.Columns["Ts Volume"].Width = 100;
                dataGridView.Columns["Rate"].Width = 80;
                dataGridView.Columns["Amount"].Width = 100;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving company milk card data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


    }
}
