using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;
using DocumentFormat.OpenXml.Drawing;

namespace Grafico.Folder_Menu
{
    public partial class G_menuAdmin : Form
    {
        P_menuPrincipal _proceMenu = new P_menuPrincipal();
        E_empleado _empleado = new E_empleado();
        P_matricula _matricula = new P_matricula();
        E_matricula _mat = new E_matricula();
        P_matricula _pMat = new P_matricula();
        public G_menuAdmin()
        {
            InitializeComponent();
        }
        private void G_menuAdmin_Load(object sender, EventArgs e)
        {
            cargaUsuario(Folder_Login.G_Login.usuario);
            dgv_listaE.DataSource = _proceMenu.envioLista();
            dgv_listaEst.DataSource = _proceMenu.envioListaEstudiante();
            dgv_materias.DataSource = _proceMenu.ListaMaterias();
            dgv_listaProfM.DataSource = _proceMenu.listaProfesores();
        }

        private void btn_docentes_Click(object sender, EventArgs e)
        {
            p_docentes.Show();
            p_estudiantes.Hide();
            p_materias.Hide();
            p_perfil.Hide();
            p_matricula.Hide();
        }
            
        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            p_estudiantes.Show();
            p_docentes.Hide();
            p_materias.Hide();
            p_perfil.Hide();
            p_matricula.Hide();
        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            p_materias.Show();
            p_docentes.Hide();
            p_estudiantes.Hide();
            p_perfil.Hide();
            p_matricula.Hide();
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            p_perfil.Show();
            p_materias.Hide();
            p_docentes.Hide();
            p_estudiantes.Hide();
            p_matricula.Hide();
        }

        private void btn_RealizarM_Click(object sender, EventArgs e)
        {
            p_matricula.Show();
            p_perfil.Hide();
            p_materias.Hide();
            p_docentes.Hide();
            p_estudiantes.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Folder_Login.G_Login g_log = new Folder_Login.G_Login();
            this.Hide();
            g_log.Show();
        }

