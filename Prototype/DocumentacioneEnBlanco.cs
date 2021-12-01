using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DocumentacionEnBlanco : Documentacion
    {
        private static DocumentacionEnBlanco _instance = null;

        private DocumentacionEnBlanco()
        {
            Documentos = new List<Documento>();
        }

        public static DocumentacionEnBlanco Instance()
        {
            return _instance ?? (_instance = new DocumentacionEnBlanco());
        }

        public void Incluye(Documento doc)
        {
            Documentos.Add(doc);
        }

        public void Excluye(Documento doc)
        {
            Documentos.Remove(doc);
        }
    }
}
