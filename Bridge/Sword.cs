using System;

namespace BridgePattern
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public Sword(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public void Wield()
        {
            Console.WriteLine("Ataque directo con la espada");
            _enchantment.OnActivate();
        }

        public void Swing()
        {
            Console.WriteLine("Ataque de swing con la espada");
            _enchantment.Apply();
        }

        public void Unwield()
        {
            Console.WriteLine("La espada es inservible...");
            _enchantment.OnDeactivate();
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}