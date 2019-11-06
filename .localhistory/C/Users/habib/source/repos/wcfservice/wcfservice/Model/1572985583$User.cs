using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcfservice.Model
{
    class User
    {
        public int ID { get; set; }
        public string Usename { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime BirthDayDate { get; set; }
        public DateTime Date_At { get; set; }
        public DateTime Date_Up { get; set; }

    }
}
