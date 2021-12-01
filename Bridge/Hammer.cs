using System;

namespace BridgePattern
{
    public class Hammer : IWeapon
    {
        private readonly IEnchantment _enchantment;
        public Hammer(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        //Aqui llamamos a los metodos que creamos en la interfaz IWeapon y le asignamos una accion
        public void Wield()
        {
            //En este caso escribiremos en un console
            Console.WriteLine("Se ataca directamente con el martillo");
            //Y llamamos al hechizo por medio del objeto _enchantment
            _enchantment.OnActivate();
        }

        public void Swing()
        {
            Console.WriteLine("Se ataca con un swing con el martillo");
            _enchantment.Apply();
        }

        public void Unwield()
        {
            Console.WriteLine("El martillo ya esta desgastado");
            _enchantment.OnDeactivate();
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}