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


        public void GetCustomerLedger(DataGridView dataGridView, int id, DateTime fromDate, DateTime toDate, TextBox txtTotalDebit, TextBox txtTotalCredit, TextBox totalblance, TextBox balanceStatus ,Label balanceForward)
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
            decimal totalDebit = 0;
            decimal totalCredit = 0;
            decimal balanceBroughtForward = 0;
            string bStatus="";

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

                    SELECT 0 AS debit, amountReceived AS credit
                    FROM Sales 
                    WHERE companyId = @id AND date < @fromDate
                    AND amountReceived <> 0

                    UNION ALL

                    SELECT amount AS debit, 0 AS credit
                    FROM Sales 
                    WHERE companyId = @id AND date < @fromDate

                    UNION ALL

                    SELECT 0 AS debit, amount AS credit
                    FROM Receipts 
                    WHERE accountId = @id AND date < @fromDate

                    UNION ALL

                    SELECT amount AS debit, 0 AS credit
                    FROM Payments 
                    WHERE accountId = @id AND date < @fromDate
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
                if( balanceBroughtForward > 0 )
                {
                    balanceForward.Text = "Balance Brought Forward:   " + balanceBroughtForward.ToString() + " Credit";
                }
                else
                {
                    balanceForward.Text = "Balance Brought Forward:   " + balanceBroughtForward.ToString() + " Debit";
                }
                

                string query = @"
                SELECT date, 'PV' + CAST(purchaseID AS NVARCHAR(50)) AS transactionNo, 
                CAST(liters AS NVARCHAR(50)) + ' ltrs @' + CAST(rate AS NVARCHAR(50)) + ' = ' + CAST(amount AS NVARCHAR(50)) AS description, 
                NULL AS debit, 
                amount AS credit
                FROM Purchases 
                WHERE customerID = @id AND date >= @fromDate AND date <= @toDate

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
                            
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy"); // Change the format as needed
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
            decimal totalBalance = Math.Abs(runningBalance);

            dataGridView.DataSource = ledgerTable;
            txtTotalDebit.Text = totalDebit.ToString();
            txtTotalCredit.Text = totalCredit.ToString();
            totalblance.Text = totalBalance.ToString();
            balanceStatus.Text = bStatus.ToString();

            dataGridView.Columns["Date"].Width = 85;
            dataGridView.Columns["Tran.No"].Width = 80;
            dataGridView.Columns["Description"].Width = 330;
            dataGridView.Columns["Debit"].Width = 90;
            dataGridView.Columns["Credit"].Width = 90;
            dataGridView.Columns["Balance"].Width = 100;
            dataGridView.Columns["Status"].Width = 80;
        }

    }
}
