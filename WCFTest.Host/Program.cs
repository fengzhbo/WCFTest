using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using WCFTest.Contract.Interface;
using WCFTest.Core;

namespace WCFTest.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(DealerService)))
            {
                //host.AddServiceEndpoint(typeof(IDealers), new WSHttpBinding(), "http://127.0.0.1:3721/DealerService");

                //if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                //{

                //    host.Description.Behaviors.Add(new ServiceMetadataBehavior()
                //    {

                //        HttpGetEnabled = true,
                //        HttpGetUrl = new Uri("http://127.0.0.1:3721/DealerService/metadata")

                //    });

                //}

                host.Closed += delegate
                {
                    Console.WriteLine("service closed");
                };

                host.Closing += delegate
                {
                    Console.WriteLine("service closing");
                };

                host.Faulted += delegate
                {
                    Console.WriteLine("service faulted");
                };

                host.Opened += delegate
                {
                    Console.WriteLine("service opened");
                };

                host.Opening += delegate
                {
                    Console.WriteLine("service opening");
                };

                host.UnknownMessageReceived += delegate
                {
                    Console.WriteLine("service UnknownMessageReceived");
                };

                host.Open();
                Console.Read();

            }

        }

    }
}
