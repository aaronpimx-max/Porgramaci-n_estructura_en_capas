using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class NegocioLibro
    {
        private DatosLibro datos = new DatosLibro();

        public Libro ConsultarLibro(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                return null;
            }

            return datos.BuscarPorIsbn(isbn);
        }
    }
}
