using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    class CsistemaCompra
    {
        public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir numero de tarjeta");
            dato = Console.ReadLine();

            if (dato=="12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago Aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago Rechazado");
                return false;
            }

        }

       

    }

    //
    class CSubsistemaAlmacen
    {
        private int Cantidad;

        public CSubsistemaAlmacen()
        {
            Cantidad = 3;
        }

        public bool SacarAlmacen()
        {
            if (Cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto Listo para Enviarse");
                Cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible, espere a que haya existencias");
                return false;
            }
        }

    }


    ///
    class CSubistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El producto va en caminoo");

        }
    }
}
