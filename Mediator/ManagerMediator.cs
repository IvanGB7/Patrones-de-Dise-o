namespace MediatorPattern
{
    class ManagerMediator : Mediator
    {
        //Aqui creamos nuestras variables que saldran de la clase Colleague
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        //Aqui creamos el metodo que recibira si es customer, programmer o tester
        public override void Send(string message, Colleague colleague)
        {
            //Aqui la mediacion es que si colleague es igual a costumer, el mensaje se le enviara al programmer
            if (colleague == Customer)
            {
                Programmer.Notify(message);
            }
            //Si el colleague es igual a programmer, se le enviara un mensaje a tester
            else if (colleague == Programmer)
            {
                Tester.Notify(message);
            }
            //Y si colleague es diferente, se le enviara un mensaje al cliente
            else Customer.Notify(message);
        }
    }
}