using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Ejercicio 1---");
            Console.WriteLine("Ingrese el Codigo del Producto (ej: PROD-101: )");
            String codigo = Console.ReadLine();

            String resultado = NegocioProducto.Consultar(codigo, out Producto producto);

            if (resultado == "Éxito")
            {
                Console.WriteLine($"[¡Encontrado!] Nombre : {producto.Nombre}|Precio:{producto.Precio:N2}");
            }
            else
            {
                Console.WriteLine($"{resultado}");
            }
            Console.ReadKey();
        }
    }
}