using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Models
{
    internal class Author
    {
        public string AuthorId { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
        public bool IsContract { get; set; }
    }
}
