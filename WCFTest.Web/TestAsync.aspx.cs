using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFTest.Web.DealerService;

namespace WCFTest.Web
{

    public partial class TestAsync : System.Web.UI.Page
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        protected void Page_Load(object sender, EventArgs e)
        {
            watch.Start();

            Response.Write(Thread.CurrentThread.ManagedThreadId.ToString() + " 1 " + watch.ElapsedMilliseconds.ToString() + "<br />");

            this.Page.RegisterAsyncTask(new PageAsyncTask(GetDealerInfo));

            Response.Write(Thread.CurrentThread.ManagedThreadId.ToString() + " 2 " + watch.ElapsedMilliseconds.ToString() + "<br />");
        }

        private async Task GetDealerInfo()
        {
            using (DeslersServiceClient client = new DeslersServiceClient())
            {
                var info = client.GetDealerAsync(5002218);

                Response.Write(Thread.CurrentThread.ManagedThreadId.ToString() + " 4 " + watch.ElapsedMilliseconds.ToString() + "<br />");
                // Console.WriteLine(info.Result.DealerShortName);

                await info;

                Response.Write(Thread.CurrentThread.ManagedThreadId.ToString() + " 5 " + watch.ElapsedMilliseconds.ToString() + " " + info.Result.DealerShortName + "<br />");
            }
        }
    }
}