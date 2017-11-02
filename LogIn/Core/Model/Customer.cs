using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string BranchName { get; set; }
        public string PhotoPath { get; set; }
        public string NIDPath { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string GuarantorAccount { get; set; }
        public string AccountNo { get; set; }
       
        
        
        public Customer()
        { }
        public Customer(string firstName, string lastName, string dateOfBirth, string gender, string contactNo, string branchName, string photoPath,
            string nidPath, string presentAddress, string permanentAddress, string guarantorAccount, string accountNo)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            ContactNo = contactNo;
            BranchName = branchName;
            PhotoPath = photoPath;
            NIDPath = nidPath;
            PresentAddress = presentAddress;
            PermanentAddress = permanentAddress;
            GuarantorAccount = guarantorAccount;
            AccountNo = accountNo;
        }
        public Customer(string firstName, string lastName, string dateOfBirth, string gender, string contactNo, string branchName, 
         string presentAddress, string permanentAddress, string guarantorAccount, string accountNo)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            ContactNo = contactNo;
            BranchName = branchName;
            PresentAddress = presentAddress;
            PermanentAddress = permanentAddress;
            GuarantorAccount = guarantorAccount;
            AccountNo = accountNo;
        }
    }
}