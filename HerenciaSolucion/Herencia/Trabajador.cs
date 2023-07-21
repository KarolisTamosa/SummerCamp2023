using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Trabajador : Empleado
    {
        public Trabajador()
        {
        }  

        public Trabajador(string nombre, int globalTurnID) : base(nombre)
        {
            Turno = globalTurnID++;
        }

        public override void CalculoDeVacaciones()
        {
            base.CalculoDeVacaciones();
            DiasDeVacaciones += 10;
        }

        public override string ToString()
        {
            return $"El nombre es: {Nombre} " + $"Tiene un total de : {DiasDeVacaciones} días de vacaciones, Es trabajador y su turno es {Turno}";
        }
    }

}