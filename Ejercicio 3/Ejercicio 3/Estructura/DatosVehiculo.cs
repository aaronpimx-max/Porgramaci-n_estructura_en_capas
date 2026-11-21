using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class DatosVehiculo
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Vehiculo("AA123CD", "Ford Fiesta", false),
            new Vehiculo("AB456EF", "Volkswagen Gol Trend", true),
            new Vehiculo("AC789GH", "Toyota Corolla", false),
            new Vehiculo("AD321IJ", "Peugeot 208", true)
        };

        public Vehiculo ObtenerPorPatente(string patente)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Patente.ToUpper() == patente.ToUpper())
                {
                    return v;
                }
            }
            return null;
        }
    }
}
