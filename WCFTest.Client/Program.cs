using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WCFTest.Client.WCFService;
using WCFTest.Contract.Interface;

namespace WCFTest.Client
{
    class Program
    {
        static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        static void Main(string[] args)
        {

            watch.Start(); 

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " 1 " + watch.ElapsedMilliseconds.ToString());
            GetDealerInfo();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " 2 " + watch.ElapsedMilliseconds.ToString());
            Thread.Sleep(10000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " 3 " + watch.ElapsedMilliseconds.ToString());
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
                client.

                var info = client.GetDealerAsync(5002218);

                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " 4 " + watch.ElapsedMilliseconds.ToString());
               // Console.WriteLine(info.Result.DealerShortName);

                await info;

                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString() + " 5 " + watch.ElapsedMilliseconds.ToString() + " " + info.Result.DealerShortName);
            }
        }
    }
}
