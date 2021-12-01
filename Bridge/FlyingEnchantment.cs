using System;

namespace BridgePattern
{
    public class FlyingEnchantment : IEnchantment
    {
        public void OnActivate()
        {
            Console.WriteLine("El arma comienza con un brillo sigiloso");
        }

        public void Apply()
        {
            Console.WriteLine("El arma ataca a los enemigos y regresa al hechicero");
        }

        public void OnDeactivate()
        {
            Console.WriteLine("El brillo del arma se desvanece");
        }
    }
}