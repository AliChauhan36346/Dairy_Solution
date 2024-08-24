using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class ReportsClass
    {
        AddEmployees employees = new AddEmployees();
        DashboardClass dashboard=new DashboardClass();

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
                    "tsLiters, amount FROM Sales WHERE date>=@startDate AND date<=@endDate ORDER BY date ASC";

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

                            salesReport.Rows.Add(salesId,date,companyId,companyName, liters, lr, fat, tsLiters, amount);
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
        int dodhiId, string time, out decimal Volume, out decimal tAmount, bool start, bool end)
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
            string eveningCondition = "";

            // dates to increase/decrease
            DateTime startDat = startDate;
            DateTime endDat = endDate;

            if (dodhiId != -1 && time == "")
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId";
                eveningCondition = "AND dodhiId=@dodhiId";
            }
            else if (time != "" && dodhiId == -1)
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND time=@time";
            }
            else if (dodhiId != -1 && time != "")
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId AND time=@time";
                eveningCondition = "AND dodhiId=@dodhiId";
            }
            else
            {
                condition = "WHERE date>=@startDate AND date<=@endDate";
            }

            try
            {
                dbConnection.openConnection();

                if (start)
                {
                    string startQuery = $"SELECT purchaseId, date, customerID, customerName, dodhi, time, liters, amount FROM Purchases WHERE date=@startDate AND time=@time {eveningCondition}";

                    using (SqlCommand command = new SqlCommand(startQuery, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@time", "Evening");
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);

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

                    // add one day to the start date to exclude the current date data
                    startDate = startDate.AddDays(1).Date;
                }

                if(end)
                {
                    endDate = endDate.AddDays(-1);
                }

                string purchaseReportQuery = $"SELECT purchaseId, date, customerID, customerName, dodhi, time, liters, amount FROM Purchases {condition} ORDER BY date ASC";

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

                if (end)
                {
                    string startQuery = "SELECT purchaseId, date, customerID, customerName, dodhi, time, liters, amount FROM Purchases WHERE date=@endDate AND time=@time";

                    using (SqlCommand command = new SqlCommand(startQuery, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@endDate", endDate);
                        command.Parameters.AddWithValue("@time", "Morning");

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
            dataGridView.Columns["Customer Name"].Width = 150;
            dataGridView.Columns["Dodhi Name"].Width = 120;
            dataGridView.Columns["Time"].Width = 70;
            dataGridView.Columns["Volume"].Width = 80;
            dataGridView.Columns["Amount"].Width = 120;
        }


        public void GetReceiveReport(DataGridView dataGridView, DateTime startDate, DateTime endDate,
            int dodhiId, string time, out decimal totalReceive, out decimal tsReceive)
        {
            totalReceive = 0;
            tsReceive = 0;


            DataTable receiveReport = new DataTable();

            receiveReport.Columns.Add("Id");
            receiveReport.Columns.Add("Date");
            receiveReport.Columns.Add("Dodhi Name");
            receiveReport.Columns.Add("Time");
            receiveReport.Columns.Add("Volume");
            receiveReport.Columns.Add("LR");
            receiveReport.Columns.Add("Fat%");
            receiveReport.Columns.Add("Ts Volume");

            string condition = "";

            if (dodhiId != -1 && time == "")
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId";
            }
            else if (time != "" && dodhiId == -1)
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND time=@time";
            }
            else if (dodhiId != -1 && time != "")
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

                string receiveReportQuery = $"SELECT chilarReceiveId, date, dodhi, time, grossLiters, lr, fat, tsLiters FROM ChilarReceive {condition} ORDER BY date ASC";

                using (SqlCommand command = new SqlCommand(receiveReportQuery, dbConnection.connection))
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
                           
                            int receiveId = int.Parse(reader["chilarReceiveId"].ToString());
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            string dodhiName = reader["dodhi"].ToString();
                            string rTime = reader["time"].ToString();
                            decimal volume = decimal.Parse(reader["grossLiters"].ToString());
                            decimal lr = decimal.Parse(reader["lr"].ToString());
                            decimal fat = decimal.Parse(reader["fat"].ToString());
                            decimal tsVolume = decimal.Parse(reader["tsLiters"].ToString());


                            totalReceive += volume;
                            tsReceive += tsVolume;

                            receiveReport.Rows.Add(receiveId, date, dodhiName, rTime, volume, lr, fat, tsVolume);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating receive report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = receiveReport;

            dataGridView.Columns["Id"].Width = 50;
            dataGridView.Columns["Date"].Width = 80;
            dataGridView.Columns["Dodhi Name"].Width = 135;
            dataGridView.Columns["Time"].Width = 80;
            dataGridView.Columns["Volume"].Width = 75;
            dataGridView.Columns["LR"].Width = 55;
            dataGridView.Columns["Fat%"].Width = 55;
            dataGridView.Columns["Ts Volume"].Width = 90;
        }

        public void dodhiLossReport(DateTime startDate, DateTime endDate,int dodhiId, string time, out decimal totalPurchased, out decimal totalReceived, out decimal totalLoss, out string gainOrLoss)
        {
            totalPurchased = 0;
            totalReceived = 0;
            totalLoss = 0;
            gainOrLoss = "";

            string condition = "";

            if (dodhiId != -1 && time == "")
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId";
            }
            else
            {
                condition = "WHERE date>=@startDate AND date<=@endDate AND dodhiId=@dodhiId AND time=@time";
            }
            

            try
            {
                dbConnection.openConnection();

                string receiveMilkQuery = $"SELECT grossLiters FROM ChilarReceive {condition}";
                string purchaseMilkQuery = $"SELECT liters FROM Purchases {condition}";


                using (SqlCommand command = new SqlCommand(receiveMilkQuery, dbConnection.connection))
                {
                    if (dodhiId != -1 && time == "")
                    {
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal liters = decimal.Parse(reader["grossLiters"].ToString());

                            totalReceived+= liters;
                        }
                    }
                }

                // to calculate total purchase milk for a single dodhi
                using (SqlCommand command = new SqlCommand(purchaseMilkQuery, dbConnection.connection))
                {
                    if (dodhiId != -1 && time == "")
                    {
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@dodhiId", dodhiId);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal liters = decimal.Parse(reader["liters"].ToString());

                            totalPurchased+= liters;
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error creating single dodhi loss report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            totalLoss = totalPurchased - totalReceived;

            gainOrLoss = totalLoss > 0 ? "Loss" : "Gain";

            totalLoss = Math.Abs(totalLoss);
        }

        public void GetAllDodhiLossReport(DataGridView dataGridView,DateTime startDate, DateTime endDate, int dodhiId, string time,
            out decimal grandTotalPurchase, out decimal grandTotalReceive, out decimal grandTotalLoss, out string grandGainOrLoss)
        {
            DataTable dodhiLossTable = new DataTable();

            dodhiLossTable.Columns.Add("Id");
            dodhiLossTable.Columns.Add("Dodhi Name");
            dodhiLossTable.Columns.Add("Purchased");
            dodhiLossTable.Columns.Add("Received");
            dodhiLossTable.Columns.Add("Difference");
            dodhiLossTable.Columns.Add("Status");

            grandTotalPurchase = 0;
            grandTotalReceive = 0;
            grandTotalLoss= 0;
            grandGainOrLoss = "";

            decimal totalReceive = 0;
            decimal totalPurchase = 0;
            decimal totalLoss= 0;
            string gainOrLoss = "";

            try
            {
                dbConnection.openConnection();

                Dictionary<int, string> dodhiIdAndName = new Dictionary<int, string>();

                dodhiIdAndName = employees.GetEmployeeIdsAndNames();

                if(dodhiId!=-1 && time=="")
                {
                    foreach(var item in dodhiIdAndName)
                    {
                        int id = item.Key;
                        string name = item.Value;

                        if(id==dodhiId)
                        {
                            dodhiLossReport(startDate.Date, endDate.Date, id, time, out totalPurchase, 
                                out totalReceive, out totalLoss, out gainOrLoss);

                            dodhiLossTable.Rows.Add(id,name,totalPurchase,totalReceive,totalLoss,gainOrLoss);

                            grandTotalReceive += totalReceive;
                            grandTotalPurchase += totalPurchase;

                            if(gainOrLoss=="Loss")
                            {
                                grandTotalLoss += totalLoss;
                            }
                            else
                            {
                                grandTotalLoss -= totalLoss;
                            }
                            

                            // setting the values zero for next use
                            totalPurchase = 0;
                            totalLoss = 0;
                            totalReceive = 0;
                            gainOrLoss = "";
                        }
                    }
                }
                else if(dodhiId==-1 && time!="")
                {
                    foreach (var item in dodhiIdAndName)
                    {
                        int id = item.Key;
                        string name = item.Value;


                        dodhiLossReport(startDate.Date, endDate.Date, id, time, out totalPurchase,
                            out totalReceive, out totalLoss, out gainOrLoss);

                        dodhiLossTable.Rows.Add(id, name, totalPurchase, totalReceive, totalLoss, gainOrLoss);

                        grandTotalReceive += totalReceive;
                        grandTotalPurchase += totalPurchase;

                        if (gainOrLoss == "Loss")
                        {
                            grandTotalLoss += totalLoss;
                        }
                        else
                        {
                            grandTotalLoss -= totalLoss;
                        }
                        

                        // setting the values zero for next use
                        totalPurchase = 0;
                        totalLoss = 0;
                        totalReceive = 0;
                        gainOrLoss = "";

                    }
                }
                else if(dodhiId!=-1 &&  time!="")
                {
                    foreach (var item in dodhiIdAndName)
                    {
                        int id = item.Key;
                        string name = item.Value;

                        if(id==dodhiId)
                        {
                            dodhiLossReport(startDate.Date, endDate.Date, id, time, out totalPurchase,
                            out totalReceive, out totalLoss, out gainOrLoss);

                            dodhiLossTable.Rows.Add(id, name, totalPurchase, totalReceive, totalLoss, gainOrLoss);

                            grandTotalReceive += totalReceive;
                            grandTotalPurchase += totalPurchase;

                            if (gainOrLoss == "Loss")
                            {
                                grandTotalLoss += totalLoss;
                            }
                            else
                            {
                                grandTotalLoss -= totalLoss;
                            }
                            

                            // setting the values zero for next use
                            totalPurchase = 0;
                            totalLoss = 0;
                            totalReceive = 0;
                            gainOrLoss = "";
                        }
                        
                        
                    }
                }
                else
                {
                    foreach (var item in dodhiIdAndName)
                    {
                        int id = item.Key;
                        string name = item.Value;

                        
                        dodhiLossReport(startDate.Date, endDate.Date, id, time, out totalPurchase,
                        out totalReceive, out totalLoss, out gainOrLoss);

                        dodhiLossTable.Rows.Add(id, name, totalPurchase, totalReceive, totalLoss, gainOrLoss);

                        grandTotalReceive += totalReceive;
                        grandTotalPurchase += totalPurchase;

                        if (gainOrLoss == "Loss")
                        {
                            grandTotalLoss += totalLoss;
                        }
                        else
                        {
                            grandTotalLoss -= totalLoss;
                        }
                        

                        // setting the values zero for next use
                        totalPurchase = 0;
                        totalLoss = 0;
                        totalReceive = 0;
                        gainOrLoss = "";
                        


                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error creating dodhi loss report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            grandGainOrLoss = grandTotalPurchase > grandTotalReceive ? "Loss" : "Gain";

            dataGridView.DataSource = dodhiLossTable;

            dataGridView.Columns["Id"].Width = 50;
            dataGridView.Columns["dodhi Name"].Width = 120;
            dataGridView.Columns["Purchased"].Width = 80;
            dataGridView.Columns["Received"].Width = 80;
            dataGridView.Columns["Difference"].Width = 80;
            dataGridView.Columns["Status"].Width = 65;
        }

        public decimal GetExpenseReport(DataGridView dataGridView, DateTime startDate, DateTime endDate, string ExpenseType)
        {
            decimal total = 0;

            DataTable expenseTable = new DataTable();

            expenseTable.Columns.Add("Id");
            expenseTable.Columns.Add("Date");
            expenseTable.Columns.Add("Acc Id");
            expenseTable.Columns.Add("Acc Name");
            expenseTable.Columns.Add("Expense Type");
            expenseTable.Columns.Add("Discription");
            expenseTable.Columns.Add("Emp Id");
            expenseTable.Columns.Add("Emp Name");
            expenseTable.Columns.Add("Amount");

            

            try
            {

                dbConnection.openConnection();

                string query;

                if (ExpenseType == "")
                {
                    query = "SELECT ExpenseId, date, cashAccountId, cashAccountName, type, amount, discription, employeeId, employeeName FROM Expense WHERE date>=@startDate AND date<=@endDate ORDER BY date ASC";
                }
                else
                {
                    query = "SELECT ExpenseId, date, cashAccountId, cashAccountName, type, amount, discription, employeeId, employeeName FROM Expense WHERE type=@type AND date>=@startDate AND date<=@endDate ORDER BY date ASC";
                }

                

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    if(ExpenseType=="")
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@type", ExpenseType);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                    }
                    

                    using(SqlDataReader reader=command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string id = reader["ExpenseId"].ToString();
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            string accId = reader["cashAccountId"].ToString();
                            string accName = reader["cashAccountName"].ToString();
                            string type = reader["type"].ToString();
                            string discription = reader["discription"].ToString();
                            string empId = reader["employeeId"].ToString();
                            string empName = reader["employeeName"].ToString();
                            decimal amount = (decimal)reader["amount"];

                            total += amount;

                            expenseTable.Rows.Add(id,date,accId,accName,type, discription,empId,empName,amount);
                        }
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error creating expense report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = expenseTable;

            dataGridView.Columns["Id"].Width = 60;
            dataGridView.Columns["date"].Width = 90;
            dataGridView.Columns["Acc Id"].Width = 60;
            dataGridView.Columns["Acc Name"].Width = 120;
            dataGridView.Columns["Expense Type"].Width = 115;
            dataGridView.Columns["Discription"].Width = 152;
            dataGridView.Columns["Emp Id"].Width = 60;
            dataGridView.Columns["Emp Name"].Width = 130;
            dataGridView.Columns["Amount"].Width = 100;



            return total;
        }

        public void GetCombinedReport(DataGridView dataGridView, DateTime startDate, DateTime endDate,
        out decimal morningReceive, out decimal totalSales, out decimal eveningReceive, out decimal tsSales, bool morning, bool evening)
        {
            morningReceive = 0;
            eveningReceive = 0;
            totalSales = 0;
            tsSales = 0;

            DateTime end=endDate;
            DateTime start=startDate;

            DataTable combinedReport = new DataTable();

            combinedReport.Columns.Add("Id");
            combinedReport.Columns.Add("Date");
            combinedReport.Columns.Add("Company/Dodhi Name");
            combinedReport.Columns.Add("Morning Volume");
            combinedReport.Columns.Add("Evening Volume");
            combinedReport.Columns.Add("Sale Volume");
            combinedReport.Columns.Add("Sale TS Volume");

            try
            {
                dbConnection.openConnection();

                // Handle the evening data for the start date
                if (evening)
                {
                    string eveningQuery = @"
                    SELECT 
                        'CR' + CAST(R.chilarReceiveId AS NVARCHAR(50)) AS Id, 
                        R.date, 
                        R.dodhi AS Name, 
                        CASE WHEN R.time = 'Morning' THEN R.grossLiters ELSE 0 END AS MorningVolume,
                        CASE WHEN R.time = 'Evening' THEN R.grossLiters ELSE 0 END AS EveningVolume,
                        NULL AS SaleVolume,
                        NULL AS SaleTsVolume
                    FROM ChilarReceive R
                    WHERE R.date = @startDate AND R.time='Evening'";

                    using (SqlCommand command = new SqlCommand(eveningQuery, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["Id"].ToString();
                                string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                                string name = reader["Name"].ToString();
                                string morningVolume = reader["MorningVolume"] != DBNull.Value ? reader["MorningVolume"].ToString() : "";
                                string eveningVolume = reader["EveningVolume"] != DBNull.Value ? reader["EveningVolume"].ToString() : "";
                                string saleVolume = reader["SaleVolume"] != DBNull.Value ? reader["SaleVolume"].ToString() : "";
                                string saleTsVolume = reader["SaleTsVolume"] != DBNull.Value ? reader["SaleTsVolume"].ToString() : "";

                                // Parse the decimal values and add to totals
                                if (!string.IsNullOrEmpty(morningVolume))
                                {
                                    morningReceive += decimal.Parse(morningVolume);
                                }
                                if (!string.IsNullOrEmpty(eveningVolume))
                                {
                                    eveningReceive += decimal.Parse(eveningVolume);
                                }
                                if (!string.IsNullOrEmpty(saleVolume))
                                {
                                    totalSales += decimal.Parse(saleVolume);
                                }
                                if (!string.IsNullOrEmpty(saleTsVolume))
                                {
                                    tsSales += decimal.Parse(saleTsVolume);
                                }

                                // Add to DataTable, replacing zero with empty string
                                combinedReport.Rows.Add(
                                    id,
                                    date,
                                    name,
                                    morningVolume == "0" ? "" : morningVolume,
                                    eveningVolume == "0" ? "" : eveningVolume,
                                    saleVolume == "0" ? "" : saleVolume,
                                    saleTsVolume == "0" ? "" : saleTsVolume
                                );
                            }
                        }
                    }

                    // Move startDate to the next day to exclude the evening of the startDate in the main query
                    start = startDate.AddDays(1);
                }

                // Handle the morning data for the end date
                if (morning)
                {
                    end = endDate.AddDays(-1);
                }

                // Combined query for the range between startDate and endDate
                string chilarReceiveQuery = @"
            SELECT 
                'CR' + CAST(R.chilarReceiveId AS NVARCHAR(50)) AS Id, 
                R.date, 
                R.dodhi AS Name, 
                CASE WHEN R.time = 'Morning' THEN R.grossLiters ELSE 0 END AS MorningVolume,
                CASE WHEN R.time = 'Evening' THEN R.grossLiters ELSE 0 END AS EveningVolume,
                NULL AS SaleVolume,
                NULL AS SaleTsVolume
            FROM ChilarReceive R
            WHERE R.date >= @startDate AND R.date <= @endDate";

                string salesQuery = @"
            SELECT 
                'SV' + CAST(S.salesId AS NVARCHAR(50)) AS Id,
                S.date, 
                S.company AS Name, 
                NULL AS MorningVolume,
                NULL AS EveningVolume,
                S.liters AS SaleVolume,
                S.tsLiters AS SaleTsVolume
            FROM Sales S
            WHERE S.date >= @startDate AND S.date <= @endDate";

                string combinedQuery = $@"
            ({chilarReceiveQuery})
            UNION ALL
            ({salesQuery})
            ORDER BY date ASC";

                using (SqlCommand command = new SqlCommand(combinedQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", start);
                    command.Parameters.AddWithValue("@endDate", end);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["Id"].ToString();
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            string name = reader["Name"].ToString();
                            string morningVolume = reader["MorningVolume"] != DBNull.Value ? reader["MorningVolume"].ToString() : "";
                            string eveningVolume = reader["EveningVolume"] != DBNull.Value ? reader["EveningVolume"].ToString() : "";
                            string saleVolume = reader["SaleVolume"] != DBNull.Value ? reader["SaleVolume"].ToString() : "";
                            string saleTsVolume = reader["SaleTsVolume"] != DBNull.Value ? reader["SaleTsVolume"].ToString() : "";

                            // Parse the decimal values and add to totals
                            if (!string.IsNullOrEmpty(morningVolume))
                            {
                                morningReceive += decimal.Parse(morningVolume);
                            }
                            if (!string.IsNullOrEmpty(eveningVolume))
                            {
                                eveningReceive += decimal.Parse(eveningVolume);
                            }
                            if (!string.IsNullOrEmpty(saleVolume))
                            {
                                totalSales += decimal.Parse(saleVolume);
                            }
                            if (!string.IsNullOrEmpty(saleTsVolume))
                            {
                                tsSales += decimal.Parse(saleTsVolume);
                            }

                            // Add to DataTable, replacing zero with empty string
                            combinedReport.Rows.Add(
                                id,
                                date,
                                name,
                                morningVolume == "0" ? "" : morningVolume,
                                eveningVolume == "0" ? "" : eveningVolume,
                                saleVolume == "0" ? "" : saleVolume,
                                saleTsVolume == "0" ? "" : saleTsVolume
                            );
                        }
                    }
                }

                // Handle the morning data for the end date
                if (morning)
                {
                    end = endDate.AddDays(1);

                    string morningQuery = @"
            SELECT 
                'CR' + CAST(R.chilarReceiveId AS NVARCHAR(50)) AS Id, 
                R.date, 
                R.dodhi AS Name, 
                CASE WHEN R.time = 'Morning' THEN R.grossLiters ELSE 0 END AS MorningVolume,
                CASE WHEN R.time = 'Evening' THEN R.grossLiters ELSE 0 END AS EveningVolume,
                NULL AS SaleVolume,
                NULL AS SaleTsVolume
            FROM ChilarReceive R
            WHERE R.date = @endDate AND R.time='Morning'
            UNION ALL
            SELECT 
                'SV' + CAST(S.salesId AS NVARCHAR(50)) AS Id,
                S.date, 
                S.company AS Name, 
                NULL AS MorningVolume,
                NULL AS EveningVolume,
                S.liters AS SaleVolume,
                S.tsLiters AS SaleTsVolume
            FROM Sales S
            WHERE S.date = @endDate";

                    using (SqlCommand command = new SqlCommand(morningQuery, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@endDate", endDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["Id"].ToString();
                                string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                                string name = reader["Name"].ToString();
                                string morningVolume = reader["MorningVolume"] != DBNull.Value ? reader["MorningVolume"].ToString() : "";
                                string eveningVolume = reader["EveningVolume"] != DBNull.Value ? reader["EveningVolume"].ToString() : "";
                                string saleVolume = reader["SaleVolume"] != DBNull.Value ? reader["SaleVolume"].ToString() : "";
                                string saleTsVolume = reader["SaleTsVolume"] != DBNull.Value ? reader["SaleTsVolume"].ToString() : "";

                                // Parse the decimal values and add to totals
                                if (!string.IsNullOrEmpty(morningVolume))
                                {
                                    morningReceive += decimal.Parse(morningVolume);
                                }
                                if (!string.IsNullOrEmpty(eveningVolume))
                                {
                                    eveningReceive += decimal.Parse(eveningVolume);
                                }
                                if (!string.IsNullOrEmpty(saleVolume))
                                {
                                    totalSales += decimal.Parse(saleVolume);
                                }
                                if (!string.IsNullOrEmpty(saleTsVolume))
                                {
                                    tsSales += decimal.Parse(saleTsVolume);
                                }

                                // Add to DataTable, replacing zero with empty string
                                combinedReport.Rows.Add(
                                    id,
                                    date,
                                    name,
                                    morningVolume == "0" ? "" : morningVolume,
                                    eveningVolume == "0" ? "" : eveningVolume,
                                    saleVolume == "0" ? "" : saleVolume,
                                    saleTsVolume == "0" ? "" : saleTsVolume
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating combined report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = combinedReport;

            dataGridView.Columns["Id"].Width = 70;
            dataGridView.Columns["Date"].Width = 90;
            dataGridView.Columns["Company/Dodhi Name"].Width = 260;
            dataGridView.Columns["Morning Volume"].Width = 120;
            dataGridView.Columns["Evening Volume"].Width = 120;
            dataGridView.Columns["Sale Volume"].Width = 120;
            dataGridView.Columns["Sale TS Volume"].Width = 120;

            dataGridView.Columns["Id"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);
            dataGridView.Columns["Date"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);
            dataGridView.Columns["Company/Dodhi Name"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);
            dataGridView.Columns["Morning Volume"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);
            dataGridView.Columns["Evening Volume"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);
            dataGridView.Columns["Sale Volume"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);
            dataGridView.Columns["Sale TS Volume"].HeaderCell.Style.BackColor = Color.FromArgb(173, 175, 179);

            dataGridView.EnableHeadersVisualStyles = false;

            // Event handler for changing row color
            dataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridView_DataBindingComplete);
        }


        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null) return;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    string id = row.Cells["Id"].Value.ToString();

                    // Change the row color if it's a sales record
                    if (id.StartsWith("SV"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(242, 165, 165); 
                    }
                    // Optionally, change the row color for ChilarReceive records
                    else if (id.StartsWith("CR"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(211, 240, 219); 
                    }
                }
            }
        }

        public void RoznamchaCash(DataGridView dataGridView, DateTime startDate, DateTime endDate, out decimal paymentTotal, out decimal receiptTotal, out decimal comulativeTotal, out decimal openingBalance, bool expense)
        {
            receiptTotal = 0;
            paymentTotal = 0;
            comulativeTotal = 0;
            
            dashboard.getAccountOpeningBalance(startDate, out comulativeTotal);

            openingBalance = comulativeTotal;


            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Trans.Id");
            dataTable.Columns.Add("Acc Id");
            dataTable.Columns.Add("Customer/Company Name");
            dataTable.Columns.Add("Discription");
            dataTable.Columns.Add("cAcc Id");
            dataTable.Columns.Add("Cash Account");
            dataTable.Columns.Add("Debit");
            dataTable.Columns.Add("Credit");
            dataTable.Columns.Add("Balance");

            try
            {
                dbConnection.openConnection();

                string query = "";

                string expenseQuery = @"SELECT 'EV' + CAST(expenseId AS NVARCHAR(50)) AS Id, date, 
                                employeeId AS accountId, employeeName AS accountName, cashAccountId, 
                                cashAccountName, discription, amount AS payment, NULL AS receipt 
                                FROM Expense WHERE date >= @startDate AND date <= @endDate
                                UNION ALL";

                if (expense)
                {
                    query = $@"{expenseQuery}
                SELECT 'SV' + CAST(salesId AS NVARCHAR(50)) AS Id, date, companyId AS accountId,
                    company AS accountName, accountId AS cashAccountId, accountName AS cashAccountName,
                    'Cash received during sales' AS discription, NULL AS payment, amountReceived AS receipt 
                FROM sales WHERE date >= @startDate AND date <= @endDate AND amountReceived != 0
                UNION ALL
                SELECT 'CPV' + CAST(paymentId AS NVARCHAR(50)) AS Id, date, accountId, 
                    accountName, cashAccountId, cashAccountName, discription, 
                    amount AS payment, NULL AS receipt 
                FROM Payments 
                WHERE date >= @startDate AND date <= @endDate 
                UNION ALL 
                SELECT 'CRV' + CAST(ReceiptId AS NVARCHAR(50)) AS Id, date, accountId, 
                    accountName, cashAccountId, cashAccountName, discription, 
                    NULL AS payment, amount AS receipt 
                FROM Receipts 
                WHERE date >= @startDate AND date <= @endDate 
                ORDER BY date ASC";
                }
                else
                {
                    query = @"
                SELECT 'SV' + CAST(salesId AS NVARCHAR(50)) AS Id, date, companyId AS accountId,
                    company AS accountName, accountId AS cashAccountId, accountName AS cashAccountName, 
                    'Cash received during sales' AS discription, amountReceived AS receipt, NULL AS payment 
                FROM sales WHERE date >= @startDate AND date <= @endDate AND amountReceived != 0
                UNION ALL
                SELECT 'CPV' + CAST(paymentId AS NVARCHAR(50)) AS Id, date, accountId, 
                    accountName, cashAccountId, cashAccountName, discription, 
                    amount AS payment, NULL AS receipt 
                FROM Payments 
                WHERE date >= @startDate AND date <= @endDate 
                UNION ALL 
                SELECT 'CRV' + CAST(ReceiptId AS NVARCHAR(50)) AS Id, date, accountId, 
                    accountName, cashAccountId, cashAccountName, discription, 
                    NULL AS payment, amount AS receipt 
                FROM Receipts 
                WHERE date >= @startDate AND date <= @endDate 
                ORDER BY date ASC";
                }

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["Id"].ToString();
                            string date = ((DateTime)reader["date"]).ToString("dd-MM-yyyy");
                            string accId = reader["accountId"].ToString();
                            string accName = reader["accountName"].ToString();
                            string discription = reader["discription"].ToString();
                            string cAccId = reader["cashAccountId"].ToString();
                            string cAccName = reader["cashAccountName"].ToString();

                            // Handle nullable payment and receipt fields
                            string payment = reader["payment"] != DBNull.Value ? reader["payment"].ToString() : "0";
                            string receipt = reader["receipt"] != DBNull.Value ? reader["receipt"].ToString() : "0";

                            // Parse and update totals
                            decimal paymentAmount = decimal.Parse(payment);
                            decimal receiptAmount = decimal.Parse(receipt);

                            comulativeTotal -= paymentAmount;
                            comulativeTotal += receiptAmount;

                            paymentTotal += paymentAmount;
                            receiptTotal += receiptAmount;

                            // Add to DataTable
                            dataTable.Rows.Add(date, id, accId, accName, discription, cAccId, cAccName, paymentAmount, receiptAmount, comulativeTotal);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating roznamcha cash report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = dataTable;

            dataGridView.Columns["Date"].Width = 90;
            dataGridView.Columns["Trans.Id"].Width = 80;
            dataGridView.Columns["Acc Id"].Width = 90;
            dataGridView.Columns["Customer/Company Name"].Width = 200;
            dataGridView.Columns["Discription"].Width = 200;
            dataGridView.Columns["cAcc Id"].Width = 80;
            dataGridView.Columns["Cash Account"].Width = 130;
            dataGridView.Columns["Debit"].Width = 100;
            dataGridView.Columns["Credit"].Width = 100;
            dataGridView.Columns["Balance"].Width = 110;

            dataGridView.Columns["Date"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Trans.Id"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Acc Id"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Customer/Company Name"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Discription"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["cAcc Id"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Cash Account"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Debit"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Credit"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Balance"].HeaderCell.Style.BackColor = Color.LightGray;

            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(RoznamchaCashdataGridView_DataBindingComplete);
        }

        private void RoznamchaCashdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null) return;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Trans.Id"].Value != null)
                {
                    string id = row.Cells["Trans.Id"].Value.ToString();

                    // Change the row color if it's a sales record
                    if (id.StartsWith("CRV"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(252, 251, 192);
                    }
                    // Optionally, change the row color for ChilarReceive records
                    else if (id.StartsWith("CPV"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(250, 217, 210);
                    }
                    else if (id.StartsWith("EV"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(203, 223, 247);
                    }
                    else if (id.StartsWith("SV"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(171, 250, 162);
                    }
                }
            }
        }

        private void GetDailyBasisChilarReport(DateTime startDate, out decimal receiveVolume, out decimal saleVolume, out decimal difference)
        {
            receiveVolume = 0;
            saleVolume = 0;
            difference = 0;

            try
            {
                dbConnection.openConnection();

                DateTime previousDate = startDate.AddDays(-1);

                // Corrected query string
                string query = "SELECT SUM(grossLiters) as TotalGrossLiters FROM chilarReceive WHERE (date = @previousDate AND time = 'Evening') OR (date = @currentDate AND time = 'Morning')";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@previousDate", previousDate);
                    command.Parameters.AddWithValue("@currentDate", startDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("TotalGrossLiters")))
                        {
                            receiveVolume = decimal.Parse(reader["TotalGrossLiters"].ToString());
                        }
                    }
                }

                string salesQuery = "SELECT SUM(liters) as TotalLiters FROM sales WHERE date = @startDate";

                using (SqlCommand command = new SqlCommand(salesQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("TotalLiters")))
                        {
                            saleVolume = decimal.Parse(reader["TotalLiters"].ToString());           
                        }
                    }
                }

                difference = receiveVolume - saleVolume;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in creating date wise chilar report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


        public void GetDateWiseChilarReport(DataGridView dataGridView, DateTime startDate, DateTime endDate, out decimal totalSaleVolume, out decimal totalReceiveVolume, out decimal totalBalance)
        {
            totalSaleVolume = 0;
            totalReceiveVolume = 0;
            totalBalance = 0;

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Receive Volume");
            dataTable.Columns.Add("Sale Volume");
            dataTable.Columns.Add("Difference");
            dataTable.Columns.Add("Balance");

            try
            {
                decimal receiveVolume = 0;
                decimal saleVolume = 0;
                decimal difference = 0;

                DateTime date = startDate;

                while (date <= endDate)
                {
                    GetDailyBasisChilarReport(date, out receiveVolume, out saleVolume, out difference);

                    totalBalance += difference;
                    totalReceiveVolume += receiveVolume;
                    totalSaleVolume += saleVolume;

                    dataTable.Rows.Add(date.ToString("dd/MM/yyyy"), receiveVolume, saleVolume, difference, totalBalance);

                    receiveVolume = 0;
                    saleVolume = 0;
                    difference = 0;

                    date = date.AddDays(1); // Move to the next date
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in creating date wise chilar report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView.DataSource = dataTable;

            dataGridView.Columns["Date"].Width = 90;
            dataGridView.Columns["Receive Volume"].Width = 130;
            dataGridView.Columns["Sale Volume"].Width = 130;
            dataGridView.Columns["Difference"].Width = 100;
            dataGridView.Columns["Balance"].Width = 150;

            dataGridView.Columns["Date"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Receive Volume"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Sale Volume"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Difference"].HeaderCell.Style.BackColor = Color.LightGray;
            dataGridView.Columns["Balance"].HeaderCell.Style.BackColor = Color.LightGray;

            dataGridView.EnableHeadersVisualStyles = false;

        }




    }
}
