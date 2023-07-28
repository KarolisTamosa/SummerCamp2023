using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class ReproductorCds
    {
        public bool cdColocado = false;

        public ReproductorCds()
        {
            Console.WriteLine("Bienvenido al Reproductor de CDs");
        }

        public bool InsertarCD()
        {
            if (!cdColocado)
            {
                Console.WriteLine("1. Abre la bandeja de CD.");
                Console.WriteLine("2. Coloca cuidadosamente el CD en la bandeja.");
                Console.WriteLine("3. Cierra la bandeja de CD.");

                cdColocado = true;
                Console.WriteLine("CD insertado correctamente.");

                return true;
            }
            else
            {
                Console.WriteLine("Ya hay un CD en el reproductor.");
                return false;
            }
        }

    }

}
