using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Models
{
    [DataContract]
    public class Application
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string surname { get; set; }

        [DataMember]
        public string monitorModel { get; set; }

        [DataMember]
        public double price { get; set; }
    }
}