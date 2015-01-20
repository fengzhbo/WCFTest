using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFTest.Client.WCFService;
using WCFTest.Contract.Interface;

namespace WCFTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            GetDealerInfo();




            //  Console.WriteLine(info.Result.DealerShortName);

            //info.GetAwaiter().OnCompleted(() =>
            //{
            //    Console.WriteLine(info.Result.DealerShortName);
            //});


            //using (ChannelFactory<IDealers> factory = new ChannelFactory<IDealers>("WSHttpBinding_DeslersService"))
            //{

            //    var proxy = factory.CreateChannel();

            //    Console.WriteLine(proxy.GetDealer(50002218).DealerShortName);

            //}
        }

        private static async void GetDealerInfo()
        {
            using (DeslersServiceClient client = new DeslersServiceClient())
            {
                var info = client.GetDealerAsync(5002218);

               // Console.WriteLine(info.Result.DealerShortName);

                await info;

                Console.WriteLine(info.Result.DealerShortName);
            }
        }
    }
}
