using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderNormal:IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new IMotor.MotorBasico());
        }

        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new ILlantas.LlantasBasica());

        }

        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new ICarroceria.CarroceriaBasica());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }

    }
}
