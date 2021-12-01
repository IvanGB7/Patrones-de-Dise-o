using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuilderDeportivo : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new IMotor.MotorGrande());
        }

        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new ILlantas.LlantasSuper());

        }

        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new ICarroceria.CarroceriaEspecial());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
