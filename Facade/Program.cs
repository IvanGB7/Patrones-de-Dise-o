using System;
using Subsistemas;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creaamos la instancia de la fachada
            CFacade facade = new CFacade();

            //Hacemos uso de  los subsistemas de la interfaz sencilla de la fachada
            facade.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");

            facade.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");

            facade.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");
            
            facade.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");

            facade.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------");


        }
    }
}
