using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class CAvion:IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Para Encender: Sigue todo el procedimiento");

        }

        public void Acelerar()
        {
            Console.WriteLine("Para acelerar: Empuja el acelerador");
        }

        public void Frenar()
        {
            Console.WriteLine("Para frenar: Jala el acelerador");
        }

        public void Girar()
        {
            Console.WriteLine("Para girar: Mueve el timon de la cola");
        }

        public void Comprar()
        {
            Console.WriteLine("Has comprado un Avión");

        }
    }
}
