using DesignPatterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class EstadoPedido
    {
        protected Pedido pedido;

        public EstadoPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public abstract void AgregaProducto(Producto producto);
        public abstract void Borra();
        public abstract void SuprimeProducto(Producto producto);
        public abstract EstadoPedido EstadoSiguiente();
    }
}
