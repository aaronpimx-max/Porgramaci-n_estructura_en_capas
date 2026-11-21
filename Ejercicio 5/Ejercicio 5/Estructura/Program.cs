using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            NegocioEmpleado negocio = new NegocioEmpleado();

            Console.Write("Ingrese el ID del empleado (entre 100 y 999, ej:250)");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int id))
            {
                Console.WriteLine("Error: Debe ingresar un número entero válido.");
            }
            else if (id < 100 || id > 999)
            {
                Console.WriteLine("Error: El ID debe estar comprendido entre 100 y 999.");
            }
            else
            {
                Empleado resultado = negocio.ConsultarEmpleado(id);

                if (resultado != null)
                {
                    Console.WriteLine($"Nombre completo: {resultado.Nombre}");
                    Console.WriteLine($"Puesto: {resultado.Puesto}");
                    Console.WriteLine($"Departamento: {resultado.Departamento}");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún empleado registrado con ese ID.");
                }
            }

            Console.ReadKey();
        }
    }
}
