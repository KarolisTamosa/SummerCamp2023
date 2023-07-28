using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LeerYEscribir
{
    public interface IArchivoJson : IAlmacenamiento
    {
        void Deserializar();
        void Serializar();
    }
}