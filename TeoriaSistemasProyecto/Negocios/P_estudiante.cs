using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public class P_estudiante
    {
        D_estudiante _est = new D_estudiante(); 
        public List<E_matricula> obtenerMaterias(string usu)
        {
            return _est.obtenerMateriasMatriculadas(usu);
        }
    }
}
