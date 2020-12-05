using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 
namespace Datos
{
    public class D_estudiante
    {
        dbDataContext db = new dbDataContext();
        public int mantenimientoEstudiante(E_estudiante est, int num)
        {
            try
            {
                estudiante _est = new estudiante();
                if (num != -1)
                {
                    _est = db.estudiantes.Where(val => val.usuario == est._usuario).Single<estudiante>();
                }
                _est.nombreE = est._nombre;
                _est.apellidoMaterno = est._ape1;
                _est.apellidoPaterno = est._ape2;
                _est.identificacion = est._identificacion;
                _est.direccion = est._direccion;
                _est.fechaNaci = Convert.ToDateTime(est._fechaNac);
                _est.direccion = est._direccion;
                _est.telefono = est._telefono;
                _est.email = est._email;
                _est.rol = Convert.ToInt32(est._rol);
                _est.usuario = est._usuario;
                _est.contrasena = est._contrasena;
                if (num == -1)
                {
                    _est.estado = 1;
                    db.estudiantes.InsertOnSubmit(_est);
                }
                db.SubmitChanges();
                return 1;
        }
            catch (Exception ex)
            {
                return 0;
            }
}
        public List<E_estudiante> listaEstudiantes()
        {
            List<E_estudiante> listEst = new List<E_estudiante>();
            var txt = from dato in db.estudiantes
                      select dato;
            var lista = txt.ToList();
            foreach (var _est in lista)
            {
                listEst.Add(new E_estudiante()
                {
                    _nombre = _est.nombreE,
                    _ape1 = _est.apellidoMaterno,
                    _ape2 = _est.apellidoPaterno,
                    _identificacion = _est.identificacion,
                    _direccion = _est.direccion,
                    _fechaNac = _est.fechaNaci.ToString(),
                    _email = _est.email,
                    _telefono = _est.telefono,
                    _usuario = _est.usuario,
                    _contrasena = _est.contrasena,
                    _rol = "Estudiante"
                });
            }
            return listEst;
        }
        public List<E_estudiante> BuscarEst(string texto)
        {
            List<E_estudiante> listEmple = new List<E_estudiante>();
            var txt = from dato in db.estudiantes
                      where SqlMethods.Like(dato.identificacion, "%" + texto + "%")
                      select dato;
            var lista = txt.ToList();
            foreach (var _est in lista)
            {
                listEmple.Add(new E_estudiante()
                {
                    _nombre = _est.nombreE,
                    _ape1 = _est.apellidoMaterno,
                    _ape2 = _est.apellidoPaterno,
                    _identificacion = _est.identificacion,
                    _direccion = _est.direccion,
                    _fechaNac = _est.fechaNaci.ToString(),
                    _email = _est.email,
                    _telefono = _est.telefono,
                    _usuario = _est.usuario,
                    _contrasena = _est.contrasena,
                    _rol = "Estudiante"
                });
            }
            return listEmple;
        }
        public E_estudiante obtenerDatosEst(string usu)
        {
            E_estudiante obj = db.estudiantes.Where(val => val.usuario == usu || val.email == usu).Select(val => new E_estudiante()
            {
                _nombre = val.nombreE,
                _ape1 = val.apellidoMaterno,
                _ape2 = val.apellidoPaterno,
                _identificacion = val.identificacion,
                _direccion = val.direccion,
                _fechaNac = val.fechaNaci.ToString(),
                _email = val.email,
                _telefono = val.telefono,
                _rol = val.rol.ToString(),
                _usuario = val.usuario,
                _contrasena = val.contrasena,
            }).FirstOrDefault();
            return obj;
        }

        public List<E_matricula> obtenerMateriasMatriculadas(string usu)
        {
            List<E_matricula> _list = new List<E_matricula>();
            var txt = from dato in db.matriculas
                      join dato2 in db.materias
                      on dato.codigoMateria equals dato2.codigo
                      join dato3 in db.empleados
                      on dato2.usuarioEmple equals dato3.usuario
                      join dato4 in db.estudiantes 
                      on dato.usuarioEst equals dato4.usuario
                      where dato.usuarioEst == usu
                      select new
                      {
                          dato2.codigo,
                          dato2.nombreM,
                          dato3.nombre,
                          dato3.apellidoMaterno,
                          dato3.apellidoPaterno,
                          dato3.email,
                          dato4.usuario,
                          dato4.nombreE,
                          dato4.identificacion
                      };
            var lista = txt.ToList();
            foreach (var item in lista)
            {
                _list.Add(new E_matricula()
                {
                    _codigoMat = item.codigo,
                    _nombreMat = item.nombreM,
                    _nombreProf = item.nombre,
                    _ape1 = item.apellidoMaterno,
                    _ape2 = item.apellidoPaterno,
                    _email = item.email,
                    _usuEst = item.usuario,
                    _nombreEst = item.nombreE,
                    _ideEst = item.identificacion
                });
            }
            return _list;
        }
    }
}
