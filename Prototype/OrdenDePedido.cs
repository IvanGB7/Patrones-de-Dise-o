using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class OrdenDePedido : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine("Muestra la orden de pedido: " +
                              contenido);
        }

        public override void Imprime()
        {
            Console.WriteLine("Imprime la orden de pedido: " +
                              contenido);
        }
    }
}
