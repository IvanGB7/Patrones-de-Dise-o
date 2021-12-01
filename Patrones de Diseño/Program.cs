 using System;

namespace Patrones_de_Diseño
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intanciamos el singleton

            Singleton Recortadrio = Singleton.Instance;

            Singleton Recortadrio2 = Singleton.Instance;

            //Comprobamos que ambos objetos son referentes a
            //la misma Instancia
            Console.WriteLine(string.Format("Recordatorio: {0} creada a las {1}",
            Recortadrio.Tarea, Recortadrio.Fecha));

            Console.WriteLine(string.Format("Recordatorio: {0} creada a las {1}",
            Recortadrio2.Tarea, Recortadrio2.Fecha));

                

        }
    }
}
