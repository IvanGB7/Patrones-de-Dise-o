using System;

namespace BridgePattern
{
    public class SoulEatingEnchantment : IEnchantment
    {

        //Aqui estamos llamando los metodos que creamos en la interfaz IEnchatment
        public void OnActivate()
        {
            //Le asignamos la accion al metodo y esta sera llamada en nuestras clases Sword y Hammer
            Console.WriteLine("El encanto le hace daño al enemigo");
        }

        public void Apply()
        {
            Console.WriteLine("El encanto absorve el poder y el alma del enemigo");
        }

        public void OnDeactivate()
        {
            Console.WriteLine("El encanto desaparece lentamente...");
        }
    }
}