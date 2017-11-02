using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class Guarantor
    {
       
        public string GuarantorFirstName { get; set; }
        public string GuarantorLastName { get; set; }
        public string GuarantorContactNo { get; set; }
        public string GuarantorAddress { get; set; }
        public string GuarantorEmail { get; set; }
        public string GuarantorAccountNo { get; set; }
        public string CustomerAccount{ get; set; }


        public Guarantor()
        {
            
        }
        public Guarantor( string guarantorFirstName, string guarantorLastName, string guarantorContactNo, string guarantorAddress, string guarantorEmail, string guarantorAccountNo):this(guarantorFirstName,guarantorLastName,guarantorContactNo,guarantorAddress,guarantorEmail,guarantorAccountNo,"")
        {
            
        }
        public Guarantor( string guarantorFirstName, string guarantorLastName, string guarantorContactNo, string guarantorAddress, string guarantorEmail, string guarantorAccountNo,string customeraccount)
        {
           
            GuarantorFirstName = guarantorFirstName;
            GuarantorLastName = guarantorLastName;
            GuarantorContactNo = guarantorContactNo;
            GuarantorAddress = guarantorAddress;
            GuarantorEmail = guarantorEmail;
            GuarantorAccountNo = guarantorAccountNo;
            CustomerAccount = customeraccount;
        }
    }
}