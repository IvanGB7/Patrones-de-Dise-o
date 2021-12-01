using System;

namespace TemplatePattern
{
    class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Agregamos el te al agua caliente y mezclamos");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Agregamos azucar y limon si el cliente asi lo decide");
            Sugar();
        }

        private new void Sugar()
        {
            Console.WriteLine($"Agregar {_sugar} cubitos de azucar");
        }

        public new int AddSugar
        {
            set { _sugar = value; }
        }
    }
}