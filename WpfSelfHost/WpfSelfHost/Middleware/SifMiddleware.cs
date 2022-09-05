using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSelfHost.Middleware
{
    public class SifMiddleware : OwinMiddleware
    {
        public SifMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            //context.Response.WriteAsync("respuesta del Middleware");
            //await this.Next.Invoke(context);
            if (context.Request.Method == "POST")
            {
                String path = context.Request.Path.Value;
                String serviceName = path.Replace("/", "");
                if (serviceName == "Login")
                {
                    SifBranchClient.Security.LoginBusiness login = new SifBranchClient.Security.LoginBusiness();
                    login.Procces();

                }
            }
        }
    }
}
