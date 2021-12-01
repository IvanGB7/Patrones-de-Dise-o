using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CCalculadoraArray
    {
        public double total(int[] productos)
        {
            int n = 0;
            int resul = 0;

            for (n = 0; n < productos.Length; n++)
                resul += productos[n];

            return resul;

        }
    }
}
