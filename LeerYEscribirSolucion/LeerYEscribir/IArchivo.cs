﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LeerYEscribir
{
    public interface IArchivo
    {
        int NombreArchivo { get; set; }
    }
}