        public void cargaUsuario(string txt)
        {
            E_empleado emple = new E_empleado();
            emple = _proceMenu.obtenerDatos(txt);
            string nom = emple._nombre;
            lbl_nombre.Text = nom.ToUpper();
            lbl_nombre.Visible = true;
            #region carga objeto
            txt_nombreE.Text = emple._nombre;
            txt_apellidoUnoE.Text = emple._apellidoUno;
            txt_apellidoDosE.Text = emple._apellidoDos;
            txt_direccionE.Text = emple._direccion;
            txt_emailE.Text = emple._email;
            msk_fechaNacEN.Text = emple._fechaNace;
            msk_ideEN.Text = emple._identificacion;
            msk_telefonoEN.Text = emple._telefono;
            if (emple._rol == 1) { txt_rolE.Text = "Administrativo."; } else
                if(emple._rol == 2) { txt_rolE.Text = "Docente."; } 
            txt_usuE.Text = emple._usuario;
            txt_contraE.Text = emple._contrasena;
            lbl_rol.Text = txt_rolE.Text;
            lbl_rol.Visible = true;
            #endregion
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            #region habilitar textBox
            txt_nombreE.Enabled = true;
            txt_apellidoUnoE.Enabled = true;
            txt_apellidoDosE.Enabled = true;
            txt_direccionE.Enabled = true;
            msk_telefonoEN.Enabled = true;
            txt_contraE.Enabled = true;
            txt_emailE.Enabled = true;
            #endregion

            btn_modificar.Visible = false;
            btn_guardar.Visible = true; 
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                #region validaciones 
                bool _resultado = false;
                bool _estado = true;
                bool _estado2 = true;
                bool _estado3 = true;
                bool _estado4 = true;
                bool _estado5 = true;
                foreach (char i1 in txt_nombreE.Text)
                {
                    if (char.IsDigit(i1))
                    {
                        _estado = false;
                        break;
                    }
                }
                if (_estado == false)
                {
                    error1.SetError(txt_nombreE, "El nombre no puede contener numeros.");
                }
                else
                {
                    error1.Clear();
                    _estado = true;
                }

                foreach (char i2 in txt_apellidoUnoE.Text)
                {
                    if (char.IsDigit(i2))
                    {
                        _estado2 = false;
                        break;
                    }
                }
                if (_estado2 == false)
                {
                    error2.SetError(txt_apellidoUnoE, "El apellido no puede contener numeros.");
                }
                else
                {
                    error2.Clear();
                    _estado2 = true;
                }

                foreach (char i3 in txt_apellidoDosE.Text)
                {
                    if (char.IsDigit(i3))
                    {
                        _estado3 = false;
                        break;
                    }
                }
                if (_estado3 == false)
                {
                    error3.SetError(txt_apellidoDosE, "El apellido no puede contener numeros.");
                }
                else
                {
                    error3.Clear();
                    _estado3 = true;
                }
                if (txt_usuE.TextLength < 8)
                {
                    error4.SetError(txt_usuE, "El usuario debe ser mayor a 8 caracteres.");
                    _estado5 = false;
                }
                else
                {
                    error4.Clear();
                    _estado5 = true;

                }
                if (txt_contraE.TextLength < 8)
                {
                    error5.SetError(txt_contraE, "El usuario debe ser mayor a 8 caracteres.");
                    _estado4 = false;
                }
                else
                {
                    error5.Clear();
                    _estado4 = true;
                }

                if (_estado && _estado2 && _estado3 && _estado4 && _estado5)
                {
                    _resultado = true;
                }
                else
                {
                    _resultado = false;
                }
                #endregion

                if (_resultado)
                {
                    int resp = -1;
                    _empleado._nombre = txt_nombreE.Text;
                    _empleado._apellidoUno = txt_apellidoUnoE.Text;
                    _empleado._apellidoDos = txt_apellidoDosE.Text;
                    _empleado._identificacion = msk_ideEN.Text;
                    _empleado._fechaNace = msk_fechaNacEN.Text;
                    _empleado._email = txt_emailE.Text;
                    _empleado._telefono = msk_telefonoEN.Text;
                    _empleado._direccion = txt_direccionE.Text;
                    if (txt_rolE.Text == "Administrativo.") { _empleado._rol = 1; }
                    _empleado._usuario = txt_usuE.Text;
                    _empleado._contrasena = txt_contraE.Text;
                    resp = _proceMenu.mantenimientoEmple(_empleado, 1);
                    if (resp == 1)
                    {
                        MessageBox.Show("Guardado");
                        btn_guardar.Visible = false;
                        btn_modificar.Visible = true;
                        #region deshabilitar textBox
                        txt_nombreE.Enabled = false;
                        txt_apellidoUnoE.Enabled = false;
                        txt_apellidoDosE.Enabled = false;
                        txt_direccionE.Enabled = false;
                        msk_telefonoEN.Enabled = false;
                        txt_contraE.Enabled = false;
                        txt_emailE.Enabled = false;
                        #endregion
                        G_menuAdmin_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se ha logrado guardar");
                    }
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha logrado guardar");
            }
        }
        private void btn_registrarD_Click(object sender, EventArgs e)
        {
            try
            {
                int resp = -1;
                #region validacion
                bool _resultado = false;
                bool _estado = true;
                bool _estado2 = true;
                bool _estado3 = true;
                bool _estado4 = true;
                bool _estado5 = true;
                foreach (char i1 in txt_nombreD.Text)
                {
                    if (char.IsDigit(i1))
                    {
                        _estado = false;
                        break;
                    }
                }
                if (_estado == false)
                {
                    error1.SetError(txt_nombreD, "El nombre no puede contener numeros.");
                }
                else
                {
                    error1.Clear();
                    _estado = true;
                }

                foreach (char i2 in txt_apellidoUnoD.Text)
                {
                    if (char.IsDigit(i2))
                    {
                        _estado2 = false;
                        break;
                    }
                }
                if (_estado2 == false)
                {
                    error2.SetError(txt_apellidoUnoD, "El apellido no puede contener numeros.");
                }
                else
                {
                    error2.Clear();
                    _estado2 = true;
                }

                foreach (char i3 in txt_apellidoDosD.Text)
                {
                    if (char.IsDigit(i3))
                    {
                        _estado3 = false;
                        break;
                    }
                }
                if (_estado3 == false)
                {
                    error3.SetError(txt_apellidoDosD, "El apellido no puede contener numeros.");
                }
                else
                {
                    error3.Clear();
                    _estado3 = true;
                }
                if (txt_usuD.TextLength < 8)
                {
                    error4.SetError(txt_usuD, "El usuario debe ser mayor a 8 caracteres.");
                    _estado5 = false;
                }
                else
                {
                    error4.Clear();
                    _estado5 = true;
                    
                }
                if (txt_contraD.TextLength < 8)
                {
                    error5.SetError(txt_contraD, "El usuario debe ser mayor a 8 caracteres.");
                    _estado4 = false;
                }
                else
                {
                    error5.Clear();
                    _estado4 = true;
                }

                if (_estado && _estado2 && _estado3 && _estado4&&_estado5)
                {
                    _resultado = true;
                }
                else
                {
                    _resultado = false;
                }
                #endregion
                if (_resultado)
                {
                    _empleado._nombre = txt_nombreD.Text;
                    _empleado._apellidoUno = txt_apellidoUnoD.Text;
                    _empleado._apellidoDos = txt_apellidoDosD.Text;
                    _empleado._identificacion = msk_ideD.Text;
                    _empleado._fechaNace = msk_fechaD.Text;
                    _empleado._email = txt_emailD.Text;
                    _empleado._telefono = msk_telefonoD.Text;
                    _empleado._direccion = txt_direccionD.Text;
                    if (rb_Admin.Checked == true) { _empleado._rol = 1; }
                    else
                    if (rb_docente.Checked == true) { _empleado._rol = 2; }
                    else
                    { MessageBox.Show("Debe seleccionar un rol"); }
                    _empleado._usuario = txt_usuD.Text.Trim();
                    _empleado._contrasena = txt_contraD.Text.Trim(); ;
                    resp = _proceMenu.mantenimientoEmple(_empleado, -1);
                    if (resp == 1)
                    {
                        MessageBox.Show("Guardado");
                        G_menuAdmin_Load(sender, e);
                        txt_nombreD.Text = "";
                        txt_apellidoUnoD.Text = "";
                        txt_apellidoDosD.Text = "";
                        msk_ideD.Text = "";
                        txt_direccionD.Text = "";
                        txt_emailD.Text = "";
                        msk_telefonoD.Text = "";
                        msk_fechaD.Text = "";
                        txt_usuD.Text = "";
                        txt_contraD.Text = "";
                        rb_Admin.Checked = false;
                        rb_docente.Checked = false;

                    }
                    else
                    {
                        MessageBox.Show("No se ha logrado guardar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha logrado guardar");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txt_buscarEst_TextChanged(object sender, EventArgs e)
        {
            dgv_listaEst.DataSource = _proceMenu.BuscarEstudiante(txt_buscarEst.Text);
        }

        private void btn_guardarEst_Click(object sender, EventArgs e)
        {
            try
            {
                E_estudiante _est = new E_estudiante(); 
                int resp = -1;
                #region validaciones
                bool _resultado = false;
                bool _estado = true;
                bool _estado2 = true;
                bool _estado3 = true;
                bool _estado4 = true;
                bool _estado5 = true;
                foreach (char i1 in txt_nomEst.Text)
                {
                    if (char.IsDigit(i1))
                    {
                        _estado = false;
                        break;
                    }
                }
                if (_estado == false)
                {
                    error1.SetError(txt_nomEst, "El nombre no puede contener numeros.");
                }
                else
                {
                    error1.Clear();
                    _estado = true;
                }

                foreach (char i2 in txt_ape1Est.Text)
                {
                    if (char.IsDigit(i2))
                    {
                        _estado2 = false;
                        break;
                    }
                }
                if (_estado2 == false)
                {
                    error2.SetError(txt_ape1Est, "El apellido no puede contener numeros.");
                }
                else
                {
                    error2.Clear();
                    _estado2 = true;
                }

                foreach (char i3 in txt_ape2Est.Text)
                {
                    if (char.IsDigit(i3))
                    {
                        _estado3 = false;
                        break;
                    }
                }
                if (_estado3 == false)
                {
                    error3.SetError(txt_ape2Est, "El apellido no puede contener numeros.");
                }
                else
                {
                    error3.Clear();
                    _estado3 = true;
                }
                if (txt_usuEst.TextLength < 8)
                {
                    error4.SetError(txt_usuEst, "El usuario debe ser mayor a 8 caracteres.");
                    _estado5 = false;
                }
                else
                {
                    error4.Clear();
                    _estado5 = true;

                }
                if (txt_contraEst.TextLength < 8)
                {
                    error5.SetError(txt_contraEst, "El usuario debe ser mayor a 8 caracteres.");
                    _estado4 = false;
                }
                else
                {
                    error5.Clear();
                    _estado4 = true;
                }

                if (_estado && _estado2 && _estado3 && _estado4 && _estado5)
                {
                    _resultado = true;
                }
                else
                {
                    _resultado = false;
                }
                #endregion
                if (_resultado)
                {
                    _est._nombre = txt_nomEst.Text;
                    _est._ape1 = txt_ape1Est.Text;
                    _est._ape2 = txt_ape2Est.Text;
                    _est._identificacion = msk_ideEst.Text;
                    _est._direccion = txt_direcEst.Text;
                    _est._email = txt_emailEst.Text;
                    _est._usuario = txt_usuEst.Text;
                    _est._contrasena = txt_contraEst.Text;
                    _est._telefono = msk_telefonoEst.Text;
                    _est._fechaNac = msk_fechaEst.Text;
                    _est._rol = "3";
                    resp = _proceMenu.insertaEstudiante(_est, -1);
                    if (resp == 1)
                    {
                        MessageBox.Show("Guardado.");
                        G_menuAdmin_Load(sender, e);
                        txt_nomEst.Text ="";
                        txt_ape1Est.Text = "";
                        txt_ape2Est.Text = "";
                        msk_ideEst.Text = "";
                        txt_direcEst.Text = "";
                        txt_emailEst.Text = "";
                        txt_usuEst.Text = "";
                        txt_contraEst.Text = "";
                        msk_telefonoEst.Text = "";
                        msk_fechaEst.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se a logrado registrar");
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }
        private void txt_buscarProfM_TextChanged(object sender, EventArgs e)
        {
            dgv_listaProfM.DataSource = _proceMenu.buscaProfM(txt_buscarProfM.Text);
        }
        private void btn_guardarM_Click(object sender, EventArgs e)
        {
            insercion(sender, e, -1);
        }

        private void btn_actM_Click(object sender, EventArgs e)
        {
            insercion(sender, e, 1);
        }

        private void insercion(object sender, EventArgs e, int numero)
        {
            try
            {
                E_materia _mat = new E_materia();
                int resp = -1;
                bool _resul = false;
                bool _estado = false;
                #region validaciones

                foreach (char item in txt_nomMateria.Text)
                {
                    if (char.IsDigit(item))
                    {
                        _resul = false;
                        _estado = true;
                        break;
                    }
                }
                if (_estado)
                {
                    error1.SetError(txt_nomMateria, "El nombre de la materia no puede contener numeros.");
                }
                else
                {
                    error1.Clear();
                    _resul = true;
                }
                #endregion
                if (_resul)
                {
                    _mat._codigo = Convert.ToInt32(msk_codMateria.Text);
                    _mat._nombre = txt_nomMateria.Text;
                    _mat._usuarioEmple = txt_codProfMat.Text;
                    resp = _proceMenu.insertaMateria(_mat, numero);
                    if (resp == 1)
                    {
                        MessageBox.Show("Guardado.");
                        G_menuAdmin_Load(sender, e);
                        msk_codMateria.Text = "";
                        txt_nomMateria.Text = "";
                        txt_codProfMat.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se a logrado guardar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se a logrado guardar.");
            }
        }

        private void cb_actM_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_actM.Checked == true)
            {
                lbl_textM.Visible = true;
                btn_actM.Visible = true;
                btn_guardarM.Visible = false;
            }
            else if (cb_actM.Checked == false)
            {
                lbl_textM.Visible = false;
                btn_actM.Visible = false;
                btn_guardarM.Visible = true;
            }
        }

        private void txt_buscarM_TextChanged(object sender, EventArgs e)
        {
            dgv_materias.DataSource = _proceMenu.buscarMateria(txt_buscarM.Text);
        }

        #region no necesarios
        private void p_listaE_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void p_registroE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_perfil_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgv_listaEst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_listaE.RowHeadersVisible = false;
        }





        #endregion

        private void btn_identEstM_Click(object sender, EventArgs e)
        {
            E_estudiante _est = new E_estudiante();
            _est = _matricula.buscarEst(txt_usuMatEst.Text);
            txt_nomEstM.Text = _est._nombre;
            txt_ape1EstM.Text = _est._ape1;
            txt_ape2EstM.Text = _est._ape2;
            txt_idenEstM.Text = _est._identificacion; 
        }

        private void btn_busMatM_Click(object sender, EventArgs e)
        {
            E_materia _mat = new E_materia();
            _mat = _matricula.ObtenerMat(Convert.ToInt32(txt_busMatM.Text));
            txt_codMatM.Text = _mat._codigo.ToString();
            txt_nomMatM.Text = _mat._nombre;
            txt_usuProfM.Text = _mat._usuarioEmple;
        }

        private void txt_usuProfM_TextChanged(object sender, EventArgs e)
        {
            E_empleado _emple = new E_empleado();
            _emple = _matricula.obtenerProf(txt_usuProfM.Text);
            txt_nomProfM.Text = _emple._nombre;
            txt_ape1ProfM.Text = _emple._apellidoUno;
            txt_ape2ProfM.Text = _emple._apellidoDos;
            txt_emailProfM.Text = _emple._email;
        }

        private void p_matricula_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_finMat_Click(object sender, EventArgs e)
        {
            int resp = -1;
            if(txt_nomEstM.Text == string.Empty || txt_codMatM.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un estudiante y una materia.");
            }
            else
            {
                _mat._codigoMat = Convert.ToInt32(txt_codMatM.Text);
                _mat._usuEst = txt_usuMatEst.Text;
                resp = _pMat.insertaMatricula(_mat);
                if (resp == 1)
                {
                    MessageBox.Show("Guardado");
                    txt_usuMatEst.Text = "";
                    txt_nomEstM.Text = "";
                    txt_ape1EstM.Text = "";
                    txt_ape2EstM.Text = "";
                    txt_idenEstM.Text = "";
                    txt_busMatM.Text = "";
                    txt_codMatM.Text = "";
                    txt_codMatM.Text = "";
                    txt_nomMatM.Text = "";
                    txt_usuProfM.Text = "";
                    txt_nomProfM.Text = "";
                    txt_ape1ProfM.Text = "";
                    txt_ape2ProfM.Text = "";
                    txt_emailProfM.Text = "";
                }
                else if (resp == 2)
                {
                    MessageBox.Show("Ocurrio un error verifique que los datos sean correctos");
                }
                else if (resp == 3)
                {
                    MessageBox.Show("No hay cupo para matricular esta materia");
                }
                else if (resp == 4)
                {
                    MessageBox.Show("El estudiante ya se encuentra matriculo en esta materia.");
                }
            }
            
        }


        private void txt_buscarEmple_TextChanged(object sender, EventArgs e)
        {
            dgv_listaE.DataSource = _proceMenu.buscarEmpleado(txt_buscarEmple.Text);
        }

        private void txt_ape2EstM_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_cancelaRegisEmple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se a cancelado");
            txt_nombreD.Text = "";
            txt_apellidoUnoD.Text = "";
            txt_apellidoDosD.Text = "";
            msk_ideD.Text = "";
            txt_direccionD.Text = "";
            txt_emailD.Text = "";
            msk_telefonoD.Text = "";
            msk_fechaD.Text = "";
            txt_usuD.Text = "";
            rb_Admin.Checked = false;
            rb_docente.Checked = false;
        }

        private void btn_cancelaMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se a cancelado");
            txt_usuMatEst.Text = "";
            txt_nomEstM.Text = "";
            txt_ape1EstM.Text = "";
            txt_ape2EstM.Text = "";
            txt_idenEstM.Text = "";
            txt_busMatM.Text = "";
            txt_codMatM.Text = "";
            txt_codMatM.Text = "";
            txt_nomMatM.Text = "";
            txt_usuProfM.Text = "";
            txt_nomProfM.Text = "";
            txt_ape1ProfM.Text = "";
            txt_ape2ProfM.Text = "";
            txt_emailProfM.Text = "";
        }

        private void btn_cancelaRegisEst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro del estudiante se a cancelado;");
            txt_nomEst.Text = "";
            txt_ape1Est.Text = "";
            txt_ape2Est.Text = "";
            msk_ideEst.Text = "";
            txt_direcEst.Text = "";
            txt_emailEst.Text = "";
            txt_usuEst.Text = "";
            txt_contraEst.Text = "";
            msk_telefonoEst.Text = "";
            msk_fechaEst.Text = "";
        }

        private void btn_cancelarRegisMat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se a cancelado.");
            msk_codMateria.Text = "";
            txt_nomMateria.Text = "";
            txt_codProfMat.Text = "";
        }

        private void G_menuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
