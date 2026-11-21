using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class DatosEmpleado
    {
        private List<Empleado> empleados = new List<Empleado>
        {
            new Empleado(105, "Camila Fernández", "Analista Funcional", "Sistemas"),
            new Empleado(250, "Lucas Benítez", "Desarrollador Backend", "Sistemas"),
            new Empleado(501, "Martina Gómez", "Selectora IT", "Recursos Humanos"),
            new Empleado(840, "Diego Pereyra", "Contador Senior", "Finanzas")
        };

        public Empleado BuscarPorId(int id)
        {
            foreach (Empleado emp in empleados)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
