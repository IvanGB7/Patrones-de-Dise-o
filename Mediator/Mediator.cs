namespace MediatorPattern
{
    abstract class Mediator
    {
        //Aqui creamos nuestro mediador que sera el que envie el mensaje de acuerdo al colleague
        public abstract void Send(string message, Colleague colleague);
    }
}