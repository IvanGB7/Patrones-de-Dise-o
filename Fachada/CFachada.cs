using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    public class CFachada
    {
        //Estos son los subsistemas que se estan utilizando
        private CsistemaCompra compra = new CsistemaCompra();
        private CSubsistemaAlmacen almacen = new CSubsistemaAlmacen();
        private CSubistemaEnvio envio = new CSubistemaEnvio();

        //Este metodo es usada para realizar de forma sencilla una operacion
        //mas compleja que requiera uno o varios subsistemas 
        public void Compra()
        {
            if (compra.Comprar())
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }
        }


    }
}
