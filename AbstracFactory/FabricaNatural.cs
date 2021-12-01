using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    class FabricaNatural:IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Almendaras, 2) Coco");
            seleccion = Console.ReadLine();

            if (seleccion == "1")
                leche = new LecheAlmendras();
            else
                leche = new LecheCoco();

            leche.producir();

            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new SaborVainilla();
            sabor.obtener();

        }


    }
}
