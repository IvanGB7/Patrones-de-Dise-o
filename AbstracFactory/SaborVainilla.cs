using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    class SaborVainilla:IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("Se extrae escencia de las vainas");
        }

        public string informacion()
        {
            return "Extracto natural de vainilla";
        }

    }
}
