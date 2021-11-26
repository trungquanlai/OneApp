using System;
using System.Collections.Generic;

namespace PosRest.Models
{
    public class Order
    {
        public int ID { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public string Note { get; set; }
        public decimal Surcharge { get; set; }
        public int Status { get; set; }
        public decimal Discount { get; set; }
        public decimal GST { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Settings { get; set; }
    }
}
