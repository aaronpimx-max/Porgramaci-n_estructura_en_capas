using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            NegocioVehiculo negocio = new NegocioVehiculo();

            Console.Write("Ingrese la patente del vehículo (ej: AA123CD): ");
            string patente = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(patente) || patente.Trim().Length < 6)
            {
                Console.WriteLine("Error: La patente debe tener al menos 6 caracteres.");
            }
            else
            {
                Vehiculo resultado = negocio.ConsultarVehiculo(patente);

                if (resultado != null)
                {
                    Console.WriteLine($"Modelo: {resultado.Modelo}");
                    Console.WriteLine($"Estado de deuda: {(resultado.TieneDeuda ? "Tiene deudas pendientes" : "Sin deudas")}");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún vehículo registrado con esa patente.");
                }
            }

            Console.ReadKey();
        }
    }
}
