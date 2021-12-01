using System;
using System.Collections.Generic;


namespace Command
{
    class ControlRemoto
    {
        private IComando[] comandos = new IComando[4];

        public ControlRemoto(Automovil pAuto)
        {
            comandos[0] = new ComandoEncender(pAuto);
            comandos[1] = new ComandoApagar(pAuto);
            comandos[2] = new ComandoPonerAlarma(pAuto);
            comandos[3] = new ComandoQuitarAlarma(pAuto);
        }

        public void Boton( int  pIndice)
        {
            comandos[pIndice].ejecutar();
        }
    }
}
