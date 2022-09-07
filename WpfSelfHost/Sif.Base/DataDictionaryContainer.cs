using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sif.Base
{
    /// <summary>
    /// Esta clase contendra a SifRestParameters
    /// </summary>
    public class DataDictionaryContainer
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, NullValueHandling = NullValueHandling.Ignore, PropertyName = "params")]
        public SifRestParameters ParametersList { get; set; }
    }
}
