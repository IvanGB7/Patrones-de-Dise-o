
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        public void Construye(IBuilder pConstructor)
        {
            pConstructor.ConstrulleMotor();
            pConstructor.ConstrulleCarroceria();
            pConstructor.ConstrulleLlantas();
        }
    }
}
