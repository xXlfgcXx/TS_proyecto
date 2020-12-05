using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class D_menuPrincipal
    {
        dbDataContext db = new dbDataContext();
        List<empleado> _emple = new List<empleado>();
        public E_empleado obtenerDatos(string usu)
        {
            E_empleado obj = db.empleados.Where(val => val.usuario == usu || val.email == usu).Select(val => new E_empleado()
            {
                _nombre = val.nombre,
                _apellidoUno = val.apellidoMaterno,
                _apellidoDos = val.apellidoPaterno,
                _identificacion = val.identificacion,
                _direccion = val.direccion,
                _fechaNace = val.fechaNace.ToString(),
                _email = val.email,
                _telefono = val.telefono,
                _rol = val.rol,
                _usuario = val.usuario,
                _contrasena = val.contrasena,
            }).FirstOrDefault();
            return obj;
        }

        public int mantenimientoEmpleado(E_empleado emple, int num)
        {
            try
            {
                empleado _emple = new empleado();
                if (num != -1)
                {
                    _emple = db.empleados.Where(val => val.usuario == emple._usuario).Single<empleado>();
                }
                _emple.nombre = emple._nombre;
                _emple.apellidoMaterno = emple._apellidoUno;
                _emple.apellidoPaterno = emple._apellidoDos;
                _emple.identificacion = emple._identificacion;
                _emple.direccion = emple._direccion;
                _emple.fechaNace = Convert.ToDateTime(emple._fechaNace);
                _emple.direccion = emple._direccion;
                _emple.telefono = emple._telefono;
                _emple.email = emple._email;
                _emple.rol = Convert.ToInt32(emple._rol);
                _emple.usuario = emple._usuario;
                _emple.contrasena = emple._contrasena;
                if (num == -1)
                {
                    _emple.estado = 1;
                    db.empleados.InsertOnSubmit(_emple);
                }
                db.SubmitChanges();
                return 1;
        }
            catch(Exception ex)
            {
                return 0;
            }
}
        public List<E_empleado> listaEmpleados()
        {
            List<E_empleado> listEmple = new List<E_empleado>();
            var txt = from dato in db.empleados
                      select dato;
            var lista = txt.ToList(); 
            foreach(var _emple in lista)
            {
                listEmple.Add(new E_empleado()
                {
                    _nombre = _emple.nombre,
                    _apellidoUno = _emple.apellidoMaterno, 
                    _apellidoDos = _emple.apellidoPaterno,
                    _identificacion = _emple.identificacion,
                    _direccion = _emple.direccion,
                    _fechaNace = _emple.fechaNace.ToString(),
                    _email = _emple.email,
                    _telefono = _emple.telefono,
                    _usuario = _emple.usuario,
                    _contrasena = _emple.contrasena,
                });
            }
            return listEmple;
        }
        public List<E_empleado> BuscarEmpleado(string texto)
        {
            List<E_empleado> listEmple = new List<E_empleado>();
            var txt = from dato in db.empleados
                      where SqlMethods.Like(dato.identificacion,"%"+texto+"%")
                      select dato;
            var lista = txt.ToList();
            foreach (var _emple in lista)
            {
                listEmple.Add(new E_empleado()
                {
                    _nombre = _emple.nombre,
                    _apellidoUno = _emple.apellidoMaterno,
                    _apellidoDos = _emple.apellidoPaterno,
                    _identificacion = _emple.identificacion,
                    _direccion = _emple.direccion,
                    _fechaNace = _emple.fechaNace.ToString(),
                    _email = _emple.email,
                    _telefono = _emple.telefono,
                    _usuario = _emple.usuario,
                    _contrasena = _emple.contrasena,
                });
            }
            return listEmple;
        }
        public List<E_empleado> BuscarProf(string texto)
        {
            List<E_empleado> listEmple = new List<E_empleado>();
            var txt = from dato in db.empleados
                      where SqlMethods.Like(dato.usuario, "%" + texto + "%") && dato.rol==2
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
                    _fechaNace = _emple.fechaNace.ToString()
                });
            }
            return listEmple;
        }
    }
}
