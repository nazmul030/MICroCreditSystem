using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.Model
{
    public class CustomerInfo
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string ContactNo { get; set; }
        public string DateOfBirth { get; set; }
        public string AccountNo { get; set; }
        public string Gender { get; set; }
        public string PresentAddress { get; set; }
        public string PermenantAddress { get; set; }
        public string GuarentorAccount { get; set; }
        public string GuarenterFirstName { get; set; }
        public string GuarenterLastName { get; set; }
        public string GuarenterAddress { get; set; }
        public string GuarenterContact { get; set; }
        public string GuarenterEmail { get; set; }
        public string ParentsHusbendFirstName { get; set; }
        public string ParentsHusbendLastName { get; set; }
        public string  ParentHusbendContactNo { get; set; }
        public string ParentHusbendAddress { get; set; }


        public CustomerInfo()
        {
            
        }
        public CustomerInfo( string firstname,string lastname,string contactno,string dateofbirth,string accountno,string gender,string presentaddress,string permenantaddress, string guarenteraccount,string guarenterfirstname,string guarenterlastname,string guarenteraddress,string guarentercontact, string guaranteremail,string parenthusbendfirstname,string parenthusbendlastname,string parenthusbendcontact,string parrenthusbendaddress)
        {
            CustomerFirstName = firstname;
            CustomerLastName = lastname;
            ContactNo = contactno;
            DateOfBirth = dateofbirth;
            AccountNo = accountno;
            Gender = gender;
            PresentAddress = presentaddress;
            PermenantAddress = permenantaddress;
            GuarentorAccount = guarenteraccount;
            GuarenterFirstName = guarenterfirstname;
            GuarenterLastName = guarenterlastname;
            GuarenterAddress = guarenteraddress;
            GuarenterEmail = guaranteremail;
            ParentsHusbendFirstName = parenthusbendfirstname;
            ParentsHusbendLastName = parenthusbendlastname;
            ParentHusbendContactNo = parenthusbendcontact;
            ParentHusbendAddress = ParentHusbendAddress;

        }
    }
}