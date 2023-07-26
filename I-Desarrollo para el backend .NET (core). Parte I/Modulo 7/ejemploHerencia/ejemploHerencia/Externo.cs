using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploHerencia
{
    public class Externo : Empleado
    {
        public string empresa{ get; set; }
        public Externo(string nombre) : base(nombre)
        {
        }        
        public Externo(string nombre, string empresa) : base(nombre)
        {
            this.empresa = empresa;
        }
    }
}