using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }

        public Empleado(int id, string nombre, string puesto, string departamento)
        {
            Id = id;
            Nombre = nombre;
            Puesto = puesto;
            Departamento = departamento;
        }
    }
}
