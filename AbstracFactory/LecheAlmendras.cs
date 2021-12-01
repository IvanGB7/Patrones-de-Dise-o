using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    class LecheAlmendras:IProductoLeche 
    {
        public void producir()
        {
            Console.WriteLine("Procesar las almendras");
        }

        public string obtenDatos()
        {
            return "Leche organica de almendra, 250 ml";
        }

    }
}
