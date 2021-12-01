using System;

namespace MediatorPattern
{
    class Programmer : Colleague
    {
        //Creamos nuestro objeto programmer que va a tener la clase Mediator de por medio
        public Programmer(Mediator mediator) : base(mediator) { }

        //Aqui creamos la funcion para enviarle el mensaje predeterminado
        public override void Notify(string message)
        {
            Console.WriteLine($"Un mensaje para programmer: {message}");
        }
    }
}