using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public partial class Empleado
    {
        public Empleado(string nombre)
        {
            Nombre = nombre;
            Turno = Herencia.Program.GlobalTurnID++;
        }

        public Empleado(string nombre, int GlobalTurnID)
        {
            Nombre = nombre;
        }

        public string? Telefono { get; set; }
        public Empleado? Jefe { get; set; }
    }
}
