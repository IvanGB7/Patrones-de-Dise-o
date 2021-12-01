using System;

namespace Ducks
{
    class FlyNope : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("No puedo volar");
        }
    }
}
