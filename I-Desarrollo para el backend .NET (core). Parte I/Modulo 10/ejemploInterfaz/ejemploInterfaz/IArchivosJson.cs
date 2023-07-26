using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploInterfaz
{
    public interface IArchivosJson : IAlmacenamiento, Modelo.IAlmacenamiento
    {
        object Deserializar(string json);

        void Serializar(object json);
    }
}