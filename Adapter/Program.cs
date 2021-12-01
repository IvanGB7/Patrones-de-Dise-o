using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            int resultado2 = 0;

            //Usamos la interfaz que el cliente conoce con un clase  que conoce

            ICarrito calcu = new Calcu();

            resultado = calcu.TotalProductos(800, 250);
            Console.WriteLine("El total a pagar es {0}", resultado);

            Console.WriteLine("-------------");

            //Hacemos uso del adaptador
            calcu = new Adaptador();

            //Usamos el adaptador para hacer la operacion
            resultado2 = calcu.TotalProductos(800, 250);

            Console.WriteLine("El total a pagar es {0}", resultado2);

        }
    }
}
