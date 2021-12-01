using System;


namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();

            //Construimos un auto Economico
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);

            //obtenemos el Auto
            Producto auto1 = normal.ObtenProducto();

            auto1.MostrarAuto();

            Console.WriteLine("-----------");

            //Construimos auto deportivo
            BuilderDeportivo deportivo = new BuilderDeportivo();
            miDirector.Construye(deportivo);

            //Obtenemos el auto
            Producto auto2 = deportivo.ObtenProducto();

            auto2.MostrarAuto();

        }

    }
}
