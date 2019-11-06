using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    [DataContract]
    public enum ResultState
    {
        [EnumMember]
        Success,
        [EnumMember]
        Fail,
        [EnumMember]
        Error,
    }

    [DataContract]
    public class ServiceResult
    {
        public string Error { get; set; }
        public int ID { get; set; }
        public ResultState Status { get; set; } 
    }
}
