using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICarroceria
    {
        string caracteristicas();

        class CarroceriaBasica : ICarroceria
        {
            public string caracteristicas()
            {
                return "Carroceria de Metal";
            }
        }

        class CarroceriaEspecial : ICarroceria
        {
            public string caracteristicas()
            {
                return "Carroceria de fibra de carbono";
            }
        }

    }
}

