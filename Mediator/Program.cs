using MediatorPattern;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un nuevo mediador que se encargara de manejar y tener un control en nuestras clases

            var mediator = new ManagerMediator();
            //Creamos nuestros variables con nuestros objetos y el mediador de por medio
            var customer = new Customer(mediator);
            var programmer = new Programmer(mediator);
            var tester = new Tester(mediator);
            //Igualamos nuestros mediadores con su objeto a nuestra variable
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            //Y aqui emviamos los mensajes gracias al mediador
            customer.Send("Tenemos que realizar un programa nuevo");
            programmer.Send("Ya tengo listo el programa, puedes testearlo");
            tester.Send("Terrmine de hacer el tester, y aqui tienes tu programa");
        }
    }
}
