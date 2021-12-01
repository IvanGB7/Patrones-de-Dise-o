using System;

namespace TemplatePattern
{
    public abstract class Beverage
    {
        // ReSharper disable once InconsistentNaming
        protected int _sugar;

        //Aqui creamos el metodo para preparar las bebidas 
        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            //Aqui creamos una condicion que si el cliente quiere condimentos se agregaran los condimentos
            if (WantsCondiments)
                AddCondiments();

        }

        //Aqui vamos a recibir la respeusta de si el cliente quiere condimientos, y se evaluara en la condicion de arriba
        public bool WantsCondiments { private get; set; }


        protected abstract void Brew();


        private void Boil()
        {
            Console.WriteLine("Se agrega agua hirviendo");
        }

        private void Pour()
        {
            Console.WriteLine("Se esta sirviendo su bebida en la taza");
        }

        //Metodo para agregar condimentos
        protected abstract void AddCondiments();

        public int AddSugar { get; set; }

        protected void Sugar() { }
    }
}