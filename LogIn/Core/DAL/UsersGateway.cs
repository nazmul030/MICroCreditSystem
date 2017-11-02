using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LogIn.Core.MODEL;

namespace LogIn.Core.DAL
{
    public class UsersGateway : DBGateway
    {
        public bool CheckIfUserExistsByUserNameAndPassword(string userName, string password)
        {
            bool result = false;
            string query = @"SELECT * FROM Users WHERE UserName='" + userName + "' AND Password='" + password + "';";

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
                //MessageBox.Show("Error! Cannot connect to database! Cannot check if user exists.");
            }
            connection.Close();

            return result;
        }


        public bool CheckIfUserExistsByEmployeeId(string employeeId)
        {
            bool result = false;
            string employeesId = "";
            string query = @"SELECT * FROM Users WHERE EmployeeId='" + employeeId + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    employeesId = reader["EmployeeId"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error! Cannot connect to database! Cannot check if user name exists.");
            }
            if (employeesId == employeeId)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            connection.Close();
            return result;
        }


        public bool CheckIfUserNameExists(string userName)
        {
            bool result = false;
            string usersName = "";
            string query = @"SELECT * FROM Users WHERE UserName='" + userName + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usersName = reader["UserName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error! Cannot connect to database! Cannot check if user name exists.");
            }
            if (usersName == userName)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            connection.Close();
            return result;
        }


        public string GetPassword(string userName)
        {
            string result = "";

            string query = @"SELECT * FROM Users WHERE UserName='" + userName + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader["Password"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error! Cannot connect to database! Cannot check if user name exists.");
            }

            return result;
        }

        public UserInfo GetSpecificUsersInfo(string userName, string password)
        {
            UserInfo loggedInUserInfo = null;
            string query = @"SELECT * FROM Users WHERE UserName='" + userName + "' AND Password='" + password + "';";
            string employeeId = "";
            string userType = "";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    employeeId = reader["EmployeeId"].ToString();
                    userType = reader["UserType"].ToString();

                    loggedInUserInfo = new UserInfo(employeeId, userName, password, userType);
                }
                else
                {
                    string errorResult = "Wrong User Name and Password.";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error! Cannot connect to database! Cannot check if user exists.");
            }
            connection.Close();
            return loggedInUserInfo;
        }
    }
}