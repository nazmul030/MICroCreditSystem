using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using LogIn.Core.Model;
using LogIn.Core.MODEL;

namespace LogIn.Core.DAL
{
    public class CustomersGateway : DBGateway
    {
        public bool CheckIfCustomerExistsByAccountId(string accountNo)
        {
            bool result = false;
            string query = @"SELECT * FROM Customers WHERE AccountNo='" + accountNo + "';";

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


        public string AddNewCustomer(Customer aCustomer)
        {
            string result = "";
            string query = @"INSERT INTO Customers VALUES('" + aCustomer.FirstName + "', '" + aCustomer.LastName + "','" + aCustomer.DateOfBirth +
                           "','" + aCustomer.Gender + "','" + aCustomer.ContactNo + "','" + aCustomer.BranchName + "','" + aCustomer.PhotoPath + "','" + aCustomer.NIDPath + "','" +
                           aCustomer.PresentAddress + "','" + aCustomer.PermanentAddress + "','" + aCustomer.GuarantorAccount + "','" + aCustomer.AccountNo + "');";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                {
                    result = "New customer profile has been successfully created.";
                }
                else
                {
                    result = "ERROR! Could not create new customer profile.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();
            return result;
        }

//        public List<Customer> GetCustomers()
//        {
//            List<Customer> customerLoansList = new List<cu>();
//            string query = @"SELECT Customers.AccountNo, Customers.FirstName + ' ' + Customers.LastName AS Name, Customers.ContactNo, Customers.BranchName,
//                            Loans.LoanType, Loans.LoanDate, Loans.PrincipalAmmount, Loans.InterestRate, Loans.EMIAmmount  
//                            FROM Customers LEFT OUTER JOIN Loans ON Customers.AccountNo=Loans.CustomerAccountNo;";
//            double principalAmmountvalue = 0;
//            double interestRateValue = 0;
//            double emiAmmountValue = 0;

//            try
//            {
//                connection.Open();
//                command.CommandText = query;
//                SqlDataReader reader = command.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        string accountNo = reader["AccountNo"].ToString();
//                        string name = reader["Name"].ToString();
//                        string contactNo = reader["ContactNo"].ToString();
//                        string branchName = reader["BranchName"].ToString();
//                        string loanType = reader["LoanType"].ToString();
//                        string loanDate = reader["LoanDate"].ToString();
//                        string principalAmmount = reader["PrincipalAmmount"].ToString();
//                        if (principalAmmount != "")
//                        {
//                            principalAmmountvalue = Convert.ToDouble(principalAmmount);
//                        }
//                        else
//                        {
//                            principalAmmountvalue = 0;
//                        }
//                        string interestRate = reader["InterestRate"].ToString();
//                        if (interestRate != "")
//                        {
//                            interestRateValue = Convert.ToDouble(interestRate);
//                        }
//                        else
//                        {
//                            interestRateValue = 0;
//                        }
//                        string emiAmmount = reader["EMIAmmount"].ToString();
//                        if (emiAmmount != "")
//                        {
//                            emiAmmountValue = Convert.ToDouble(emiAmmount);
//                        }
//                        else
//                        {
//                            emiAmmountValue = 0;
//                        }
//                        CustomerLoan customerLoan = new CustomerLoan(accountNo, name, contactNo, branchName, loanType, loanDate, principalAmmountvalue, interestRateValue, emiAmmountValue);

//                        customerLoansList.Add(customerLoan);
//                    }
//                }
//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                ex.ToString();
//            }
//            connection.Close();

//            return customerLoansList;
            
//        }


        public string UpdateCustomerInfo(Customer aCustomer)
        {
            string result = "";
            string query = @"UPDATE Customers SET FirstName='" + aCustomer.FirstName + "', LastName='" + aCustomer.LastName + "', DateOfBirth='" + aCustomer.DateOfBirth + "', Gender='" + aCustomer.Gender +
                            "', GuarantorContactNo='" + aCustomer.ContactNo + "', PhotoPath='" + aCustomer.PhotoPath + "', NIDPath='" + aCustomer.NIDPath + "', PresentAddress='" + aCustomer.PresentAddress +
                           "', GuarantorAddress='" + aCustomer.PermanentAddress + "', GuarantorCode='" + aCustomer.GuarantorAccount + "', GuarantorAccountNo='" + aCustomer.AccountNo + "' WHERE GuarantorAccountNo='" + aCustomer.AccountNo + "';";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                {
                    result = "Customer profile has been successfully updated.";
                }
                else
                {
                    result = "ERROR! Could not update customer profile.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();
            return result;
        }


        public string AddNewGuarantor(Guarantor aGuarantor)
        {
            string result = "";
            string query = @"INSERT INTO Guarantors VALUES( '" + aGuarantor.GuarantorFirstName + "','" + aGuarantor.GuarantorLastName +
                           "','" + aGuarantor.GuarantorContactNo + "','" + aGuarantor.GuarantorAddress + "','" + aGuarantor.GuarantorEmail + "','" + aGuarantor.GuarantorAccountNo + "','"+aGuarantor.CustomerAccount+"');";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                {
                    result = "New guarantor's profile has been successfully created.";
                }
                else
                {
                    result = "ERROR! Could not create new guarantor's profile.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();
            return result;
        }


        public string AddNewParentHusband(ParentHusband parentHusband)
        {
            string result = "";
            string query = @"INSERT INTO ParentHusbands VALUES('" + parentHusband.CustomerAccountNo + "', '" + parentHusband.ParentHusbandFirstName + "','" + parentHusband.ParentHusbandLastName +
                           "','" + parentHusband.ParentHusbandContactNo + "','" + parentHusband.ParentHusbandAddress + "');";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();

                if (rowsEffected > 0)
                {
                    result = "New parent/husband's profile has been successfully created.";
                }
                else
                {
                    result = "ERROR! Could not create new parent/husband's profile.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();
            return result;
        }

        public List<Customer> GetCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            string query = @"SELECT *FROM Customers;";
            double principalAmmountvalue = 0;
            double interestRateValue = 0;
            double emiAmmountValue = 0;

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string loanType = reader["Gender"].ToString();
                        string dateOfBirth = reader["DateOfBirth"].ToString();
                        string contactNo = reader["ContactNo"].ToString();
                        string branchName = reader["BranchName"].ToString();
                        string gender = reader["Gender"].ToString();
                        string presentAddress = reader["PresentAddress"].ToString();
                        string permanentAddress = reader["PermanentAddress"].ToString();
                        string accountNo = reader["AccountNo"].ToString();
                        string guarentorAccount = reader["GuarantorAccount"].ToString();
                        Customer customer= new Customer(firstName, lastName, dateOfBirth, gender,contactNo, branchName, presentAddress, permanentAddress, guarentorAccount,accountNo);

                        customerList.Add(customer);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();

            return customerList;
        }
        public Customer GetCustomerByAccount(string account)
        {
            Customer customers=new Customer();
            string query = @"SELECT *FROM Customers WHERE AccountNo='"+account+"'";
            double principalAmmountvalue = 0;
            double interestRateValue = 0;
            double emiAmmountValue = 0;

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       customers.FirstName= reader["FirstName"].ToString();
                        customers.LastName= reader["LastName"].ToString();
                        customers.Gender = reader["Gender"].ToString();
                        customers.DateOfBirth = reader["DateOfBirth"].ToString();
                       customers.ContactNo = reader["ContactNo"].ToString();
                        customers.BranchName = reader["BranchName"].ToString();
                        
                        customers.PresentAddress = reader["PresentAddress"].ToString();
                       customers.PermanentAddress = reader["PermanentAddress"].ToString();
                        customers.AccountNo = reader["AccountNo"].ToString();
                        customers.GuarantorAccount = reader["GuarantorAccount"].ToString();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();

            return customers;
        }

        public CustomerInfo GetCustomerInfoByAccount(string accountno)
        {
           CustomerInfo customerInfo=new CustomerInfo();
            string query = @"SELECT * FROM CUSTOMER_GUARENTER_PARENT WHERE AccountNo='" + accountno + "';";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        customerInfo.CustomerFirstName = reader["FirstName"].ToString();
                        customerInfo.CustomerLastName = reader["LastName"].ToString();
                        customerInfo.ContactNo = reader["ContactNo"].ToString();
                        customerInfo.DateOfBirth = reader["DateOfBirth"].ToString();
                        customerInfo.AccountNo = reader["AccountNo"].ToString();
                        customerInfo.Gender = reader["Gender"].ToString();
                        customerInfo.PresentAddress = reader["PresentAddress"].ToString();
                        customerInfo.PermenantAddress = reader["PermanentAddress"].ToString();
                        customerInfo.GuarentorAccount = reader["GuarantorAccountNo"].ToString();
                        customerInfo.GuarenterFirstName = reader["GuarantorFirstName"].ToString();
                        customerInfo.GuarenterLastName = reader["GuarantorLastName"].ToString();
                        customerInfo.GuarenterAddress = reader["GuarantorAddress"].ToString();
                        customerInfo.GuarenterContact = reader["GuarantorContactNumber"].ToString();
                        customerInfo.GuarenterEmail = reader["GuarantorEmail"].ToString();
                        customerInfo.ParentsHusbendFirstName = reader["ParentHusbandFirstName"].ToString();
                        customerInfo.ParentsHusbendLastName = reader["ParentHusbandLastName"].ToString();
                        customerInfo.ParentHusbendContactNo = reader["ParentHusbandContactNo"].ToString();
                        customerInfo.ParentHusbendAddress = reader["ParentHusbandAddress"].ToString();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            connection.Close();
            return customerInfo;
        }

        public int GetNoOfClients()//for no of registered Clients.
        {
            int noOfClients = 0;
            string query = @"SELECT  COUNT(Customers.Id) AS noofcustomers FROM Customers;";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        noOfClients = Convert.ToInt32(reader["noofcustomers"]);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
                ex.ToString();
            }
            connection.Close();
            return noOfClients;
        }

        public int GetNoOfLoan()//for no of Laon.
        {
            int noOfLoan = 0;
            string query = @"SELECT  COUNT(Loan.Id) AS noofloan FROM Loan;";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        noOfLoan = Convert.ToInt32(reader["noofloan"]);
                    }
                }
            }
            catch (Exception ex)
            {
                
                ex.ToString();
            }
            connection.Close();
            return noOfLoan;
        }
        public int GetTotalLoanAmmount()//for total of Laon ammount.
        {
            int noOfLoan=0;
            string query = @"SELECT  SUM(Loan.PrincipalAmmount) AS totalloanammount FROM Loan;";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        noOfLoan = Convert.ToInt32(reader["totalloanammount"]);
                    }
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            connection.Close();
            return noOfLoan;
        }
//        public List<CustomerLoan> GetCustomerLoans()
//        {
//            List<CustomerLoan> customerLoansList = new List<CustomerLoan>();
//            string query = @"SELECT Customers.AccountNo, Customers.FirstName + ' ' + Customers.LastName AS Name, Customers.ContactNo, Customers.BranchName,
//                            Loans.LoanType, Loans.LoanDate, Loans.PrincipalAmmount, Loans.InterestRate, Loans.EMIAmmount  
//                            FROM Customers LEFT OUTER JOIN Loans ON Customers.AccountNo=Loans.CustomerAccountNo;";
//            double principalAmmountvalue = 0;
//            double interestRateValue = 0;
//            double emiAmmountValue = 0;

//            try
//            {
//                connection.Open();
//                command.CommandText = query;
//                SqlDataReader reader = command.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        string accountNo = reader["AccountNo"].ToString();
//                        string name = reader["Name"].ToString();
//                        string contactNo = reader["ContactNo"].ToString();
//                        string branchName = reader["BranchName"].ToString();
//                        string loanType = reader["LoanType"].ToString();
//                        string loanDate = reader["LoanDate"].ToString();
//                        string principalAmmount = reader["PrincipalAmmount"].ToString();
//                        if (principalAmmount != "")
//                        {
//                            principalAmmountvalue = Convert.ToDouble(principalAmmount);
//                        }
//                        else
//                        {
//                            principalAmmountvalue = 0;
//                        }
//                        string interestRate = reader["InterestRate"].ToString();
//                        if (interestRate != "")
//                        {
//                            interestRateValue = Convert.ToDouble(interestRate);
//                        }
//                        else
//                        {
//                            interestRateValue = 0;
//                        }
//                        string emiAmmount = reader["EMIAmmount"].ToString();
//                        if(emiAmmount != "")
//                        {
//                            emiAmmountValue = Convert.ToDouble(emiAmmount);
//                        }
//                        else
//                        {
//                            emiAmmountValue = 0;
//                        }
//                        CustomerLoan customerLoan = new CustomerLoan(accountNo, name, contactNo, branchName, loanType, loanDate, principalAmmountvalue, interestRateValue, emiAmmountValue);

//                        customerLoansList.Add(customerLoan);
//                    }
//                }
//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                ex.ToString();
//            }
//            connection.Close();

//            return customerLoansList;
//        }


//        public List<CustomerLoan> GetSpecificCustomerLoans(string fromDate, string toDate)
//        {
//            List<CustomerLoan> customerLoansList = new List<CustomerLoan>();
//            string query = @"SELECT Customers.AccountNo, Customers.FirstName + ' ' + Customers.LastName AS Name, Customers.ContactNo, Customers.BranchName,
//                            Loans.LoanType, Loans.LoanDate, Loans.PrincipalAmmount, Loans.InterestRate, Loans.EMIAmmount  
//                            FROM Customers LEFT OUTER JOIN Loans ON Customers.AccountNo=Loans.CustomerAccountNo WHERE Loans.LoanDate>='" +
//                            fromDate + "' AND Loans.LoanDate<='" + toDate + "';";

//            try
//            {
//                connection.Open();
//                command.CommandText = query;
//                SqlDataReader reader = command.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    while (reader.Read())
//                    {
//                        string accountNo = reader["AccountNo"].ToString();
//                        string name = reader["Name"].ToString();
//                        string contactNo = reader["ContactNo"].ToString();
//                        string branchName = reader["BranchName"].ToString();
//                        string loanType = reader["LoanType"].ToString();
//                        string loanDate = reader["LoanDate"].ToString();
//                        double principalAmmount = Convert.ToDouble(reader["PrincipalAmmount"].ToString());
//                        double interestRate = Convert.ToDouble(reader["InterestRate"].ToString());
//                        double emiAmmount = Convert.ToDouble(reader["EMIAmmount"].ToString());

//                        CustomerLoan customerLoan = new CustomerLoan(accountNo,name,contactNo,branchName,loanType,loanDate,principalAmmount,interestRate,emiAmmount);

//                        customerLoansList.Add(customerLoan);
//                    }
//                }
//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                ex.ToString();
//            }
//            connection.Close();

//            return customerLoansList;
//        } 
    }
}