using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LogIn.Core.Model;
using LogIn.Core.MODEL;

namespace LogIn.Core.DAL
{
    public class AccountsGateway : DBGateway
    {
        public bool CheckIfAccountNoExists(string accountNo)
        {
            bool result = false;
            string query = @"SELECT * FROM Loan WHERE CustomerAccountNo='" + accountNo + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            connection.Close();
            return result;
        }


        public string CreateNewAccount(Account accountInfo)
        {
            string result = "";
            string query = @"INSERT INTO Accounts VALUES('" + accountInfo.AccountNo + "', '" + accountInfo.AccountType + "','" +
                            accountInfo.AccountGroup + "','" + accountInfo.BranchName + "','" + accountInfo.Balance + "');";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                {
                    result = "New account for customer has been successfully created.";
                }
                else
                {
                    result = "ERROR! Could not create account for new customer.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();
            return result;
        }


        public string CreateNewLoan(Loan loanInfo)
        {
            string result = "";
            string query = @"INSERT INTO Loan VALUES('" + loanInfo.LoanCode + "', '" + loanInfo.CustomerAccountNo + "','" + loanInfo.LoanDate + "','" + loanInfo.PrincipalAmmount + "','" + loanInfo.FileCharge + "','" +
                            loanInfo.InterestRate + "',' " + loanInfo.TimePeriod + "','" + loanInfo.Penalty + "','" + loanInfo.PaymentMode + "','" + loanInfo.InterestAmmountPerMonth + "','" + loanInfo.InterestAmmountPerYear + "','" +
                            loanInfo.InterestAmmountOfTimePeriod + "','" + loanInfo.EMIAmmount + "','"  + loanInfo.NoOfEMI + "', '"+loanInfo.TotalAmmount+"' ,'"+ loanInfo.BankName + "','" + loanInfo.CheckNo + "','"+0+"');";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                {
                    result = "New account for customer has been successfully created.";
                }
                else
                {
                    result = "ERROR! Could not create account for new customer.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();
            return result;
        }


        public string AddNewExpense(Expense expense)
        {
            string result = "";
            int rowsEffected = 0;
            string query = @"INSERT INTO Expenses VALUES('" + expense.Date + "', '" + expense.Ammount + "','" + expense.Description + "','" + expense.PaymentMode + "');";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    result = "New expense has been successfully added.";
                }
            }
            catch (Exception ex)
            {
                result = "Cannot open database! Couldn't add new expense.";
            }
            connection.Close();
            return result;
        }


        public List<Expense> GetAllExpenses()
        {
            List<Expense> expensesList = new List<Expense>();
            string query = @"SELECT * FROM Expenses;";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string date = reader["Date"].ToString();
                        double ammount = Convert.ToDouble(reader["Ammount"].ToString());
                        string description = reader["Description"].ToString();
                        string paymentMode = reader["PaymentMode"].ToString();

                        Expense expense = new Expense(date, ammount, description, paymentMode);
                        expensesList.Add(expense);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
            return expensesList;
        }

