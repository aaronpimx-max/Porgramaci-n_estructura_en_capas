using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            NegocioLibro negocio = new NegocioLibro();

            Console.Write("Ingrese el código ISBN del libro (ej: 978-950-07-0001-1): ");
            string isbn = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(isbn))
            {
                Console.WriteLine("Error: El ISBN no puede estar vacío ni contener solo espacios.");
            }
            else
            {
                Libro resultado = negocio.ConsultarLibro(isbn);

                if (resultado != null)
                {
                    Console.WriteLine($"Título: {resultado.Titulo}");
                    Console.WriteLine($"Autor: {resultado.Autor}");
                    Console.WriteLine($"Estado: {(resultado.Disponible ? "Disponible" : "Prestado")}");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún libro con ese código ISBN.");
                }
            }

            Console.ReadKey();
        }
    }
}
