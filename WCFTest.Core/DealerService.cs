using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFTest.Contract.Interface;
using WCFTest.Contract.Model;

namespace WCFTest.Core
{
    public class DealerService : IDealers
    {
        public DealerInfo GetDealer(int vendorId)
        {
            return new DealerInfo()
            {
                DealerID = vendorId,
                DealerShortName = "test" + vendorId.ToString()
            };
        }

        public List<DealerInfo> GetDealers(List<int> vendorIds)
        {
            List<DealerInfo> listDealers = new List<DealerInfo>();

            if (vendorIds != null && vendorIds.Count > 0)
            {
                vendorIds.ForEach(id => listDealers.Add(new DealerInfo()
                {
                    DealerID = id,
                    DealerShortName = "test" + id.ToString()

                }));

            }

            return listDealers;

        }
    }
}
