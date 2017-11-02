using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class CompanyInfo
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }

        public CompanyInfo(string companyName, string address, string mobileNo, string telephoneNo, string website,
            string email)
        {
            CompanyName = companyName;
            Address = address;
            MobileNo = mobileNo;
            TelephoneNo = telephoneNo;
            Website = website;
            Email = email;
        }
    }
}