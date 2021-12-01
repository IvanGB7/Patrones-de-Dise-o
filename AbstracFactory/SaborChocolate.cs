using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    class SaborChocolate:IProductoSaborizante
    {

        public void obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }

        public string informacion()
        {
            return "Sabor Chocolate";
        }

    }
}
