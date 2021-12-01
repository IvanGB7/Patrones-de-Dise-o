using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    //Interfaz para los saborizantes
    interface IProductoSaborizante
    {
        void obtener();
        string informacion();
    }
}
