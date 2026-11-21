using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class DatosLibro
    {
        private List<Libro> libros = new List<Libro>
        {
            new Libro("978-950-07-0001-1", "Rayuela", "Julio Cortázar", true),
            new Libro("978-950-07-0002-8", "El Aleph", "Jorge Luis Borges", false),
            new Libro("978-950-07-0003-5", "Martín Fierro", "José Hernández", true),
            new Libro("978-950-07-0004-2", "Cien años de soledad", "Gabriel García Márquez", false)
        };

        public Libro BuscarPorIsbn(string isbn)
        {
            foreach (Libro l in libros)
            {
                if (l.Isbn.Trim() == isbn.Trim())
                {
                    return l;
                }
            }
            return null;
        }
    }
}
