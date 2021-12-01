using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracFactory
{
    interface IFabrica
    {
        void crearProductos();
        IProductoLeche ObtenProductoLeche { get; }
        IProductoSaborizante ObtenSabor { get; }
    }
}
