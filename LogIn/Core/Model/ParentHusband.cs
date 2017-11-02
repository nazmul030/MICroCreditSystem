using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class ParentHusband
    {
        public string CustomerAccountNo { get; set; }
        public string ParentHusbandFirstName { get; set; }
        public string ParentHusbandLastName { get; set; }
        public string ParentHusbandContactNo { get; set; }
        public string ParentHusbandAddress { get; set; }


        public ParentHusband(string customerAccountNo, string parentHusbandFirstName, string parentHusbandLastName, string parentHusbandContactNo, string parentHusbandAddress)
        {
            CustomerAccountNo = customerAccountNo;
            ParentHusbandFirstName = parentHusbandFirstName;
            ParentHusbandLastName = parentHusbandLastName;
            ParentHusbandContactNo = parentHusbandContactNo;
            ParentHusbandAddress = parentHusbandAddress;
        }
    }
}