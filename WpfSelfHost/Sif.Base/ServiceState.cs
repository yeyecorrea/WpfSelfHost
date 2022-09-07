using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sif.Base
{
    // enum que contendra todos los estados de una respuesta
    public enum ServiceState
    {
        Accepted,
        Rejected,
        Error,
        Abort,
        Canceled
    }
}
