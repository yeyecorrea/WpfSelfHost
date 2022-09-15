using Microsoft.Owin;
using Newtonsoft.Json;
using Sif.Base;
using System;
using System.Collections.Generic;
using System.IO;
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
            // Si es post
            if (context.Request.Method == "POST")
            {
                // obtenemos el valor de esa solicitud
                String path = context.Request.Path.Value;
                // optenemos el servicio
                String serviceName = path.Replace("/", "");
                // validamos si es posible leer el contenido del body, body es la propiedad donde viene el contenido de la respuesta
                if (context.Request.Body.CanRead)
                {
                    // usamos TextReader,  convertimos el contenido en un string y luego deserializamos el objeto
                    using (TextReader stream = new StreamReader(context.Request.Body))
                    {
                        String data = stream.ReadToEnd();
                        DataDict dataDictionary;
                        DataDictionaryContainer Container = null;

                        JsonSerializerSettings settings = new JsonSerializerSettings();
                        settings.NullValueHandling = NullValueHandling.Ignore;
                    
                        SifWebResponse resp = new SifWebResponse();

                        // validamos si es Login
                        if (serviceName == "Login")
                        {
                            Container = JsonConvert.DeserializeObject<DataDictionaryContainer>(data, settings);
                            if (Container.ParametersList != null)
                            {
                                dataDictionary = Container.ParametersList.Dictionary;
                                SifBranchClient.Security.LoginBusiness login =
                                    new SifBranchClient.Security.LoginBusiness();
                                login.Dictionary = dataDictionary;
                                resp = login.Procces();
                            }
                        }
                    }
                }

            }
            await this.Next.Invoke(context);
        }
        // medoto que escribe la respuesta que se envia al cliente
        internal static void WriteResponse(IOwinContext context, String contentType, String body)
        {
            // creamos un array de bytes
            Byte[] bytes;
            // validamos que el contexto no llegue nulo
            if (context != null)
            {
                //
                String[] fContentType = new String[1];
                fContentType[0] = contentType;
                context.Response.Headers.Add("Content-Type", fContentType);
                bytes = Encoding.UTF8.GetBytes(body);
                Stream bodyStream = context.Response.Body;
                try
                {
                    bodyStream.Write(bytes, 0, bytes.Length);
                }
                catch(Exception e)
                {

                }
                bodyStream.Flush();
            }
        }
    }
}
