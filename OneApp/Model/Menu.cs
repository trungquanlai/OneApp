using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosRest.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public Category CategoryID { get; set; }
        public ICollection<Item> Items { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Settings { get; set; }
    }
}