        public List<CustomerLoan> GetCustomerLoans()
        {
            List<CustomerLoan> loanslist=new List<CustomerLoan>();
            string query = @"SELECT * FROM CustomerLoans;";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                            
                           string name = reader["Name"].ToString();
                           string contact = reader["ContactNo"].ToString();
                           string branchname = reader["BranchName"].ToString();
                           string accountno = reader["CustomerAccountNo"].ToString();
                           string loandate = reader["LoanDate"].ToString();
                           double principalammount = Convert.ToDouble(reader["PrincipalAmmount"]);
                           double interestrate = Convert.ToDouble(reader["InterestRate"]);
                           double emiammount = Convert.ToDouble(reader["EMIAmmount"]);
                           string paymentmethod = reader["PaymentMode"].ToString();
                           double interestammountpermonth = Convert.ToDouble(reader["InterestAmmountPerMonth"]);
                           double interestammountperyear = Convert.ToDouble(reader["InterestAmmountPerYear"]);
                           int noofemi = Convert.ToInt32(reader["NoOfEMI"]);
                           double interstammountoftimeperiod = Convert.ToDouble(reader["InterestAmmountOfTimePeriod"]);
                           double filecharge = Convert.ToDouble(reader["FileCharge"]);
                           int timeperiod = Convert.ToInt32(reader["TimePeriod"]);
                           double penalty = Convert.ToDouble(reader["Penalty"]);
                           string loancode = reader["LoanCode"].ToString();
                           double paidammount = Convert.ToDouble(reader["Paidammount"]);
                           int paidemi = Convert.ToInt32(reader["PaidEMI"]);
                            DateTime date=new DateTime();
                               date = Convert.ToDateTime(loandate);
                               date= date.AddMonths(Convert.ToInt32(timeperiod));
                               string enddate = date.ToString();
                        int EMIAmmount = (int) Math.Ceiling(emiammount);
                        CustomerLoan customerLoan = new CustomerLoan(loancode, name, contact, branchname, accountno, loandate, enddate, principalammount, filecharge, interestrate, timeperiod, penalty, paymentmethod, interestammountpermonth, interestammountperyear, interstammountoftimeperiod, EMIAmmount, noofemi,paidammount,paidemi);
                            loanslist.Add(customerLoan);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
            return loanslist;
        }
        public List<CustomerLoan> GetCustomerOfCurrentLoans()
        {
            List<CustomerLoan> loanslist = new List<CustomerLoan>();
            string query = @"SELECT * FROM CustomerLoans WHERE NoOfEMI>PaidEMI;";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {



                        string name = reader["Name"].ToString();
                        string contact = reader["ContactNo"].ToString();
                        string branchname = reader["BranchName"].ToString();
                        string accountno = reader["CustomerAccountNo"].ToString();
                        string loandate = reader["LoanDate"].ToString();
                        double principalammount = Convert.ToDouble(reader["PrincipalAmmount"]);
                        double interestrate = Convert.ToDouble(reader["InterestRate"]);
                        double emiammount = Convert.ToDouble(reader["EMIAmmount"]);
                        string paymentmethod = reader["PaymentMode"].ToString();
                        double interestammountpermonth = Convert.ToDouble(reader["InterestAmmountPerMonth"]);
                        double interestammountperyear = Convert.ToDouble(reader["InterestAmmountPerYear"]);
                        int noofemi = Convert.ToInt32(reader["NoOfEMI"]);
                        double interstammountoftimeperiod = Convert.ToDouble(reader["InterestAmmountOfTimePeriod"]);
                        double filecharge = Convert.ToDouble(reader["FileCharge"]);
                        int timeperiod = Convert.ToInt32(reader["TimePeriod"]);
                        double penalty = Convert.ToDouble(reader["Penalty"]);
                        string loancode = reader["LoanCode"].ToString();
                        double paidammount = Convert.ToDouble(reader["PaidAmmount"]);
                        int paidemi = Convert.ToInt32(reader["PaidEMI"]);
                        DateTime date = new DateTime();
                        date = Convert.ToDateTime(loandate);
                        date.AddMonths(Convert.ToInt32(timeperiod));
                        string enddate = date.ToString();
                        int EMIAmmount = (int)Math.Ceiling(emiammount);
                        CustomerLoan customerLoan = new CustomerLoan(loancode, name, contact, branchname, accountno, loandate, enddate, principalammount, filecharge, interestrate, timeperiod, penalty, paymentmethod, interestammountpermonth, interestammountperyear, interstammountoftimeperiod, EMIAmmount, noofemi);
                        loanslist.Add(customerLoan);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
            return loanslist;
        }

        public CustomerLoan GetCustomerOfCurrentLoansByAccountN0( string accNo)
        {
            CustomerLoan customerLoan = new CustomerLoan();
            string query = @"SELECT * FROM CustomerLoan WHERE CustomerAccountNo='" + accNo + "'";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {



                        customerLoan.Name = reader["Name"].ToString();
                         customerLoan.ContactNo = reader["ContactNo"].ToString();
                        customerLoan.BranchName = reader["BranchName"].ToString();
                        customerLoan.CustomerAccountNo = reader["CustomerAccountNo"].ToString();
                        customerLoan.LoanDate = reader["LoanDate"].ToString();
                        customerLoan.PrincipalAmmount = Convert.ToDouble(reader["PrincipalAmmount"]);
                        customerLoan.InterestRate = Convert.ToDouble(reader["InterestRate"]);
                        double emiammount = Convert.ToDouble(reader["EMIAmmount"]);
                        customerLoan.PaymentMode= reader["PaymentMode"].ToString();
                       customerLoan.InterestAmmountPerMonth= Convert.ToDouble(reader["InterestAmmountPerMonth"]);
                       customerLoan.InterestAmmountPerYear = Convert.ToDouble(reader["InterestAmmountPerYear"]);
                        customerLoan.NoOfEMI = Convert.ToInt32(reader["NoOfEMI"]);
                        customerLoan.InterestAmmountOfTimePeriod = Convert.ToDouble(reader["InterestAmmountOfTimePeriod"]);
                        customerLoan.FileCharge = Convert.ToDouble(reader["FileCharge"]);
                        customerLoan.TimePeriod = Convert.ToInt32(reader["TimePeriod"]);
                        customerLoan.Penalty = Convert.ToDouble(reader["Penalty"]);
                        customerLoan.LoanCode = reader["LoanCode"].ToString();
                        string loandate = customerLoan.LoanDate;
                        int timeperiod = customerLoan.TimePeriod;
                        DateTime date = new DateTime();
                        date = Convert.ToDateTime(loandate);
                        date.AddMonths(Convert.ToInt32(timeperiod));
                        string enddate = date.ToString();
                        customerLoan.EMIAmmount = (int)Math.Ceiling(emiammount);
                        //CustomerLoan customerLoan = new CustomerLoan(loancode, name, contact, branchname, accountno, loandate, enddate, principalammount, filecharge, interestrate, timeperiod, penalty, paymentmethod, interestammountpermonth, interestammountperyear, interstammountoftimeperiod, EMIAmmount, noofemi);
                        //loanslist.Add(customerLoan);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
            return customerLoan;
        }
        public int GetMaxNoOfLoan()
        {
            int result = 0;
            string query = @"SELECT COUNT(Id) AS NoOfLoans FROM Loans;";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = Convert.ToInt32(reader["NoOfLoans"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
            return result;
        }

        public string PayEMIofLoan(PayEMIInfo payEmiInfo)
        {
            string result = "";
            int rowsEffected = 0;
            string query = @"INSERT INTO PayEMI VALUES('" + payEmiInfo.CustomerAccNo + "','" + payEmiInfo.Date + "','" +
                           payEmiInfo.EMIammount + "','" + payEmiInfo.NoOfEMI + "','" + payEmiInfo.PaymentMode + "','"+""+"');";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    result = "EMI is paid successfully";

                }
                
            }
            catch (Exception ex)
            {

                result = ex.ToString();
            }
            connection.Close();
            return result;
        }

        public void ReduceEMI_Balance(string accountno,int emi,double balance)
        {
            string query = @"UPDATE Loan SET NoOfEMI=(PaidEMI+'" + emi + "'),PaidAmmount+='" +
                           balance + "' WHERE CustomerAccountNo='" + accountno + "';";
            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
        }
    }
}