using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace Datos
{
    public class D_matricula
    {
        dbDataContext db = new dbDataContext(); 
        public int InsertaMatricula(E_matricula matricula)
        { 
            matricula mat = new matricula();
            string resp = ""; 
            var txt = (from dato in db.matriculas
                       where dato.codigoMateria == matricula._codigoMat && dato.usuarioEst == matricula._usuEst
                       select dato.numero).FirstOrDefault();
            resp = txt.ToString();
            if (resp != "" || resp != null)
            {
                var txt2 = (from dato2 in db.matriculas
                           where dato2.codigoMateria == matricula._codigoMat
                           select dato2.codigoMateria).Count();
                int total = Convert.ToInt32(txt2);

                if (total < 35)
                {
                    mat.codigoMateria = matricula._codigoMat;
                    mat.usuarioEst = matricula._usuEst;
                    db.matriculas.InsertOnSubmit(mat);
                    db.SubmitChanges();
                    return 1; //exito
                }
                else
                {
                    return 3; //no hay cupo 
                }

            }
            else
            {
                return 4;//ya se encuentra matriculado 
            }

        }
    }
}
