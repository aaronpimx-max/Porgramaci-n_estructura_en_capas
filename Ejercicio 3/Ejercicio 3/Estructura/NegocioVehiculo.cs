using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class NegocioVehiculo
    {
        private DatosVehiculo datos = new DatosVehiculo();

        public Vehiculo ConsultarVehiculo(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente) || patente.Trim().Length < 6)
            {
                return null;
            }

            return datos.ObtenerPorPatente(patente.Trim());
        }
    }
}
