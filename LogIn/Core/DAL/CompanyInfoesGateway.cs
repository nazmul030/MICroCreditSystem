using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using LogIn.Core.MODEL;

namespace LogIn.Core.DAL
{
    public class CompanyInfoesGateway:DBGateway
    {
        public string AddCompanyInfo(CompanyInfo companyInfo)
        {
            int rowsEffected = 0;
            string result = "";      
            string query = @"INSERT INTO CompanyInfoes VALUES('" + companyInfo.CompanyName + "','" + companyInfo.Address + "', '"+companyInfo.MobileNo+
                            "','" + companyInfo.TelephoneNo + "','" + companyInfo.Website + "', '" + companyInfo.Email +"')";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    result = "Company info has been successfully added.";
                }
                else
                {
                    result = "Could not add company info.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();

            return result;
        }


        public string UpdateCompanyInfo(CompanyInfo companyInfo)
        {
            int rowsEffected = 0;
            string result = "";
            string query = @"UPDATE CompanyInfoes SET CompanyName='" + companyInfo.CompanyName + "', Address='" + companyInfo.Address + "', MobileNo='" + companyInfo.MobileNo +
                            "', TelephoneNo='" + companyInfo.TelephoneNo + "', Website='" + companyInfo.Website + "', Email='" + companyInfo.Email + "';";

            try
            {
                connection.Open();
                command.CommandText = query;
                rowsEffected = command.ExecuteNonQuery();
                if (rowsEffected > 0)
                {
                    result = "Company info has been successfully updated.";
                }
                else
                {
                    result = "Could not update company info.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            connection.Close();

            return result;
        }


        public CompanyInfo GetCompanyInfo()
        {
            string query = @"SELECT * FROM CompanyInfoes;";
            CompanyInfo companyInfo = null;

            try
            {
                connection.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string companyName = reader["CompanyName"].ToString();
                        string address = reader["Address"].ToString();
                        string mobileNo = reader["MobileNo"].ToString();
                        string telephoneNo = reader["TelephoneNo"].ToString();
                        string website = reader["Website"].ToString();
                        string email = reader["Email"].ToString();

                        companyInfo = new CompanyInfo(companyName, address, mobileNo, telephoneNo, website, email);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            connection.Close();

            return companyInfo;
        }

        
    }
}