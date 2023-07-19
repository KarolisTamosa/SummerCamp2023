namespace ConstructorDeCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? eleccion = string.Empty;
            string marca = string.Empty;
            string modelo = string.Empty;
            string ano = string.Empty;
            string color = string.Empty;

            while (eleccion != "e" && eleccion != "E")
            {
                Console.Write("Pulsa (H) para crear tu coche ");
                eleccion = Console.ReadLine();


                switch (eleccion)
                {
                    case "H":
                    case "h":
                        var coche = new coche() { modelo = modelo, marca = marca, ano = ano, color = color };
                        Console.Write("Escribe la marca de coche que quieres ");
                        coche.marca = Console.ReadLine();
                        Console.Write("Escribe el año de tu coche ");
                        coche.ano = Console.ReadLine();
                        Console.Write("Escribe el modelo de tu coche ");
                        coche.modelo = Console.ReadLine();
                        Console.Write("Escribe el color de tu coche ");
                        coche.color = Console.ReadLine();
                        Console.WriteLine($"la marca de tu coche es: { coche.marca} && el año es { coche.ano}" +
                            $" && el modelo es { coche.modelo} && y el color es { coche.color}");
                        break;


                    case "e":
                    case "E":
                        break;


                    default:
                        Console.WriteLine("letra incorrecta");
                        break;
                }

            }
        }
    }
}