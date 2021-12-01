using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el originador
            Originador auto = new Originador("March", 2019, 250000);
            auto.Mostrar();

            //Creamos el caretaker
            CareTaker ct = new CareTaker();

            //Guardamos el estado
            ct.Memento = auto.CreaMemento();

            //Modificamos el objeto
            auto.Nombre = "Vocho";
            auto.Modelo = 1970;
            auto.Costo = 35000;
            auto.Mostrar();

            //Restauramos el estado anterior

            auto.Restaura(ct.Memento);
            auto.Mostrar();

        }
    }
}
