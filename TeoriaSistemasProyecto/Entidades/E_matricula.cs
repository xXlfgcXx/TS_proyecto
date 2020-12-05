using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_matricula
    {

        public int? _codigoMat { get; set; }
        public string _nombreMat { get; set; }
        public string _nombreProf { get; set; }
        public string _ape1 { get; set; }
        public string _ape2 { get; set; }
        public string _email { get; set; }
        public string _usuEst { get; set; }
        public string _nombreEst { get; set; }
        public string _ideEst { get; set; }
    } 
}
