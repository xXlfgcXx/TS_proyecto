using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public class P_menuPrincipal
    {
        D_menuPrincipal _menu = new D_menuPrincipal();
        D_estudiante _DEst = new D_estudiante();
        D_materia _DMat = new D_materia();
        public E_empleado obtenerDatos(string usu)
        {
            return _menu.obtenerDatos(usu);
        }

        public int mantenimientoEmple(E_empleado emple, int numero)
        {
            return _menu.mantenimientoEmpleado(emple, numero);
        }

        public List<E_empleado> envioLista()
        {
            return _menu.listaEmpleados();
        }

        public List<E_empleado> buscarEmpleado(string texto)
        {
            return _menu.BuscarEmpleado(texto);
        }

        public int insertaEstudiante(E_estudiante est, int numero)
        {
            return _DEst.mantenimientoEstudiante(est, numero);
        }

        public List<E_estudiante> envioListaEstudiante()
        {
            return _DEst.listaEstudiantes();
        }
        public List<E_estudiante> BuscarEstudiante(string texto)
        {
            return _DEst.BuscarEst(texto);
        }

        public int insertaMateria(E_materia mat, int numero)
        {
            return _DMat.mantenimientoMateria(mat, numero);
        }

        public List<E_materia> ListaMaterias()
        {
            return _DMat.listaMaterias();
        }

        public List<E_materia> buscarMateria(string texto)
        {
            return _DMat.BuscarMat(texto);
        }

        public List<E_empleado> listaProfesores()
        {
            return _DMat.obtenerDatosProf();
        }

        public List<E_empleado> buscaProfM(string texto)
        {
            return _DMat.BuscarProf(texto);
        }
        public E_estudiante obtenerDatosEst(string texto)
        {
            return _DEst.obtenerDatosEst(texto);
        }
        public List<E_matricula> obtenerMateriaProf(string usu)
        {
            return _DMat.obtenerMateriaProf(usu);
        }
        public List<E_matricula> filtrarMaterias(string usu,string codMat)
        {
            return _DMat.filtroNombreMateria(usu,codMat);
        }

    }
}
