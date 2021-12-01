namespace ObserverPattern
{
    class Weather
    {

        //Aqui creamos nuestras variables para obtener valores como la presion, temperatura y la humedad,
        //como el nombre del patron lo dice, sirve para observar comportamientos de algo que queramos evaluar
        public double Pressure { get; }

        public double Humidity { get; }

        public double Temperature { get; }

        //Aqui creamos el objeto con sus atributos y metodos
        public Weather(double humd, double pres, double temp)
        {
            Temperature = temp;
            Pressure = pres;
            Humidity = humd;
        }
    }
}
