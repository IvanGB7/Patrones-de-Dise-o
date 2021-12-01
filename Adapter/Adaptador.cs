using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adaptador:ICarrito
    {
        CCalculadoraArray adaptado = new CCalculadoraArray();

        //Aquí hacemos la adptación 
       public int TotalProductos(int Audifonos, int Teclado)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envian

            int[] productos = { Audifonos, Teclado };

            //Realizamos la operacion en el adaptado

            r = adaptado.total(productos);

            return (int)r;
        }

    }
}
