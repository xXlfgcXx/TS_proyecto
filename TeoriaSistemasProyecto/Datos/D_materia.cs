using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class D_materia
    {
        dbDataContext db = new dbDataContext();
        public int mantenimientoMateria(E_materia mat, int num)
        {
            try
            {
                materia _mat = new materia();
                var resp = (from dato in db.empleados
                            where dato.usuario == mat._usuarioEmple
                            select dato.rol).FirstOrDefault();
                
                if (resp.ToString() =="2")
                {
                    if (num != -1)
                    {
                        _mat = db.materias.Where(val => val.codigo == mat._codigo).Single<materia>();
                    }

                    _mat.codigo = mat._codigo;
                    _mat.nombreM = mat._nombre;
                    _mat.usuarioEmple = mat._usuarioEmple;

                    if (num == -1)
                    {
                        _mat.estado = 1;
                        db.materias.InsertOnSubmit(_mat);
                    }
                    db.SubmitChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<E_materia> listaMaterias()
        {
            List<E_materia> listEst = new List<E_materia>();
            var txt = from dato in db.materias
                      join dato2 in db.empleados
                      on dato.usuarioEmple equals dato2.usuario
                      select new {
                          dato.codigo,
                          dato.nombreM,
                          dato2.nombre,
                          dato2.apellidoMaterno,
                          dato2.apellidoPaterno,
                          dato2.email,
                          dato2.usuario
                      };
            var lista = txt.ToList();
            foreach (var _mat in lista)
            {
                listEst.Add(new E_materia()
                {
                    _nombre = _mat.nombreM,
                    _codigo = _mat.codigo,
                    _usuarioEmple = _mat.usuario,
                    _nombreProf = _mat.nombre,
                    _ape1Prof = _mat.apellidoMaterno,
                    _Ape2Prof = _mat.apellidoPaterno,
                    _emailProf = _mat.email
                });
            }
            return listEst;
        }
        public List<E_materia> BuscarMat(string texto)
        {
            List<E_materia> listEmple = new List<E_materia>();
            var txt = from dato in db.materias
                      where SqlMethods.Like(dato.codigo.ToString(), "%" + texto + "%")
                      select dato;
            var lista = txt.ToList();
            foreach (var _mat in lista)
            {
                listEmple.Add(new E_materia()
                {
                    _nombre = _mat.nombreM,
                    _codigo = _mat.codigo,
                    _usuarioEmple = _mat.usuarioEmple
                });
            }
            return listEmple;
        }
        public List<E_empleado> obtenerDatosProf()
        {
            List<E_empleado> listEmple = new List<E_empleado>();
            var txt = from dato in db.empleados
                      where dato.rol == 2
                      select dato;
            var lista = txt.ToList();
            foreach (var _emple in lista)
            {
                listEmple.Add(new E_empleado()
                {
                    _nombre = _emple.nombre,
                    _apellidoUno = _emple.apellidoMaterno,
                    _apellidoDos = _emple.apellidoPaterno,
                    _email = _emple.email,
                    _telefono = _emple.telefono,
                    _usuario = _emple.usuario,
                    _fechaNace = _emple.fechaNace.ToString()
                });
            }
            return listEmple;
        }
        public List<E_empleado> BuscarProf(string texto)
        {
            List<E_empleado> listEmple = new List<E_empleado>();
            var txt = from dato in db.empleados
                      where SqlMethods.Like(dato.usuario.ToString(), "%" + texto + "%") && dato.rol == 2
                      select dato;
            var lista = txt.ToList();
            foreach (var _emple in lista)
            {
                listEmple.Add(new E_empleado()
                {
                    _nombre = _emple.nombre,
                    _apellidoUno = _emple.apellidoMaterno,
                    _apellidoDos = _emple.apellidoPaterno,
                    _email = _emple.email,
                    _telefono = _emple.telefono,
                    _usuario = _emple.usuario
                });
            }
            return listEmple;
        }
        public E_materia obtenerDatosMat(int cod)
        {
            E_materia obj = db.materias.Where(val => val.codigo == cod).Select(val => new E_materia()
            {
                _codigo = val.codigo,
                _nombre = val.nombreM,
                _usuarioEmple = val.usuarioEmple
            }).FirstOrDefault();
            return obj;
        }

        public List<E_matricula> obtenerMateriaProf(string usu)
        {
            List<E_matricula> _list = new List<E_matricula>();
            var txt = from dato in db.matriculas
                      join dato2 in db.materias
                      on dato.codigoMateria equals dato2.codigo
                      join dato3 in db.estudiantes
                      on dato.usuarioEst equals dato3.usuario
                      join dato4 in db.empleados
                      on dato2.usuarioEmple equals dato4.usuario
                      where dato2.usuarioEmple == usu
                      select new
                      {
                          dato2.nombreM,
                          dato2.codigo,
                          dato3.nombreE,
                          dato3.apellidoMaterno,
                          dato3.apellidoPaterno,
                          dato3.identificacion,
                          dato3.email,
                          dato4.usuario, 
                          dato4.nombre
                      };
            var lista = txt.ToList();
            foreach (var item in lista)
            {
                _list.Add(new E_matricula()
                {
                    _codigoMat = item.codigo,
                    _nombreMat = item.nombreM,
                    _nombreEst = item.nombreE,
                    _ape1 = item.apellidoMaterno,
                    _ape2 = item.apellidoPaterno,
                    _ideEst = item.identificacion,
                    _email = item.email,
                    _usuEst= item.usuario,
                    _nombreProf = item.nombre
                });
            }
            return _list;
        }
        public List<E_matricula> filtroNombreMateria(string usu,string codMat)
        {
            List<E_matricula> _list = new List<E_matricula>();
            var txt = from dato in db.matriculas
                      join dato2 in db.materias
                      on dato.codigoMateria equals dato2.codigo
                      join dato3 in db.estudiantes
                      on dato.usuarioEst equals dato3.usuario
                      where dato2.usuarioEmple == usu && dato2.nombreM == codMat
                      select new
                      {
                          dato2.nombreM,
                          dato2.codigo,
                          dato3.nombreE,
                          dato3.apellidoMaterno,
                          dato3.apellidoPaterno,
                          dato3.identificacion,
                          dato3.email
                      };
            var lista = txt.ToList();
            foreach (var item in lista)
            {
                _list.Add(new E_matricula()
                {
                    _codigoMat = item.codigo,
                    _nombreMat = item.nombreM,
                    _nombreProf = item.nombreE,
                    _ape1 = item.apellidoMaterno,
                    _ape2 = item.apellidoPaterno,
                    _email = item.email
                });
            }
            return _list;
        }
    }
}
