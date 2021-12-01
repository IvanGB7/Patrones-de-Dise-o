using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IMotor
    {
        string especificaciones();

        class MotorBasico:IMotor
        {
            public string especificaciones ()
            {
                return "Motor de cilindros ";
            }
        }

        class MotorGrande : IMotor
        {
            public String especificaciones()
            {
                return "Motor de 8 cilindros";
            }
        }
    }
}
