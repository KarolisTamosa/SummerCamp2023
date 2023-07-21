using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public partial class Empleado
    {
        public string Nombre { get; set; }
        public int Turno { get; set; }
        public int NumeroPlaza { get; set; }
        public bool Plaza { get; set; }


        public Empleado(string nombre, int turno, int numeroPlaza, bool plaza)
        {
            this.Nombre = nombre;
            this.Turno = turno;
            this.Plaza = plaza;
            this.NumeroPlaza = numeroPlaza;
        }

        //siempre que haces una clase con propiedades, luego tienes que hacer la misma clase sin propiedades para que funcione, es un
        //constructor predeterminado

        public Empleado() 
        {
            Nombre = "";
        }


        protected double DiasDeVacaciones;


        public virtual void CalculoDeVacaciones()
        {
            DiasDeVacaciones += 5;
        }

        public override string ToString()
        {
            return $"El nombre es: {Nombre}, Tiene un total de: {DiasDeVacaciones} días de vacaciones, Es empleado";
        }
    }
}