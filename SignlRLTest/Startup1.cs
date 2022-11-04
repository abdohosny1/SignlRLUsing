using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignlRLTest.Startup1))]

namespace SignlRLTest
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            //first step
            app.MapSignalR();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
