using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_de_Diseño
{
    public class Singleton
    {

        // Declaramos un atributo del mismo tipo de la clase con carácter estático
        private static Singleton _instancia = null;

        public string Tarea { get; set; }
        public DateTime Fecha { get; set; }

        // Constructor privado. Únicamente puede ser invocado desde el interior
        // de la propia clase
        private Singleton()
        {
            Tarea = "Enviar Archivos al trabajo";
            Fecha = DateTime.Now;
        }

        // Property de solo lectura
        public static Singleton Instance
        {
            get
            {
                // Si el singleton no ha sido creado previamente, se instancia.
                // En caso contrario, se devolvera el que haya sido creado previamente
                if (_instancia == null)
                    _instancia = new Singleton();

                // Se devuelve la instancia
                return _instancia;
            }
        }

    }
}
