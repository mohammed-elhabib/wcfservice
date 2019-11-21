using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace SDK.Model
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Job { get; set; }
        [DataMember]
        public decimal Pay { get; set; }
        [DataMember]
        public string FirstMidName { get; set; }
        [DataMember]
        public DateTime BirthDayDate { get; set; }

        /// <summary>
        /// Entity Creation time
        /// </summary>
        [DataMember]
        public DateTime CreateAt { get; set; }

        /// <summary>
        /// Entity Last Update time
        /// </summary>
        [DataMember]
        public DateTime UpdateAt { get; set; }

    }
}
