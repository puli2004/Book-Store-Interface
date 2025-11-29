using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Models
{
    public class Employee
    {
        public string EmpId { get; set; }            
        public string Fname { get; set; }           
        public char? Minit { get; set; }            
        public string Lname { get; set; }           

        public short JobId { get; set; }            
        public byte? JobLevel { get; set; }         

        public string PubId { get; set; }           

        public DateTime HireDate { get; set; }

        public string username { get; set; }
        public string password { get; set; }
    }
}
