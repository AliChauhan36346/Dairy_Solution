using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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

                string receiveReportQuery = $"SELECT chilarReceiveId, date, dodhi, time, grossLiters, lr, fat, tsLiters FROM ChilarReceive {condition}";

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
                            grandTotalLoss+= totalLoss;

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
                        grandTotalLoss += totalLoss;

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
                            grandTotalLoss += totalLoss;

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
                        grandTotalLoss += totalLoss;

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
                    query = "SELECT ExpenseId, date, cashAccountId, cashAccountName, type, amount, discription, employeeId, employeeName FROM Expense WHERE date>=@startDate AND date<=@endDate";
                }
                else
                {
                    query = "SELECT ExpenseId, date, cashAccountId, cashAccountName, type, amount, discription, employeeId, employeeName FROM Expense WHERE type=@type AND date>=@startDate AND date<=@endDate";
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
    }
}
