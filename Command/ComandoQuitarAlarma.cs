using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoQuitarAlarma:IComando
    {
        Automovil auto;

        public ComandoQuitarAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            //Invocamos la accion correspondiente
            auto.QuitarAlamar();
        }
    }
}
