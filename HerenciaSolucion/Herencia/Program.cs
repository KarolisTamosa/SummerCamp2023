using System;
using System.Threading;



namespace Herencia
{
    internal class Program
    {
        public static int GlobalTurnID { get; set; }

        static void Main(string[] args)
        {
            var empleado = new Empleado();
            var jose = new Administrador(nombre: "Jose", plaza: false, numeroPlaza: null);
            var maria = new Trabajador(nombre: "Maria", GlobalTurnID);
            var rodrigo = new Trabajador(nombre: "Rodrigo", GlobalTurnID);
            var josue = new Trabajador(nombre: "Josue", GlobalTurnID);
            var mirlo = new Trabajador(nombre: "Mirlo", GlobalTurnID);
            var Eustakio = new Administrador(nombre: "Eustakio", plaza: true, numeroPlaza: 45);
            var johny = new Empleado(nombre:"johny",GlobalTurnID);

            jose.Jefe = maria;

            var empleados = new Empleado[] { empleado, jose, maria, rodrigo, josue, mirlo, johny };

            var listaEmpleados = empleados.Where(empleado => empleado.Nombre.StartsWith("J", StringComparison.OrdinalIgnoreCase))
                                         .OrderBy(empleado => empleado.Nombre);

            foreach (var emp in listaEmpleados)
            {
                emp.CalculoDeVacaciones();
            }


            Console.WriteLine(jose.ToString());
            Console.WriteLine(maria.ToString());
            Console.WriteLine(rodrigo.ToString());
            Console.WriteLine(josue.ToString());
            Console.WriteLine(mirlo.ToString());
            Console.WriteLine(Eustakio.ToString());
            Console.WriteLine(johny.ToString());


            if (jose.Plaza) {
                try
                {
                    Console.WriteLine(jose.PlazaParking());
                }
                catch (ErrorBaseDatos ex)
                {
                    Console.WriteLine(ex.FechaHora + ex.mensaje);
                }
            }
        }
    }
}