using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DatosProductos
    {
        public class DatosProducto
        {
            private static List<Producto> listaProductos = new List<Producto>()
            {
                new Producto {Codigo = "PROD-101", Nombre = "Teclado Mecánico", Precio = 45500m },
                new Producto {Codigo = "PROD-102",Nombre = "Mouse Inhalambrico", Precio = 18200m },
                new Producto {Codigo = "PROD-103", Nombre = "Monitor 24 pulgadas", Precio = 19500m}
            };
            public static Producto ObtenerPorCodigo(string codigo)
            {
                Console.WriteLine($"Total de productos en la lista: {listaProductos.Count}");
                return listaProductos.FirstOrDefault(p => p.Codigo.Equals(codigo, System.StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
