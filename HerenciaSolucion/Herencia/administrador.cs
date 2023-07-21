using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Administrador : Empleado
    {
        public Administrador()
        {
        }

        public Administrador(string nombre, bool plaza, int? numeroPlaza) : base(nombre)
        {
            Plaza = plaza;
            if (numeroPlaza.HasValue)
            {
                try
                {
                    NumeroPlaza = (int)numeroPlaza;
                }
                catch (FormatException)
                {
                    throw new FormatException("Error");
                }
            }
            else
            {
                NumeroPlaza = 0;
            }
        }

        public override void CalculoDeVacaciones()
        {
            base.CalculoDeVacaciones();
            DiasDeVacaciones += 15;
        }

        public int PlazaParking()
        
        { 
        throw new ErrorBaseDatos("Error en la base de datos al asignar el número de plaza.", DateTime.Now);
            return NumeroPlaza;
        }

        public override string ToString()
        {
            string mensajePlaza = Plaza ? $"tiene plaza (Número de plaza: {NumeroPlaza})." : "no tiene plaza.";

            return $"El nombre es: {Nombre}, Tiene un total de: {DiasDeVacaciones} días de vacaciones, Es administrador, {mensajePlaza}";
        }
    }
}