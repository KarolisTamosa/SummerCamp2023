namespace ConversorDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? elecion = string.Empty;

            while (elecion != "Q" && elecion != "q")
            {
                Console.WriteLine("******************************************************************************************************");
                Console.WriteLine("Para cambiar de Euros a USD pulsa (E) ");
                Console.WriteLine("Para cambiar de USD a euros palsa (U) ");
                Console.WriteLine("Para cambiar de Euros a libras palsa (EL) ");
                Console.WriteLine("Para cambiar de Libras a Euros palsa (L) ");
                Console.WriteLine("para salir pulsa (Q) ");
                Console.WriteLine("******************************************************************************************************");
                elecion = Console.ReadLine();
                double eurosAdolares, dolaresAEuros, euroALibras, LibraAEuros = 0;

                switch (elecion)
                {
                    case "E":
                    case "e":
                        Console.Write("Escribe cual es la cantidad de Euros que quiere convertir ");
                        eurosAdolares = conversor.EurosAdolares(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("******************************************************************************************************");
                        Console.WriteLine($"La conversion de euros a dolares a fecha de /////({DateTime.Now})///// es de:");
                        Console.WriteLine($"{eurosAdolares}");
                        Console.WriteLine("******************************************************************************************************");
                        break;

                    case "U":
                    case "u":
                        Console.Write("Escribe cual es la cantidad de USD que quiere convertir ");
                        dolaresAEuros = conversor.DolaresAEuros(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("******************************************************************************************************");
                        Console.WriteLine($"La conversion de USD a euros a fecha de /////({DateTime.Now})///// es de:");
                        Console.WriteLine($"{dolaresAEuros}");
                        Console.WriteLine("******************************************************************************************************");
                        break;
                    case "EL":
                    case "el":
                        Console.Write("Escribe cual es la cantidad de Euros que quiere convertir ");
                        euroALibras = conversor.EurosAlibras(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("******************************************************************************************************");
                        Console.WriteLine($"La conversion de Euros a Libras a fecha de /////({DateTime.Now})///// es de:");
                        Console.WriteLine($"{euroALibras}");
                        Console.WriteLine("******************************************************************************************************");
                        break;

                    case "l":
                    case "L":
                        Console.Write("Escribe cual es la cantidad de Libras que quiere convertir ");
                        LibraAEuros = conversor.LibrasAEuros(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("******************************************************************************************************");
                        Console.WriteLine($"La conversion de Libras a Euros a fecha de /////({DateTime.Now})///// es de:");
                        Console.WriteLine($"{LibraAEuros}");
                        Console.WriteLine("******************************************************************************************************");
                        break;

                    case "q":
                    case "Q":
                        break;
                }
            }
        }
    }
}