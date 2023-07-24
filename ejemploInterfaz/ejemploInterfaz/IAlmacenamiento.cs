using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public interface IAlmacenamiento : IArchivo, ejemploInterfaz.IArchivo
    {
        void Leer(string archivo);

        void Escribir(string archivo);
    }
}