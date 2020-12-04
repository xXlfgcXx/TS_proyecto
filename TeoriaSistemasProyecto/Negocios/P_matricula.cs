using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public class P_matricula
    {
        D_estudiante _est = new D_estudiante();
        D_materia _mat = new D_materia();
        D_menuPrincipal _emple = new D_menuPrincipal();
        D_matricula _matri = new D_matricula();
        public E_estudiante buscarEst(string txt)
        {
            return _est.obtenerDatosEst(txt);
        }
        public E_materia ObtenerMat(int txt)
        {
            return _mat.obtenerDatosMat(txt);
        }
        public E_empleado obtenerProf(string txt)
        {
            E_empleado _EProf = new E_empleado();
            List<E_empleado> _prof = new List<E_empleado>();
            _prof = _emple.BuscarProf(txt);
            _EProf._nombre = _prof[0]._nombre;
            _EProf._apellidoUno = _prof[0]._apellidoUno;
            _EProf._apellidoDos = _prof[0]._apellidoDos;
            _EProf._email = _prof[0]._email;
            return _EProf;
        }
        public int insertaMatricula(E_matricula mat)
        {
            return _matri.InsertaMatricula(mat);
        }
    }
}
