using System;

namespace ObserverPattern
{
    sealed class WeatherMonitor : IObserver<Weather>
    {
        private IDisposable _cancellation;
        private readonly string _name;

        public void Subscribe(WeatherSupplier provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }

        public WeatherMonitor(string name)
        {
            _name = name;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        //Creamos nuestro metodo de error
        public void OnError(Exception error)
        {
            Console.WriteLine("Error has occured");
        }


        //Aqui creamos un metodo que reciba el valor de la clase weather y conforme el valor hara su funcion
        public void OnNext(Weather value)
        {

            Console.WriteLine(_name);
            //Aqui evaluamos que accion necesita el cliente, si la temperatura, la humedad o la presion, y en dado caso que ingrese un valor diferente le marcaremos error
            if (_name.Contains("T"))
            {
                string op = $"| Temperature : {value.Temperature} Celsius |";
                Console.Write(op);

            }
            if (_name.Contains("P"))
            {
                string op = $"| Pressure : {value.Pressure} atm |";
                Console.Write(op);
            }
            if (_name.Contains("H"))
            {
                string op = $"| Humidity : {value.Humidity * 100} % |";
                Console.Write(op);
            }
            if (!(_name.Contains("T") || _name.Contains("P") || _name.Contains("H")))
            {
                OnError(new Exception());
            }
            Console.WriteLine();
        }
    }
}
