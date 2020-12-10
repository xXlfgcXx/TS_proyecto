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
namespace Grafico.Folder_Login
{
    public partial class G_Login : Form
    {
        public static string usuario = "";
        public G_Login()
        {
            InitializeComponent();
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            G_recuperar recuperar = new G_recuperar();
            this.Hide();
            recuperar.Show();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            P_login _negLog = new P_login();
            P_menuPrincipal _menu = new P_menuPrincipal();
            Folder_Menu.G_menuAdmin _gMenu = new Folder_Menu.G_menuAdmin();
            string resp = "";
            if(txt_usu.Text != string.Empty)
            {
                if(txt_contra.Text != string.Empty)
                {
                    resp = _negLog.inicio(txt_usu.Text.Trim(), txt_contra.Text.Trim());
                    if (resp == "1")
                    {
                        usuario = txt_usu.Text.Trim();
                        Folder_Menu.G_menuAdmin _menuPrin = new Folder_Menu.G_menuAdmin();
                        this.Hide();
                        _menuPrin.Show();
                    }
                    else if(resp=="3")
                    {
                        E_estudiante _est = new E_estudiante();
                        _est = _menu.obtenerDatosEst(txt_usu.Text.Trim());
                        usuario = _est._usuario;
                        Folder_Estudiante.G_menuEstudiante _menuEst = new Folder_Estudiante.G_menuEstudiante();
                        this.Hide();
                        _menuEst.Show();
                    }else if (resp=="2")
                    {
                        E_empleado _emple = new E_empleado();
                        _emple = _menu.obtenerDatos(txt_usu.Text.Trim());
                        usuario = _emple._usuario; 
                        Folder_Profe.G_menuProfe _menuProf = new Folder_Profe.G_menuProfe();
                        this.Hide();
                        _menuProf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sus credenciales no son correctas.");
                    }
                }
                else
                {
                    MessageBox.Show("Sus credenciales no son correctas.");
                }
            }
            else
            {
                MessageBox.Show("No pueden haber campos en blanco.");
            }
        }

        private void G_Login_Load(object sender, EventArgs e)
        {

        }

        private void G_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
