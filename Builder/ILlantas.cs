using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ILlantas
    {
        string Informacion();

        class LlantasBasica: ILlantas
        {
            public string Informacion()
            {
                return "Llantas de 14 pulgadas";
            }
        }

        class LlantasSuper: ILlantas
        {
            public string Informacion()
            {
                return "Llantas de 18 pulgadas";
            }
        }
    }
}
