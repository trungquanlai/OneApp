using System;

namespace PosRest.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Settings { get; set; }

    }
}
