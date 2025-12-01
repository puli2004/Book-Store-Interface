using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Interface.Models
{
    internal class Sales
    {
            
        public string OrdNum { get; set; }   
        public string StorId { get; set; }
        public string PayTerms { get; set; }
        public string TitleId { get; set; }
        public string Title { get; set; }

        public DateTime OrdDate { get; set; }     
        public short Qty { get; set; }      
        public decimal TotalValue { get; set; }
    }
}
