using Sif.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifBranchClient.Security
{
    public class LoginBusiness
    {
        // propiedad para recibir el diccionario
        public DataDict Dictionary { get; set; }
        public SifWebResponse Procces()
        {
            // creamos una instancia de la clase SifWebResponse
            SifWebResponse resp = new SifWebResponse();
            if (this.Dictionary != null)
            {
                if (this.Dictionary.Security.UserLogon == "yeferson")
                {
                    if (this.Dictionary.Security.UserPassword == "123456789")
                    {
                        resp.State = ServiceState.Accepted;
                    }
                }
                else
                {
                    resp.State = ServiceState.Rejected;
                }

            }
            return resp;
        }
    }
}
