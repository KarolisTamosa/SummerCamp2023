using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class tocadiscos
    {
        public bool discoColocado = false;

        public tocadiscos()
        {
            Console.WriteLine("Bienvenido al Tocadiscos");
        }

        public bool InsertarDisco()
        {
            if (!discoColocado)
            {
                Console.WriteLine("1. Abre la tapa del tocadiscos");
                Console.WriteLine("2. Coloca el disco de vinilo sobre el plato giratorio.");
                Console.WriteLine("3. Cierra la tapa del tocadiscos.");

                discoColocado = true;
                Console.WriteLine("Disco insertado correctamente.");
                return true;
            }
            else
            {
                Console.WriteLine("Ya hay un disco de vinilo en el tocadiscos.");
                return false;
            }
        }

        public string ObtenerCancionesDisco(string id)
        {
            return "Lista de canciones en la contraportada";
        
        }
    }
}
