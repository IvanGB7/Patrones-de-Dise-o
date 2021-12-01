using System;

namespace TemplatePattern
{
    class Coffee : Beverage
    {
        //
        protected override void Brew()
        {
            Console.WriteLine("Se agrega agua caliente al cafe y se mezcla");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Se agrega leche y azucar al cafe si el cliente lo decide");
        }

    }
}
