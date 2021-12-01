using BridgePattern;
using System;

namespace Bridge
{
    class Program
    {
        private static void Main()
        {
            //Creamos una nueva arma tipo espada con el flying encanto
            IWeapon sword = new Sword(new FlyingEnchantment());
            sword.Wield();
            sword.Swing();
            sword.Unwield();


            //Aqui creamos una nueva arma de tipo Martillo con el encanto de alma
            IWeapon hammer = new Hammer(new SoulEatingEnchantment());
            hammer.Wield();
            hammer.Swing();
            hammer.Unwield();
        }
    }
}
