using ObserverPattern;
using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            //Aqui creamos 2 observer que seran nuestros 2 casos de prueba, uno con TP para temperatura y otro con H para humedad
            var provider = new WeatherSupplier();
            var observer1 = new WeatherMonitor("TP");
            var observer2 = new WeatherMonitor("H");
            //Le indicamos los valores pertinentes y nos mostrara en consola por medio los valores
            provider.WeatherConditions(32.0, 0.05, 1.5);
            observer1.Subscribe(provider);
            provider.WeatherConditions(33.5, 0.04, 1.7);
            observer2.Subscribe(provider);
            provider.WeatherConditions(37.5, 0.07, 1.2);


        }
    }
}
