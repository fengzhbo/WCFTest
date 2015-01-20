using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace WCFTest.Contract.Model
{
    [DataContract]
    public class DealerInfo
    {
        [DataMember]
        public Int32 DealerID { get; set; }

        [DataMember]
        public String DealerShortName { get; set; }


    }
}
