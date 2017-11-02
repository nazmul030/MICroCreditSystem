using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LogIn.Core.DAL
{
    public class DBGateway
    {
        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }

        public string connectionString =
            ConfigurationManager.ConnectionStrings["MicroCreditSystemDBConnectionString"].ConnectionString;


        public DBGateway()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }


        public string BackUpDB(string path, string date)
        {
            string result = "";
            string query = @"BACKUP DATABASE MicroCreditSystem TO DISK = '" + path + date + "_Backupfile.bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of MicroCreditSystem';";

            //string restoreQuery = @"RESTORE DATABASE TestDB FROM DISK = 'H:\\backupfile.bak';";

            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            result = "Backup of database has been successfully created.";

            return result;
        }
    }
}