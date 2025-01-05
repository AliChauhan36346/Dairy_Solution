using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DairyAccounting
{
    public class ParchiClass
    {
        Connection dbConnection;
        AddCustomers customers=new AddCustomers();
        AddCompanies company=new AddCompanies();
        private List<(int customerId, decimal creditLimit)> customerIdCreditLimit;

        public decimal PreviousBalance { get; set; } = 0;
        public string BalanceStatus { get; set; } = "";
        public decimal TotalMilk { get; set; } = 0;
        public decimal MilkAmount { get; set; } = 0;
        public decimal ParchiAmount { get; set; } = 0;
        public decimal Balance { get; set; } = 0;
        public string BStatus { get; set; } = "";
        public decimal FinalBalance { get; set; } = 0;
        public string FinalStatus { get; set; } = "";
        public int creditLimit { get; set; } = 0;
        public decimal advancePayment { get; set; } = 0;
        


        public ParchiClass()
        {
            dbConnection = new Connection();
            customerIdCreditLimit = customers.GetAllCustomerIdCreditLimit(); // Preload customer id and credit limit
        }

        // to get all customers and their dodhi ids for comparison
        public Dictionary<int, int> GetCustomerAndDodhiID()
        {
            Dictionary<int, int> customerAndDodhiID = new Dictionary<int, int>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT customerId, dodhiId FROM CustomersTbl";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerId = Convert.ToInt32(reader["customerId"]);
                            int dodhiId = Convert.ToInt32(reader["dodhiId"]);
                            customerAndDodhiID.Add(customerId, dodhiId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return customerAndDodhiID;
        }




        //public void getCustomersParchi(out decimal grandTotalLiters, out decimal grandTotalMilkAmount,
        //    out decimal grandTotalParchiAmount, int dodhiId, int singleCustomerId,
        //    DateTime startDate, DateTime endDate, DataGridView dataGridView)
        //{
        //    DataTable parchiTable = new DataTable();
        //    parchiTable.Columns.Add("Id");
        //    parchiTable.Columns.Add("Customer Name");
        //    parchiTable.Columns.Add("Previous Balance");
        //    parchiTable.Columns.Add("pStatus");
        //    parchiTable.Columns.Add("Total Liters");
        //    parchiTable.Columns.Add("Milk Amount");
        //    parchiTable.Columns.Add("Parchi Amount");
        //    parchiTable.Columns.Add("Closing Balance");
        //    parchiTable.Columns.Add("Status");

        //    decimal previousBalance;
        //    string previousStatus;// for previous balance status
        //    decimal totalLiters; // to get total liters of a specific customer
        //    decimal milkAmount; // to get milk amount of a customer
        //    decimal parchiAmount; // to store total parchi amount of cusotmer
        //    decimal Balance;
        //    string BStatus; // for closing balance status
        //    string customerName; // to store customerName

        //    // for grand total of the above values
        //    grandTotalLiters = 0;
        //    grandTotalMilkAmount = 0;
        //    grandTotalParchiAmount = 0;

        //    try
        //    {
        //        dbConnection.openConnection();

        //        Dictionary<int,int> customerAndDodhiID= new Dictionary<int,int>();

        //        customerAndDodhiID = GetCustomerAndDodhiID();

        //        // to get parchi of all customer ralated to a single dodhi
        //        if(dodhiId!=-1)
        //        {
        //            foreach (var item in customerAndDodhiID)
        //            {
        //                int customerId = item.Key;
        //                int customerDodhiId = item.Value;

        //                if (customerDodhiId == dodhiId)
        //                {
        //                    customerName = customers.GetCustomerNameById(customerId);

        //                    // caling parchi function to generate parchi of the provide customer
        //                    getParchi(out previousBalance, out previousStatus, out totalLiters,
        //                    out milkAmount, out parchiAmount, out Balance, out BStatus,
        //                    customerId, startDate.Date, endDate.Date);

        //                    // adding a row to the table as the new customer will come every time
        //                    parchiTable.Rows.Add(customerId, customerName, previousBalance, previousStatus,
        //                        totalLiters, milkAmount, parchiAmount, Balance, BStatus);


        //                    grandTotalLiters += totalLiters;
        //                    grandTotalMilkAmount += milkAmount;
        //                    grandTotalParchiAmount += parchiAmount;

        //                    previousBalance = 0;
        //                    previousStatus = "";
        //                    totalLiters = 0;
        //                    milkAmount = 0;
        //                    parchiAmount = 0;
        //                    Balance = 0;
        //                    BStatus = "";
        //                    customerName = "";
        //                }
        //            }
        //        }

        //        // to get only the searched customer parchi
        //        else if(singleCustomerId!=-1)
        //        {
        //            customerName = customers.GetCustomerNameById(singleCustomerId);

        //            getParchi(out previousBalance, out previousStatus, out totalLiters,
        //                                out milkAmount, out parchiAmount, out Balance, out BStatus,
        //                                singleCustomerId, startDate.Date, endDate.Date);

        //            // adding a row to the table as the new customer will come every time
        //            parchiTable.Rows.Add(singleCustomerId, customerName, previousBalance, previousStatus,
        //                totalLiters, milkAmount, parchiAmount, Balance, BStatus);


        //            grandTotalLiters += totalLiters;
        //            grandTotalMilkAmount += milkAmount;
        //            grandTotalParchiAmount += parchiAmount;

        //            previousBalance = 0;
        //            previousStatus = "";
        //            totalLiters = 0;
        //            milkAmount = 0;
        //            parchiAmount = 0;
        //            Balance = 0;
        //            BStatus = "";
        //            customerName = "";
        //        }
        //        // to get all customers parchi once
        //        else
        //        {
        //            foreach(var item in customerAndDodhiID)
        //            {
        //                int customerId = item.Key;

        //                customerName = customers.GetCustomerNameById(customerId);


        //                getParchi(out previousBalance, out previousStatus, out totalLiters,
        //                                out milkAmount, out parchiAmount, out Balance, out BStatus,
        //                                customerId, startDate.Date, endDate.Date);

        //                // adding a row to the table as the new customer will come every time
        //                parchiTable.Rows.Add(customerId, customerName, previousBalance, previousStatus,
        //                    totalLiters, milkAmount, parchiAmount, Balance, BStatus);


        //                grandTotalLiters += totalLiters;
        //                grandTotalMilkAmount += milkAmount;
        //                grandTotalParchiAmount += parchiAmount;

        //                previousBalance = 0;
        //                previousStatus = "";
        //                totalLiters = 0;
        //                milkAmount = 0;
        //                parchiAmount = 0;
        //                Balance = 0;
        //                BStatus = "";
        //                customerName = "";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error creating dodhi wise customers parchi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        dbConnection.closeConnection();
        //    }

        //    dataGridView.DataSource = parchiTable;

        //    dataGridView.Columns["Id"].Width = 60;
        //    dataGridView.Columns["Customer Name"].Width = 260;
        //    dataGridView.Columns["Previous Balance"].Width = 130;
        //    dataGridView.Columns["pStatus"].Width = 68;
        //    dataGridView.Columns["Total Liters"].Width = 100;
        //    dataGridView.Columns["Milk Amount"].Width = 110;
        //    dataGridView.Columns["Parchi Amount"].Width = 120;
        //    dataGridView.Columns["Closing Balance"].Width = 125;
        //    dataGridView.Columns["Status"].Width = 68;
        //}


        //public void getParchi(out decimal previousBalance, out string balanceStatus, out decimal totalMilk, out decimal milkAmount, out decimal parchiAmount, out decimal Balance, out string BStatus, int customerId, DateTime startDate, DateTime endDate)
        //{
        //    previousBalance = 0;
        //    balanceStatus = "";
        //    totalMilk = 0;
        //    milkAmount = 0;
        //    parchiAmount = 0;
        //    Balance = 0;
        //    BStatus = "";

        //    try
        //    {
        //        dbConnection.openConnection();

        //        // Calculate previous balance
        //        string previousBalanceQuery = @"
        //        SELECT ISNULL(SUM(amount), 0) AS totalAmount
        //        FROM (
        //            SELECT amount FROM Purchases WHERE customerID = @customerId AND date < @startDate
        //            UNION ALL
        //            SELECT -Debit FROM OpeningBalances WHERE AccountId=@customerId
        //            UNION ALL
        //            SELECT credit From OpeningBalances WHERE AccountId=@customerId
        //            UNION ALL
        //            SELECT -Debit FROM JournalVoucher WHERE AccountId=@customerId
        //            UNION ALL
        //            SELECT Credit FROM JournalVoucher WHERE AccountId=@customerId
        //            UNION ALL
        //            SELECT -amount FROM Payments WHERE accountId = @customerId
        //            UNION ALL
        //            SELECT amount FROM Receipts WHERE accountId = @customerId
        //        ) AS TransactionAmounts";

        //        using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
        //        {
        //            command.Parameters.AddWithValue("@customerId", customerId);
        //            command.Parameters.AddWithValue("@startDate", startDate);

        //            previousBalance = Convert.ToDecimal(command.ExecuteScalar());
        //            balanceStatus = previousBalance >= 0 ? "Credit" : "Debit";

        //        }

        //        // Calculate milk transactions
        //        string milkQuery = "SELECT ISNULL(SUM(liters), 0) AS totalLiters, ISNULL(SUM(amount), 0) AS totalAmount FROM Purchases WHERE CustomerID = @customerId AND date BETWEEN @startDate AND @endDate";

        //        using (SqlCommand command = new SqlCommand(milkQuery, dbConnection.connection))
        //        {
        //            command.Parameters.AddWithValue("@customerId", customerId);
        //            command.Parameters.AddWithValue("@startDate", startDate);
        //            command.Parameters.AddWithValue("@endDate", endDate);

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    totalMilk = Convert.ToDecimal(reader["totalLiters"]);
        //                    milkAmount = Convert.ToDecimal(reader["totalAmount"]);
        //                }
        //            }
        //        }

        //        // Calculate parchi amount and closing balance
        //        parchiAmount = milkAmount + previousBalance;
        //        parchiAmount = parchiAmount < 0 ? 0 : parchiAmount;


        //        Balance = milkAmount + previousBalance;
        //        BStatus = Balance < 0 ? "Debit" : "Credit";
        //        Balance = Math.Abs(Balance);
        //        previousBalance = Math.Abs(previousBalance);

        //        parchiAmount=Math.Round(parchiAmount,0);
        //        Balance = Math.Round(Balance, 0);
        //        previousBalance=Math.Round(previousBalance, 0);
        //        milkAmount=Math.Round(milkAmount,0);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error creating customers parchi!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        dbConnection.closeConnection();
        //    }
        //}


        public void getParchi(out decimal previousBalance, out string balanceStatus, out decimal totalMilk, out decimal milkAmount, out decimal parchiAmount, out decimal Balance, out string BStatus, int customerId, DateTime startDate, DateTime endDate)
        {
            previousBalance = 0;
            balanceStatus = "";
            totalMilk = 0;
            milkAmount = 0;
            parchiAmount = 0;
            Balance = 0;
            BStatus = "";

            try
            {
                dbConnection.openConnection();

                // Calculate previous balance
                string previousBalanceQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalAmount
                FROM (
                    SELECT amount FROM Purchases WHERE customerID = @customerId AND date < @startDate
                    UNION ALL
                    SELECT -Debit FROM OpeningBalances WHERE AccountId=@customerId
                    UNION ALL
                    SELECT credit From OpeningBalances WHERE AccountId=@customerId
                    UNION ALL
                    SELECT -Debit FROM JournalVoucher WHERE AccountId=@customerId
                    UNION ALL
                    SELECT Credit FROM JournalVoucher WHERE AccountId=@customerId
                    UNION ALL
                    SELECT -amount FROM Payments WHERE accountId = @customerId
                    UNION ALL
                    SELECT amount FROM Receipts WHERE accountId = @customerId
                ) AS TransactionAmounts";

                using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);

                    previousBalance = Convert.ToDecimal(command.ExecuteScalar());
                    balanceStatus = previousBalance >= 0 ? "Credit" : "Debit";

                }

                // Calculate milk transactions
                string milkQuery = "SELECT ISNULL(SUM(liters), 0) AS totalLiters, ISNULL(SUM(amount), 0) AS totalAmount FROM Purchases WHERE CustomerID = @customerId AND date BETWEEN @startDate AND @endDate";

                using (SqlCommand command = new SqlCommand(milkQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalMilk = Convert.ToDecimal(reader["totalLiters"]);
                            milkAmount = Convert.ToDecimal(reader["totalAmount"]);
                        }
                    }
                }

                // Calculate parchi amount and closing balance
                parchiAmount = milkAmount + previousBalance;
                parchiAmount = parchiAmount < 0 ? 0 : parchiAmount;


                Balance = milkAmount + previousBalance;
                BStatus = Balance < 0 ? "Debit" : "Credit";
                Balance = Math.Abs(Balance);
                previousBalance = Math.Abs(previousBalance);

                parchiAmount = Math.Round(parchiAmount, 0);
                Balance = Math.Round(Balance, 0);
                previousBalance = Math.Round(previousBalance, 0);
                milkAmount = Math.Round(milkAmount, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating customers parchi!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void getCustomersParchi(out decimal grandTotalLiters,out decimal grandTotalMilkAmount,
            out decimal grandTotalParchiAmount, int dodhiId,int singleCustomerId,
            DateTime startDate,DateTime endDate,DataGridView dataGridView)
        {
            DataTable parchiTable = new DataTable();
            parchiTable.Columns.Add("Id");
            parchiTable.Columns.Add("Customer Name");
            parchiTable.Columns.Add("Previous Balance");
            parchiTable.Columns.Add("pStatus");
            parchiTable.Columns.Add("Total Liters");
            parchiTable.Columns.Add("Milk Amount");
            parchiTable.Columns.Add("Closing Balance");
            parchiTable.Columns.Add("Status");
            parchiTable.Columns.Add("Credit Limit");
            parchiTable.Columns.Add("Parchi Amount");
            parchiTable.Columns.Add("Final Balance");
            parchiTable.Columns.Add("fStatus");

            // Local variables to accumulate totals
            decimal totalLiters = 0;
            decimal totalMilkAmount = 0;
            decimal totalParchiAmount = 0;
            //advancePayment = 0;

            try
            {
                dbConnection.openConnection();

                Dictionary<int, int> customerAndDodhiID = GetCustomerAndDodhiID();

                // Process customers based on Dodhi or specific customer
                IEnumerable<int> customersToProcess = customerAndDodhiID.Keys;

                if (dodhiId != -1) // Process only customers belonging to the specific Dodhi
                {
                    customersToProcess = customerAndDodhiID
                        .Where(item => item.Value == dodhiId)
                        .Select(item => item.Key);
                }
                else if (singleCustomerId != -1) // Process only a single customer
                {
                    customersToProcess = new List<int> { singleCustomerId };
                }

                // Process all selected customers
                foreach (int customerId in customersToProcess)
                {
                    string customerName = customers.GetCustomerNameById(customerId);
                    ParchiClass parchi = getParchi(customerId, startDate, endDate);

                    if (parchi != null)
                    {
                        totalLiters += parchi.TotalMilk;
                        totalMilkAmount += parchi.MilkAmount;
                        totalParchiAmount += parchi.ParchiAmount;

                        // Add row to DataTable
                        parchiTable.Rows.Add(
                            customerId,
                            customerName,
                            parchi.PreviousBalance,
                            parchi.BalanceStatus,
                            parchi.TotalMilk,
                            parchi.MilkAmount,
                            parchi.Balance,
                            parchi.BStatus,
                            parchi.creditLimit,
                            parchi.ParchiAmount,
                            parchi.FinalBalance,
                            parchi.FinalStatus

                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating Dodhi-wise customers parchi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            // Update DataGridView
            dataGridView.DataSource = parchiTable;

            dataGridView.Columns["Id"].Width = 60;
            dataGridView.Columns["Customer Name"].Width = 260;
            dataGridView.Columns["Previous Balance"].Width = 130;
            dataGridView.Columns["pStatus"].Width = 68;
            dataGridView.Columns["Total Liters"].Width = 100;
            dataGridView.Columns["Milk Amount"].Width = 110;
            dataGridView.Columns["Parchi Amount"].Width = 100;
            dataGridView.Columns["Closing Balance"].Width = 128;
            dataGridView.Columns["Status"].Width = 68;
            dataGridView.Columns["Final Balance"].Width = 120;
            dataGridView.Columns["fStatus"].Width = 65;
            dataGridView.Columns["Credit Limit"].Width = 80;

            // Set the out parameters
            grandTotalLiters = totalLiters;
            grandTotalMilkAmount = totalMilkAmount;
            grandTotalParchiAmount = totalParchiAmount;
        }



        public ParchiClass getParchi(int customerId, DateTime startDate, DateTime endDate)
        {
            var parchi = new ParchiClass();

            try
            {
                dbConnection.openConnection();

                // Get previous balance
                string previousBalanceQuery = @"
        SELECT ISNULL(SUM(amount), 0) AS totalAmount
        FROM (
            SELECT amount FROM Purchases WHERE customerID = @customerId AND date < @startDate
            UNION ALL
            SELECT -Debit FROM OpeningBalances WHERE AccountId=@customerId
            UNION ALL
            SELECT credit FROM OpeningBalances WHERE AccountId=@customerId
            UNION ALL
            SELECT -Debit FROM JournalVoucher WHERE AccountId=@customerId
            UNION ALL
            SELECT Credit FROM JournalVoucher WHERE AccountId=@customerId
            UNION ALL
            SELECT -amount FROM Payments WHERE accountId = @customerId
            UNION ALL
            SELECT amount FROM Receipts WHERE accountId = @customerId
        ) AS TransactionAmounts";

                using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);

                    parchi.PreviousBalance = Convert.ToDecimal(command.ExecuteScalar());
                    parchi.BalanceStatus = parchi.PreviousBalance >= 0 ? "Credit" : "Debit";
                }

                // Get milk transactions
                string milkQuery = "SELECT ISNULL(SUM(liters), 0) AS totalLiters, ISNULL(SUM(amount), 0) AS totalAmount FROM Purchases WHERE CustomerID = @customerId AND date BETWEEN @startDate AND @endDate";

                using (SqlCommand command = new SqlCommand(milkQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            parchi.TotalMilk = Convert.ToDecimal(reader["totalLiters"]);
                            parchi.MilkAmount = Convert.ToDecimal(reader["totalAmount"]);
                        }
                    }
                }

                


                // calculate parchi amount and closint balance
                parchi.Balance = parchi.MilkAmount + parchi.PreviousBalance;
                parchi.ParchiAmount = parchi.Balance;

                // set the closing balance status and parchi amount 
                parchi.ParchiAmount = parchi.ParchiAmount < 0 ? 0 : parchi.ParchiAmount;
                parchi.BStatus = parchi.Balance < 0 ? "Debit" : "Credit";

                // Adjust based on credit limit
                var customerCreditLimitTuple = customerIdCreditLimit
                .FirstOrDefault(c => c.customerId == customerId); // Get the matching tuple or default

                var customerCreditLimit = customerCreditLimitTuple == default
                    ? 0
                    : customerCreditLimitTuple.creditLimit; // Use creditLimit if the tuple exists, otherwise default to 0


                parchi.creditLimit = int.Parse(customerCreditLimit.ToString());

                if (parchi.creditLimit!=0 && parchi.MilkAmount!=0)
                {
                    if (parchi.Balance < 0)
                    {
                        parchi.ParchiAmount = parchi.creditLimit + parchi.Balance;
                        if (parchi.ParchiAmount > 0)
                        {
                            parchi.FinalBalance = parchi.Balance - parchi.ParchiAmount;
                            parchi.FinalStatus = "Debit";
                        }
                        else
                        {
                            parchi.FinalBalance = parchi.Balance;
                            parchi.FinalStatus = "Debit";
                            parchi.ParchiAmount = 0;
                        }
                    }
                    else
                    {
                        // calculate parchi amount by creditLimit + balance)
                        parchi.ParchiAmount = parchi.creditLimit + parchi.Balance;

                        // calculate final balance balance-creditLimit = balance+creditLimit
                        parchi.FinalBalance = parchi.Balance - parchi.ParchiAmount;
                        parchi.FinalStatus = "Debit";
                    }

                }
                else
                {
                    parchi.FinalBalance = parchi.Balance;
                    parchi.FinalStatus = parchi.FinalBalance < 0 ? "Debit" : "Credit";
                }

                // remove negative sign
                parchi.Balance = Math.Abs(parchi.Balance);
                parchi.PreviousBalance = Math.Abs(parchi.PreviousBalance);
                parchi.FinalBalance = Math.Abs(parchi.FinalBalance);

                

                //round of values
                parchi.ParchiAmount=Math.Round(parchi.ParchiAmount, 0);
                parchi.Balance = Math.Round(parchi.Balance, 0);
                parchi.PreviousBalance=Math.Round(parchi.PreviousBalance, 0);
                parchi.FinalBalance=Math.Round(parchi.FinalBalance, 0);
                parchi.MilkAmount=Math.Round(parchi.MilkAmount, 0);


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating customers parchi!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return parchi;
        }


        public void getAllAccountsBalances(int dodhiId, bool isCompany, DataGridView dataGridView, 
            out decimal grandTotalDebit, out decimal grandTotalCredit,out decimal grandOpeningBalance, out string grandOpeningStatus)
        {
            DataTable balanceTable = new DataTable();

            balanceTable.Columns.Add("Id");
            balanceTable.Columns.Add("Account Name");
            balanceTable.Columns.Add("Opening Balance");
            balanceTable.Columns.Add("oStatus");
            balanceTable.Columns.Add("Debit");
            balanceTable.Columns.Add("Credit");
            balanceTable.Columns.Add("Closing Balance");
            balanceTable.Columns.Add("Status");


            grandTotalCredit = 0;
            grandTotalDebit = 0;
            grandOpeningBalance = 0;
            grandOpeningStatus = "";
            


            decimal openingBalance = 0;
            string openingStatus = "";
            decimal totalDebit;
            decimal totalCredit;
            decimal Balance;
            string BStatus = "";
            string accountName;

            decimal grandOpeningDebit=0;
            decimal grandOpeningCredit=0;

            try
            {
                dbConnection.openConnection();

                Dictionary<int, int> customerAndDodhiID = new Dictionary<int, int>();

                customerAndDodhiID = GetCustomerAndDodhiID();

                Dictionary<int, string> companies = new Dictionary<int, string>();

                companies = company.GetCompanyIdsAndNames();

                if(!isCompany)
                {
                    // to get parchi of all customer ralated to a single dodhi
                    if (dodhiId != -1)
                    {
                        foreach (var item in customerAndDodhiID)
                        {
                            int customerId = item.Key;
                            int customerDodhiId = item.Value;

                            if (customerDodhiId == dodhiId)
                            {
                                accountName = customers.GetCustomerNameById(customerId);

                                // caling parchi function to generate parchi of the provide customer
                                GetAccountSummary(out openingBalance, out openingStatus, out totalDebit, out totalCredit, out Balance, out BStatus, customerId);

                                // adding a row to the table as the new customer will come every time
                                balanceTable.Rows.Add(customerId, accountName, openingBalance, openingStatus, totalDebit, totalCredit, Balance, BStatus);


                                grandTotalCredit += totalCredit;
                                grandTotalDebit += totalDebit;

                                //calculating total opening debt and credit amount
                                if(openingStatus=="Credit")
                                {
                                    grandOpeningCredit += openingBalance;
                                }
                                else if(openingStatus=="Debit")
                                {
                                    grandOpeningDebit += openingBalance;
                                }
                                // calculating total opening balance and status
                                

                                // setting values to zero for next the next customer
                                openingBalance = 0;
                                openingStatus = "";
                                totalDebit = 0;
                                totalCredit = 0;
                                Balance = 0;
                                BStatus = "";
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in customerAndDodhiID)
                        {
                            int customerId = item.Key;

                            accountName = customers.GetCustomerNameById(customerId);

                            // caling parchi function to generate parchi of the provide customer
                            GetAccountSummary(out openingBalance, out openingStatus, out totalDebit, out totalCredit, out Balance, out BStatus, customerId);

                            // adding a row to the table as the new customer will come every time
                            balanceTable.Rows.Add(customerId, accountName, openingBalance, openingStatus, totalDebit, totalCredit, Balance, BStatus);


                            grandTotalCredit += totalCredit;
                            grandTotalDebit += totalDebit;

                            if (openingStatus == "Credit")
                            {
                                grandOpeningCredit += openingBalance;
                            }
                            else if (openingStatus == "Debit")
                            {
                                grandOpeningDebit += openingBalance;
                            }

                            

                            openingBalance = 0;
                            openingStatus = "";
                            totalDebit = 0;
                            totalCredit = 0;
                            Balance = 0;
                            BStatus = "";

                        }
                    }
                }
                else // for companies balances
                {
                    foreach (var item in companies)
                    {
                        int companyId = item.Key;
                        string companyName = item.Value;
                        

                        // caling parchi function to generate parchi of the provide customer
                        GetAccountSummary(out openingBalance, out openingStatus,out totalDebit, out totalCredit, out Balance, out BStatus, companyId);

                        // adding a row to the table as the new customer will come every time
                        balanceTable.Rows.Add(companyId, companyName, openingBalance, openingStatus, totalDebit, totalCredit, Balance, BStatus);


                        grandTotalCredit += totalCredit;
                        grandTotalDebit += totalDebit;

                        if (openingStatus == "Credit")
                        {
                            grandOpeningCredit += openingBalance;
                        }
                        else if (openingStatus == "Debit")
                        {
                            grandOpeningDebit += openingBalance;
                        }

                        

                        openingBalance = 0;
                        openingStatus = "";
                        totalDebit = 0;
                        totalCredit = 0;
                        Balance = 0;
                        BStatus = "";

                    }
                }

                grandOpeningBalance = grandOpeningCredit - grandOpeningDebit;
                grandOpeningStatus = grandOpeningBalance > 0 ? "Credit" : "Debit";
                //grandOpeningBalance = Math.Abs(grandOpeningBalance);


                dataGridView.DataSource = balanceTable;

                dataGridView.Columns["Id"].Width = 70;
                dataGridView.Columns["Account Name"].Width = 160;
                dataGridView.Columns["Opening Balance"].Width = 130;
                dataGridView.Columns["oStatus"].Width = 70;
                dataGridView.Columns["Debit"].Width = 100;
                dataGridView.Columns["Credit"].Width = 110;
                dataGridView.Columns["Closing Balance"].Width = 125;
                dataGridView.Columns["Status"].Width = 70;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error calculating accounts balances: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void GetAccountSummary(out decimal openingBalance, out string openingStatus ,out decimal totalDebit, out decimal totalCredit, out decimal Balance, out string BStatus, int accountId)
        {
            openingBalance = 0;
            openingStatus = "";
            totalDebit = 0;
            totalCredit = 0;
            Balance = 0;
            BStatus = "";

            try
            {
                dbConnection.openConnection();

                string openingBalanceQuery = "SELECT ISNULL(SUM(amount), 0) AS OpeningBalance" +
                    " FROM (SELECT -debit AS amount FROM OpeningBalances WHERE accountId=@accountId" +
                    " UNION ALL" +
                    " SELECT credit AS amount FROM OpeningBalances WHERE accountId=@accountID)" +
                    " AS TransactionAmounts";

                using (SqlCommand command = new SqlCommand(openingBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    openingBalance = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate total debit (sum of negative amounts)
                string totalDebitQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalDebit
                FROM (
                    SELECT amount FROM Payments WHERE accountId = @accountId
                    UNION ALL
                    SELECT amount FROM Sales WHERE companyId = @accountId
                    UNION ALL
                    SELECT Debit FROM JournalVoucher WHERE AccountId=@accountId
                ) AS TransactionAmount";


                using (SqlCommand command = new SqlCommand(totalDebitQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    totalDebit = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate total credit (sum of positive amounts)
                string totalCreditQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalDebit
                FROM (
                    SELECT amount FROM Purchases WHERE customerID = @accountId
                    UNION ALL
                    SELECT amount FROM Receipts WHERE accountId = @accountId
                    UNION ALL
                    SELECT amountReceived FROM Sales WHERE companyId = @accountId
                    UNION ALL
                    SELECT Credit FROM JournalVoucher WHERE AccountId=@accountId
                ) AS TransactionAmounted";

                using (SqlCommand command = new SqlCommand(totalCreditQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    totalCredit = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate closing balance
                Balance = openingBalance + totalCredit - totalDebit;
                openingStatus = openingBalance < 0 ? "Debit" : "Credit";
                BStatus = Balance < 0 ? "Debit" : "Credit";
                openingBalance = Math.Abs(openingBalance);
                Balance = Math.Abs(Balance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating account summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


        
    }
}
