using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_empleado
    {

        public string _nombre { get; set; }
        public string _apellidoUno { get; set; }
        public string _apellidoDos { get; set; }
        public string _identificacion { get; set; }
        public string _fechaNace { get; set; }
        public string _direccion { get; set; }
        public string _email { get; set; }
        public string _telefono { get; set; }
        public int _rol { get; set; }
        public string _usuario { get; set; }
        public string _contrasena { get; set; }

        public int _estado { get; set; }

    }
}
