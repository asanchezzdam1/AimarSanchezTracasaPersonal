using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploHerencia
{
    public class Trabajador : Empleado
    {
        public string turno{ get; set; }
        public bool externo{ get; set; }
        public string queEmpresa{ get; set; }
        public Trabajador(string nombre) : base(nombre)
        {
        }
        public Trabajador(string nombre, string turno, bool externo) : base(nombre)
        {
            this.turno = turno;
            this.externo = externo;
        }
        public Trabajador(string nombre, string turno, bool externo, string queEmpresa) : base(nombre)
        {
            this.turno = turno;
            this.externo = externo;
            this.queEmpresa = queEmpresa;
        }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }
        public override string ToString()
        {
            string str = base.ToString();
            if (!externo) str += " y es trabajador de la empresa";
            else str += " y es trabajador de la subcontrata: " + queEmpresa;
            return str;
        }
    }
}