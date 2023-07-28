using System;
using System.IO;
using Newtonsoft.Json;
namespace LeerYEscribir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Menú ----------");
            Console.WriteLine("1. Serializar y escribir el archivo JSON");
            Console.WriteLine("2. Leer el archivo JSON y deserializarlo");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese el número de opción: ");

            string opcion = Console.ReadLine();

            string archivo = "";

            if (opcion == "1" || opcion == "2")
            {
                Console.Write("Ingrese la ruta del archivo JSON: ");
                archivo = Console.ReadLine();
            }

            IArchivoJson archivoJson = new ArchivoJson() { NombreArchivo = archivo };

            switch (opcion)
            {
                case "1":
                    archivoJson.Serializar();
                    break;
                case "2":
                    try
                    {
                        // Leer el contenido del archivo JSON
                        string json = File.ReadAllText(archivo);

                        // Deserializar el JSON en un objeto C#
                        var datos = JsonConvert.DeserializeObject<Datos>(json);

                        // Utilizar los datos deserializados
                        Console.WriteLine($"Nombre: {datos.nombre}, Edad: {datos.edad}, Ciudad: {datos.ciudad}");
                        Console.WriteLine("Hobbies:");
                        foreach (var hobby in datos.hobbies)
                        {
                            Console.WriteLine(hobby);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al leer o deserializar el archivo JSON: {ex.Message}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida (1-3).");
                    break;
            }

            // Agregar una pausa antes de finalizar
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

public class Datos
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string ciudad { get; set; }
    public bool casado { get; set; }
    public string[] hobbies { get; set; }
}
