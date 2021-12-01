using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Documentacion
    {
        public IList<Documento> Documentos { get; protected set; }
    }
}
