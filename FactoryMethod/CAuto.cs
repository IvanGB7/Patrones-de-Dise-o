using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class CAuto:IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Para Encender: Introduce la llave y girala");

        }

        public void Acelerar()
        {
            Console.WriteLine("Para acelerar:Pisa el acelerador");
        }

        public void Frenar()
        {
            Console.WriteLine("Para frenar: Pisa el freno");
        }

        public void Girar()
        {
            Console.WriteLine("Para girar: Toma el volante y giralo");
        }

        public void Comprar()
        {
            Console.WriteLine("Has comprado un Automóvil");

        }
    }
}
