namespace CalculadoraImpuestoDeCirculacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Audi = new Coche()
            {
                Nombre = "Audi",
                PrecioBase = 1000,
                AnoDelCoche = new DateTime(2023, 10, 09).Year,
            };
            Audi.fijarEtiqueta(Coche.Etiqueta.CERO);



            var Peugeot = new Coche()
            {
                Nombre = "Peugeot",
                PrecioBase = 1000,
                AnoDelCoche = new DateTime(2022, 10, 09).Year
            };
            Peugeot.fijarEtiqueta(Coche.Etiqueta.ECO);



            var Ford = new Coche()
            {
                Nombre = "Ford",
                PrecioBase = 1000,
                AnoDelCoche = new DateTime(1990, 10, 09).Year
            };

            var Subaru = new Coche()
            {
                Nombre = "Subaru",
                PrecioBase = 1000,
                AnoDelCoche = new DateTime(1875, 10, 09).Year
            };
            Subaru.fijarEtiqueta(Coche.Etiqueta.C);

            var McLaren = new Coche()
            {
                Nombre = "McLaren",
                PrecioBase = 1000,
                AnoDelCoche = new DateTime(2007, 10, 09).Year
            };
            Subaru.fijarEtiqueta(Coche.Etiqueta.B);

            List<Coche> listaVehiculos = new List<Coche>();
            listaVehiculos.Add(Audi);
            listaVehiculos.Add(Peugeot);
            listaVehiculos.Add(Ford);
            listaVehiculos.Add(Subaru);
            listaVehiculos.Add(McLaren);

            foreach (var vehiculo in listaVehiculos)
            {
                double impuesto = vehiculo.CalcularImpuestoDeCirculacion();
                Console.WriteLine($"El precio total es: {vehiculo.Nombre} {vehiculo.PrecioBase + impuesto}");
                Console.WriteLine($"El precio del impuesto es: {impuesto}");
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}