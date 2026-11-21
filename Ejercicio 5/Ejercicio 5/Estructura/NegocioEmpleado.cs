using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class NegocioEmpleado
    {
        private DatosEmpleado datos = new DatosEmpleado();

        public Empleado ConsultarEmpleado(int id)
        {
            if (id < 100 || id > 999)
            {
                return null;
            }

            return datos.BuscarPorId(id);
        }
    }
}
