using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    class LecheCoco:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Buscar los cocos");
        }

        public string obtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }

    }
}
