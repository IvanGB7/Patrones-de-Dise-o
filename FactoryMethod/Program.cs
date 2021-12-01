using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tienes para tu vehiculo");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            //Obtenemos el vehiculo de la fabrica

            vehiculo = CCreador.MetodoFabrica(dinero);


            vehiculo.Comprar();
            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

        }
    }
}
