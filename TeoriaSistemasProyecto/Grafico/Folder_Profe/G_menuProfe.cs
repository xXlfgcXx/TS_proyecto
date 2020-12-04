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
namespace Grafico.Folder_Profe
{
    public partial class G_menuProfe : Form
    {
        P_menuPrincipal _proce = new P_menuPrincipal();
        E_empleado _empleado = new E_empleado();
        public G_menuProfe()
        {
            InitializeComponent();
        }

        private void btn_perfilProf_Click(object sender, EventArgs e)
        {
            p_perfil.Show();
            p_cursos.Hide();
        }

        private void btn_cursosAsig_Click(object sender, EventArgs e)
        {
            p_cursos.Show();
            p_perfil.Hide();
        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Folder_Login.G_Login _log = new Folder_Login.G_Login();
            this.Hide();
            _log.Show();
        }

        private void G_menuProfe_Load(object sender, EventArgs e)
        {
            cargaUsuario(Folder_Login.G_Login.usuario);
            dgv_listaEstProf.DataSource = _proce.obtenerMateriaProf(Folder_Login.G_Login.usuario);
        }
        public void cargaUsuario(string txt)
        {
            E_empleado emple = new E_empleado();
            emple = _proce.obtenerDatos(txt);
            string nom = emple._nombre;
            lbl_nombre.Text = nom.ToUpper();
            lbl_nombre.Visible = true;
            #region carga objeto
            txt_nombreE.Text = emple._nombre;
            txt_apellidoUnoE.Text = emple._apellidoUno;
            txt_apellidoDosE.Text = emple._apellidoDos;
            txt_direccionE.Text = emple._direccion;
            txt_emailE.Text = emple._email;
            msk_fechaNacE.Text = emple._fechaNace;
            msk_ideE.Text = emple._identificacion;
            msk_telefonoE.Text = emple._telefono;
            txt_usuE.Text = emple._usuario;
            txt_contraE.Text = emple._contrasena;
            if (emple._rol == 2) { 
               lbl_rol.Text = "Docente."; 
            lbl_rol.Visible = true;
            }
            #endregion
        }

        private void btn_actE_Click(object sender, EventArgs e)
        {
            txt_nombreE.Enabled = true;
            txt_apellidoUnoE.Enabled = true;
            txt_apellidoDosE.Enabled = true;
            txt_direccionE.Enabled = true;
            msk_telefonoE.Enabled = true;
            txt_contraE.Enabled = true;
            txt_emailE.Enabled = true;
            btn_actE.Visible = false;
            btn_guardarE.Visible = true;
        }

        private void btn_guardarE_Click(object sender, EventArgs e)
        {
            try
            {
                #region validacion
                bool _resul = false;
                bool _estado = true;
                bool _estado2 = true;
                bool _estado3 = true;
                bool _estado4 = true;
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

                if (txt_contraE.TextLength < 8)
                {
                    error4.SetError(txt_contraE, "El usuario debe ser mayor a 8 caracteres.");
                    _estado4 = false;
                }
                else
                {
                    error4.Clear();
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
                    int resp = -1;
                    _empleado._nombre = txt_nombreE.Text;
                    _empleado._apellidoUno = txt_apellidoUnoE.Text;
                    _empleado._apellidoDos = txt_apellidoDosE.Text;
                    _empleado._identificacion = msk_ideE.Text;
                    _empleado._fechaNace = msk_fechaNacE.Text;
                    _empleado._email = txt_emailE.Text;
                    _empleado._telefono = msk_telefonoE.Text;
                    _empleado._direccion = txt_direccionE.Text;
                    _empleado._rol = 1;
                    _empleado._usuario = txt_usuE.Text;
                    _empleado._contrasena = txt_contraE.Text;
                    resp = _proce.mantenimientoEmple(_empleado, 1);
                    if (resp == 1)
                    {
                        MessageBox.Show("Guardado");
                        #region deshabilitar textBox
                        txt_nombreE.Enabled = false;
                        txt_apellidoUnoE.Enabled = false;
                        txt_apellidoDosE.Enabled = false;
                        txt_direccionE.Enabled = false;
                        msk_telefonoE.Enabled = false;
                        txt_contraE.Enabled = false;
                        txt_emailE.Enabled = false;
                        btn_actE.Visible = true;
                        btn_guardarE.Visible = false;
                        #endregion
                        G_menuProfe_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se ha logrado guardar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void btn_buscarMat_Click(object sender, EventArgs e)
        {
            dgv_listaEstProf.DataSource = _proce.filtrarMaterias(Folder_Login.G_Login.usuario,txt_buscarMat.Text);
        }

        private void G_menuProfe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
