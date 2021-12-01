using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Calcu:ICarrito
    {
        public int TotalProductos(int Audifonos, int Teclado)
        {
            return Audifonos + Teclado;
        }

    }
}
