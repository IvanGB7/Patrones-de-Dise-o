using System;

namespace MediatorPattern
{
    class Customer : Colleague
    {
        //Creamos nuestro objeto customer que va a tener la clase Mediator de por medio

        public Customer(Mediator mediator) : base(mediator) { }

        //Aqui creamos la funcion para que se envie el mensaje al cliente con un mensaje predeterminado

        public override void Notify(string message)
        {
            Console.WriteLine($"Un mensaje para el cliente: {message}");
        }
    }
}