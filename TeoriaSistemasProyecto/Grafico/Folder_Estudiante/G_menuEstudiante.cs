using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
namespace Grafico.Folder_Estudiante
{
    public partial class G_menuEstudiante : Form
    {
        P_menuPrincipal _menu = new P_menuPrincipal();
        P_estudiante _pEst = new P_estudiante();
        public G_menuEstudiante()
        {
            InitializeComponent();
        }

        private void btn_perfilEst_Click(object sender, EventArgs e)
        {
            p_perfilEst.Show();
            p_materiaM.Hide();
        }
        private void btn_materiaM_Click(object sender, EventArgs e)
        {
            p_materiaM.Show();
            p_perfilEst.Hide();
        }

        private void G_menuEstudiante_Load(object sender, EventArgs e)
        {
            cargaUsuario(Folder_Login.G_Login.usuario);
            dgv_materiasM.DataSource= _pEst.obtenerMaterias(Folder_Login.G_Login.usuario);
        }
        public void cargaUsuario(string txt)
        {
            E_estudiante _est = new E_estudiante();
            _est = _menu.obtenerDatosEst(txt);
            string nom = _est._nombre;
            lbl_nombre.Text = nom.ToUpper();
            lbl_nombre.Visible = true;
            #region carga objeto
            txt_nombreEst.Text = _est._nombre;
            txt_apellidoUnoEst.Text = _est._ape1;
            txt_apellidoDosEst.Text = _est._ape2;
            txt_direccionEst.Text = _est._direccion;
            txt_emailEst.Text = _est._email;
            msk_fechaNacEst.Text = _est._fechaNac;
            msk_ideEst.Text = _est._identificacion;
            msk_telefonoEst.Text = _est._telefono;
            txt_usuEst.Text = _est._usuario;
            txt_contraEst.Text = _est._contrasena;
            if (_est._rol == "3") 
            {
                lbl_rol.Text =  "Estudiante."; 
                lbl_rol.Visible = true;
            }
            #endregion
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Folder_Login.G_Login _log = new Folder_Login.G_Login();
            _log.Show();
            this.Hide();
        }

        private void btn_actEst_Click(object sender, EventArgs e)
        {
            txt_nombreEst.Enabled = true;
            txt_apellidoUnoEst.Enabled = true;
            txt_apellidoDosEst.Enabled = true;
            txt_direccionEst.Enabled = true;
            msk_telefonoEst.Enabled = true;
            txt_contraEst.Enabled = true;
            txt_emailEst.Enabled = true;
            btn_guardarEst.Visible = true;
            btn_actEst.Visible = false; 
        }

        private void btn_guardarEst_Click(object sender, EventArgs e)
        {
            try
            {
                #region validacion
                bool _resul = false;
                bool _estado = true;
                bool _estado2 = true;
                bool _estado3 = true;
                bool _estado4 = true;
                foreach (char i1 in txt_nombreEst.Text)
                {
                    if (char.IsDigit(i1))
                    {
                        _estado = false;
                        break;
                    }
                }
                if (_estado == false)
                {
                    error1.SetError(txt_nombreEst, "El nombre no puede contener numeros.");
                }
                else
                {
                    error1.Clear();
                    _estado = true;
                }
                
                foreach (char i2 in txt_apellidoUnoEst.Text)
                {
                    if (char.IsDigit(i2))
                    {
                        _estado2 = false;
                        break;
                    }
                }
                if (_estado2==false)
                {
                    error2.SetError(txt_apellidoUnoEst, "El apellido no puede contener numeros.");
                }
                else
                {
                    error2.Clear();
                    _estado2 = true;
                }
                
                foreach (char i3 in txt_apellidoDosEst.Text)
                {
                    if (char.IsDigit(i3))
                    {
                        _estado3 = false;
                        break; 
                    }
                }
                if (_estado3==false)
                {
                    error3.SetError(txt_apellidoDosEst, "El apellido no puede contener numeros.");
                }
                else {
                    error3.Clear();
                    _estado3 = true;
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

                if (_estado && _estado2 && _estado3 && _estado4)
                {
                    _resul = true;
                }
                else
                {
                    _resul = false;
                }
                #endregion
                
                if (_resul)
                {
                    E_estudiante _est = new E_estudiante();
                    int resp = -1;
                    _est._nombre = txt_nombreEst.Text;
                    _est._ape1 = txt_apellidoUnoEst.Text;
                    _est._ape2 = txt_apellidoDosEst.Text;
                    _est._identificacion = msk_ideEst.Text;
                    _est._direccion = txt_direccionEst.Text;
                    _est._email = txt_emailEst.Text;
                    _est._usuario = txt_usuEst.Text;
                    _est._contrasena = txt_contraEst.Text;
                    _est._telefono = msk_telefonoEst.Text;
                    _est._fechaNac = msk_fechaNacEst.Text;
                    _est._rol = "3";
                    resp = _menu.insertaEstudiante(_est, 1);
                    if (resp == 1)
                    {
                        MessageBox.Show("Guardado.");
                        G_menuEstudiante_Load(sender, e);
                        txt_nombreEst.Enabled = false;
                        txt_apellidoUnoEst.Enabled = false;
                        txt_apellidoDosEst.Enabled = false;
                        txt_direccionEst.Enabled = false;
                        msk_telefonoEst.Enabled = false;
                        txt_contraEst.Enabled = false;
                        txt_emailEst.Enabled = false;
                        btn_guardarEst.Visible = false;
                        btn_actEst.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se a logrado actualizar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void G_menuEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
