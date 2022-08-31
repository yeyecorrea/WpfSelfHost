using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using WpfSelfHost.Middleware;

[assembly: OwinStartup(typeof(WpfSelfHost.Startup))]

namespace WpfSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            /*
            app.Run((owinContext) => 
            {
                owinContext.Response.ContentType = "text/plain";
                return owinContext.Response.WriteAsync("Hello World");
            });
            */

            // Registramos el uso del Middleware
            app.Use<SifMiddleware>();
            app.UseStaticFiles(@"/AppWeb");
        }
    }
}
