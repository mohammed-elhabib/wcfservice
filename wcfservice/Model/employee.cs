using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace wcfservice.Model
{
    [DataContract]
  public  class Employee
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string job { get; set; }
        [DataMember]
        public decimal Pay { get; set; }
        [DataMember]
        public string FirstMidName { get; set; }
        [DataMember]
        public DateTime BirthDayDate { get; set; }
        
        [DataMember]
        public DateTime Date_At { get; set; }
        [DataMember]
        public DateTime Date_Up { get; set; }

    }
}
