using System;

namespace PosRest.Models
{
    public class Category
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Settings { get; set; }
    }
}
