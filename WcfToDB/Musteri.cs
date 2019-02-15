using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfToDB
{
    [DataContract]
    public class Musteri
    {
       

        [DataMember]
        public int musID { get; set; }

        [DataMember]
        public string adSoyad { get; set; }

        [DataMember]
        public string cinsiuet { get; set; }

        [DataMember]
        public int yas { get; set; }



    }
}
