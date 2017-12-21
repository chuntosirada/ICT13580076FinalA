using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT13580076FinalA.models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]

        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public int Child { get; set; }
        public int Salary { get; set; }
    }
}
}
