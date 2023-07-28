using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LeerYEscribir
{
    public interface IAlmacenamiento : IArchivo
    {
        void Escribir(string contenido);
        string Leer();
    }

    public class ArchivoJson : IArchivoJson
    {
        public string NombreArchivo { get; set; }
        int IArchivo.NombreArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Deserializar()
        {
            string contenido = Leer();
            DocumentoJson documento = JsonConvert.DeserializeObject<DocumentoJson>(contenido);
            Console.WriteLine("Deserialización completa.");
            // Aquí puedes usar el objeto "documento" como desees
        }

        public void Serializar()
        {
            DocumentoJson documento = new DocumentoJson();
            string contenido = JsonConvert.SerializeObject(documento);
            Escribir(contenido);
            Console.WriteLine("Serialización y escritura completas.");
        }

        public void Escribir(string contenido)
        {
            File.WriteAllText(NombreArchivo, contenido);
        }

        public string Leer()
        {
            return File.ReadAllText(NombreArchivo);
        }
    }
}