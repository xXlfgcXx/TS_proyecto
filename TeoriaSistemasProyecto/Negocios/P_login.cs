using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocios
{
    public class P_login
    {
        D_login log = new D_login();
        public string inicio(string usu, string contra)
        { 
            return log._login(usu,contra);
        }
        public void numRan(string usu,string num)
        {
            log.insertCodLog(usu, num);
        }

        public int verificar(string email)
        {
            return log.verificarUsuario(email);
        }
        public int verificarCod(string email,string cod)
        {
            return log.verificarCod(email, cod);
        }

        public void nuevaContrasena(string email, string contra)
        {
            log.nuevaContra(email, contra);
        }
    }
}
