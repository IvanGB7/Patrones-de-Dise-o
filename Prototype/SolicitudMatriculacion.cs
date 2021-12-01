using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class SolicitudMatriculacion : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine(
                "Muestra la solicitud de matriculación: " + contenido);
        }

        public override void Imprime()
        {
            Console.WriteLine(
                "Imprime la solicitud de matriculación: " + contenido);
        }
    }
}
