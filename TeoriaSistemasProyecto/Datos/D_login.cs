using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Datos
{
    public class D_login
    {
        dbDataContext db = new dbDataContext();
        public string _login(string usu, string contra)
        {
            try
            {
                string num = "";
                var txt = (from dato in db.empleados
                           where ((dato.usuario == usu && dato.contrasena == contra)&& dato.estado==1) ||
                           ((dato.email == usu && dato.contrasena == contra) && dato.estado == 1)
                           select dato.rol).FirstOrDefault();
                num = txt.ToString();
                if(num== "0" || num=="")
                {
                    var txt2 = (from dato in db.estudiantes
                               where ((dato.usuario == usu && dato.contrasena == contra) && dato.estado == 1) ||
                               ((dato.email == usu && dato.contrasena == contra) && dato.estado==1)
                               select dato.rol).FirstOrDefault();
                    num = txt2.ToString();
                }
                return num;
            }catch(Exception ex)
            {
                return "-1";
            }
        }

        public void insertCodLog (string email,string numeroRandom)
        {
            empleado _empleado = db.empleados.Where(val => val.email == email).Single<empleado>();
            _empleado.codigoLog = numeroRandom.Trim();
            db.SubmitChanges();
        }
        public int verificarUsuario(string usu)
        {
            try
            {
                var txt = (from dato in db.empleados
                           where dato.email == usu
                           select dato.estado).FirstOrDefault();
                string resp = txt.ToString();
                if (resp == "1")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
        public int verificarCod (string email,string cod)
        {
            try
            {
                var txt = (from dato in db.empleados
                           where dato.email == email
                           select dato.codigoLog).FirstOrDefault();
                if (txt != null)
                {
                    string _cod = txt.ToString();
                    if (_cod != "" || _cod != null)
                    {
                        if (_cod == cod)
                        {
                            return 1;
                        }
                        else { return -1; }
                    }
                    else
                    {
                        return 1;
                    }
                }
                else { return -1; }
                
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void nuevaContra(string email, string contra)
        {
            empleado _empleado = db.empleados.Where(val => val.email == email).Single<empleado>();
            _empleado.contrasena = contra;
            db.SubmitChanges();
        }
    }
}
