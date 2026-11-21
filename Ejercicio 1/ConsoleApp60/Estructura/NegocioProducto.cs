using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NegocioProducto
    {
        public static string Consultar(string codigo, out Producto producto)
        {
            producto = null;

            if (string.IsNullOrWhiteSpace(codigo))
                return "Error: El codigo ingresado no puede estar vacio.";

            if (!codigo.StartsWith("PROD-", StringComparison.OrdinalIgnoreCase))
                return "Error: El codigo debe iniciar obligatoriamente con el prefijo PROD-";

            producto = DatosProductos.DatosProducto.ObtenerPorCodigo(codigo);

            if (producto == null)
                return "Aviso: No se encontró ningún producto con ese codigo.";

            return "Éxito";
        }
    }
}