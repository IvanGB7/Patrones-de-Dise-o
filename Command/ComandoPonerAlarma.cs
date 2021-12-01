using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoPonerAlarma: IComando
    {
        Automovil auto;

        public ComandoPonerAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            //Invocamos la accion correspondiente
            auto.ColocarAlarma();
        }
    }
}
