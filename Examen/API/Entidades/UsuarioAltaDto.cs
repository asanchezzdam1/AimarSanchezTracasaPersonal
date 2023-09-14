using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioAltaDto
    {
        public string nombre { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public string? telefono { get; set; }
    }
}
