using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class CertificadoCesion : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine(
                "Muestra el certificado de cesión: " + contenido);
        }

        public override void Imprime()
        {
            Console.WriteLine(
                "Imprime el certificado de cesión: " + contenido);
        }
    }
}
