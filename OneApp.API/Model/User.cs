using System;

namespace PosRest.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Settings { get; set; }

    }
}
