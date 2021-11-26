using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosRest.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public Order OrderID { get; set; }
        public string Note { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Settings { get; set; }
    }
}
