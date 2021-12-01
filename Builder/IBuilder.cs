using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void ConstrulleMotor();
        void ConstrulleCarroceria();
        void ConstrulleLlantas();
    }
}
