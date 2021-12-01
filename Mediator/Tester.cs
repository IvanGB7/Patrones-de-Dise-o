using System;

namespace MediatorPattern
{
    class Tester : Colleague
    {
        //Creamos nuestro objeto tester que va a tener la clase Mediator de por medio

        public Tester(Mediator mediator) : base(mediator) { }

        //Aqui creamos la funcion para enviarle el mensaje predeterminado

        public override void Notify(string message)
        {
            Console.WriteLine($"Un mensaje para tester: {message}");
        }
    }
}