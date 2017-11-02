using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LogIn.Core.MODEL;

namespace LogIn.Core.DAL
{
    public class BranchesGateway:DBGateway
    {
        public bool CheckIfBranchExists(string branchCode)
        {
            bool result = false;
            string query = @"SELECT * FROM Branches WHERE BranchCode='" + branchCode + "'";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            connection.Close();
            return result;
        }


        public string AddNewBranch(Branch aBranch)
        {
            int rowsEffected = 0;
            string result = "";
            string query = @"INSERT INTO Branches VALUES('" + aBranch.BranchCode + "', '" + aBranch.BranchName + "', '" + aBranch.Address + "');";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = "Error! Couldn't add new branch.";
            }
            connection.Close();

            if (rowsEffected > 0)
            {
                result = "New branch has been successfully added.";
            }
            return result;
        }


        public string UpdateBranch(Branch aBranch)//update Branch
        {
            int rowsEffected = 0;
            string result = "";
            string query = @"Update Branches SET BranchCode='" + aBranch.BranchCode + "', BranchName='" + aBranch.BranchName +
                           "', Address='" + aBranch.Address + "' WHERE Id='" + aBranch.Id + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = "Error! Couldn't update branch info.";
            }
            connection.Close();

            if (rowsEffected > 0)
            {
                result = "Branch information has been successfully updated.";
            }
            return result;
        }


        public List<Branch> GetAllBranches()//for gridview
        {
            List<Branch> branchList = new List<Branch>();
            string query = @"SELECT * FROM Branches";

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string branchCode = reader["BranchCode"].ToString();
                        string branchName = reader["BranchName"].ToString();
                        string address = reader["Address"].ToString();

                        Branch aBranch = new Branch(id,branchCode,branchName,address);
                        branchList.Add(aBranch);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
            return branchList;
        } 


        public string DeleteBranch(int id)//delete branch
        {
            int rowsEffected = 0;
            string result = "";
            string query = @"Delete FROM Branches WHERE Id='" + id + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                result = "Error! Couldn't delete branch.";
            }
            connection.Close();

            if (rowsEffected > 0)
            {
                result =  " branch  has been successfully deleted.";
            }
            return result;
        }
        public int GetTotalBranches()//for total of branches.
        {
            int noOfLoan = 0;
            string query = @"SELECT COUNT(Branches.Id) AS totalbranches FROM Branches;";
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        noOfLoan = Convert.ToInt32(reader["totalbranches"]);
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

        public Branch GetBranchForUpdate(string branchcode)//get branches
        {
            string query = @"SELECT * FROM Branches WHERE BranchCode='" + branchcode + "';";
             Branch branch = new Branch();
            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        branch.Id = Convert.ToInt32(reader["Id"]);
                        branch.BranchCode = reader["BranchCode"].ToString();
                        branch.BranchName = reader["BranchName"].ToString();
                        branch.Address = reader["Address"].ToString();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            connection.Close();
            return branch;
        }
    }
}