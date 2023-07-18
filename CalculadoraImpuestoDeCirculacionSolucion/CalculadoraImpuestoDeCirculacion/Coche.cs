using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestoDeCirculacion
{
    public class Coche
    {
        public enum Etiqueta
        {
            Sin_Etiqueta,
            B,
            C,
            ECO,
            CERO
        }

        private Etiqueta etiqueta;

        public void fijarEtiqueta(Etiqueta etiqueta)
        {
            this.etiqueta = etiqueta;
        }

        public string Nombre { get; set; }
        public double PrecioBase { get; set; }
        public int AnoDelCoche { get; set; }

        public double CalcularImpuestoDeCirculacion()
        {
            double valorBase = 0;

            int antiguedad = DateTime.Now.Year - AnoDelCoche;
            valorBase += PrecioBase * (antiguedad * 0.01);

            switch (etiqueta)
            {
                case Etiqueta.Sin_Etiqueta:
                    valorBase += PrecioBase * 0.25;
                    break;
                case Etiqueta.B:
                    valorBase += PrecioBase * 0.15;
                    break;
                case Etiqueta.C:
                    valorBase += PrecioBase * 0.10;
                    break;
                case Etiqueta.ECO:
                    valorBase += PrecioBase * 0.05;
                    break;
            }
            return valorBase;
        }
    }
}
