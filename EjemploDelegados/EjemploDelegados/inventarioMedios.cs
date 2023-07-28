using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class inventarioMedios
    {
        public delegate bool ProbarMediosDelegado();

        public delegate string InfoMedioDelegado(string id);


       public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado)
       {
                var resultado = probarMediosDelegado();

                if (resultado)
                {
                    Console.WriteLine("El medio funciona");
                    Console.WriteLine("Hay que guardarlo");
                }
                else { 
                    Console.WriteLine("El medio no funciona");
                }
   
       }

        public string ObtenerInformacionMedio(InfoMedioDelegado infoMedioDelegado, string id)
        {
            return infoMedioDelegado(id);
        }
    }

   }
