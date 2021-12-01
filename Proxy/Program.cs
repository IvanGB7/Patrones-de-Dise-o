using ProxyPattern;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("testImage.jpg");

            //En este caso la imagen sera cargada por el disco duro
            image.display();
            Console.WriteLine("");

            //Y en este caso la imagen no sera cargada por el disco duro
            image.display();
        }
    }
}
