using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Models
{
    public class ShoppingCartItem
    {
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public int TitleID { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal linetotal { get { return UnitPrice * Quantity; } }
    }
}
