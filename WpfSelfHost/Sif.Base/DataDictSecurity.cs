using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sif.Base
{
    /// <summary>
    /// esta clase contara con las  mismas propiedades del modelo security
    /// </summary>
    public class DataDictSecurity
    {
        // JsonPropierty permite configuara la serializacion con json
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,NullValueHandling =NullValueHandling.Ignore,PropertyName ="userLogon")]
        public  String UserLogon { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPassword")]
        public String UserPassword { get; set; }


    }
}
