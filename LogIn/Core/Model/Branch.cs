using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }



        public Branch(string branchcode, string branchname, string address):this(0,branchcode,branchname,address)
        {
            
        }
        public Branch(int id,string branchCode, string branchName, string address)
        {
            Id = id;
            BranchCode = branchCode;
            BranchName = branchName;
            Address = address;
        }

        public Branch()
        {
            
        }
    }
}