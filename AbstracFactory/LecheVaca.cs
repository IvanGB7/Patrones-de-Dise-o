using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    class LecheVaca:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Ordeñar Vacas");
        }

        public string obtenDatos()
        {
            return "Leche de vaca, 250 ml";
        }
    }
}
