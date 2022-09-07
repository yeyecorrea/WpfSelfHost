using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sif.Base
{
    /// <summary>
    /// Clase que tendra el mismo formato que la respuestas que viene de la solicitud, este va atener un referencia al diccionario
    /// </summary>
    public class SifRestParameters
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, NullValueHandling = NullValueHandling.Ignore, PropertyName = "dictionary")]
        public DataDict Dictionary { get; set; }
    }
}
