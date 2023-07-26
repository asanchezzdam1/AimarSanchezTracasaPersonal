using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Monedas    {        public Moneda[] ListaMonedas { get; set; }    }    public class Moneda    {        public string nombre { get; set; }        public string codigo { get; set; }        public float valorEnDolares { get; set; }

    }
}
