using Entidades;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear y asignar propiedades mediante instancias. Son diferentes formas de asignar propiedades.
            var jose = new Empleado();
            jose.Nombre = "Jose";
            jose.FechaAlta = new DateTime(2021, 01, 05);
            jose.Salario = 210000;
            jose.Alta = true;


            var maria = new Empleado()
            {
                Nombre = "Maria",
                FechaAlta = new DateTime(2022, 03, 15),
                Salario = 5550000,
                Alta = true
            };


            //Esta forma es con el constructor
            var juan = new Empleado("juan", 266000, new DateTime(2023, 03, 01), true);

            var numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8 };



        }
    }
}