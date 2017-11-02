using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class UserInfo
    {
        public string EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public UserInfo(string employeeId, string userName, string password, string userType)
        {
            EmployeeId = employeeId;
            UserName = userName;
            Password = password;
            UserType = userType;
        }
    }
}