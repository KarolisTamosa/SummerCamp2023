using System;

namespace Herencia
{
    public class ErrorBaseDatos : Exception
    {
        public DateTime FechaHora { get; set; }

        public ErrorBaseDatos(string mensaje, DateTime fechaHora) : base(mensaje)
        {
            this.FechaHora = fechaHora;
        }
    }
}