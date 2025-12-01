using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Models
{
    public class Title
    {
        public string TitleID { get; set; }
        public string TitleName { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public decimal Price { get; set; }
        public int InventoryCount { get; set; }
    }
}
