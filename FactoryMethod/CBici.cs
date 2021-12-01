using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class CBici: IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("No cesesitan encenderse");

        }

        public void Acelerar()
        {
            Console.WriteLine("Para acelerar: Pedalea fuerte para acelerar");
        }

        public void Frenar()
        {
            Console.WriteLine("Para frenar: Presiona el freno");
        }

        public void Girar()
        {
            Console.WriteLine("Para girar: Usa el manubrio");
        }

        public void Comprar()
        {
            Console.WriteLine("Has comprado una Bicleta");

        }


    }
}
