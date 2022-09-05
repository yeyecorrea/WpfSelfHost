using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sif.Base
{
    public class SifWebResponse
    {
        public ServiceState State { get; set; }
        public String ResponseData { get; set; }
        public object JsonResponseObject { get; set; }
        public object DataDictionary { get; set; }
    }
}
