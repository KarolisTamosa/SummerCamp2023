using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoneda
{
    public class conversor
    {
        public static double EurosAdolares( string monedaeuros)
        {
            double euros = double.Parse(monedaeuros);
            double eurosADolares = (euros * 1.12);
            return eurosADolares;
        }

        public static double DolaresAEuros(string monedadolar)
        {
            double dolares = double.Parse(monedadolar);
            double DolaresAEuros = (dolares * 0.89);
            return DolaresAEuros;
        }

        public static double EurosAlibras(string monedaeuros)
        {
            double euros = double.Parse(monedaeuros);
            double EurosAlibras = (euros * 0.87);
            return EurosAlibras;
        }

        public static double LibrasAEuros(string monedalibra)
        {
            double libras = double.Parse(monedalibra);
            double LibrasAEuros = (libras * 1.15);
            return LibrasAEuros;
        }
    }
}
