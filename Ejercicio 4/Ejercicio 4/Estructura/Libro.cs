using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; }

        public Libro(string isbn, string titulo, string autor, bool disponible)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Disponible = disponible;
        }
    }
}
