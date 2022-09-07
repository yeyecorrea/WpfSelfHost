using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sif.Base
{
    /// <summary>
    /// Sera la clase que va a contener a DataDictSecurity
    /// </summary>
    public class DataDict
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, NullValueHandling = NullValueHandling.Ignore, PropertyName = "security")]
        public DataDictSecurity Security { get; set; }
    }
}
