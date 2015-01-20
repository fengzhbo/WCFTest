using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WCFTest.Contract.Model;

namespace WCFTest.Contract.Interface
{
    [ServiceContract(Name = "DeslersService", Namespace = "http://price.yiche.com/")]
    public interface IDealers
    {
        [OperationContract]
        DealerInfo GetDealer(Int32 vendorId);

        [OperationContract]
        List<DealerInfo> GetDealers(List<Int32> vendorIds);
    }
}
