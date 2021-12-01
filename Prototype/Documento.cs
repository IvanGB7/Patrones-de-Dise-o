using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Documento
    {
        protected string contenido = "";

        public Documento Duplica()
        {
            Documento resultado;
            resultado = (Documento)this.MemberwiseClone();
            return resultado;
        }

        public void Rellena(string informacion)
        {
            contenido = informacion;
        }

        public abstract void Imprime();
        public abstract void Visualiza();
    }
}
