using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Producto
    {
        protected string nombre;

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }

        public void Visualiza()
        {
            Console.WriteLine("Producto: " + nombre);
        }
    }
}
