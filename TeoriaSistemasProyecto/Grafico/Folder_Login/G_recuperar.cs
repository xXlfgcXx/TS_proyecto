using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
namespace Grafico.Folder_Login
{
    public partial class G_recuperar : Form
    {
        P_login log = new P_login();
        public G_recuperar()
        {
            InitializeComponent();
        }

        private void G_recuperar_Load(object sender, EventArgs e)
        {

        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            Random _numRan = new Random();
            MailMessage _mail = new MailMessage();
            try
            {
                int _resp = log.verificar(txt_email.Text.ToLower().Trim());
                if (_resp == 1)
                {
                    string _num;
                    for (int i = 0; i < 1; i++)
                    {
                        _num = ($"{_numRan.Next(),8}");
                        _sendEmail(_num);
                    }

                    void _sendEmail(string _numRa)
                    {
                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("ts.uam01@gmail.com");
                            mail.To.Add("" + txt_email.Text.ToLower().Trim());
                            mail.Subject = "Codigo de verificación.";
                            mail.Body = "<div style='text-align:center;background:linear-gradient(to right,#051937,#004d7a," +
                                "#008793,#00bf72,#a8eb12);font-family:Tahoma;color:white;'><br><br><h1>Codigo de verificacion.</h1><br><br><p>Su codigo de verificación " +
                                "es: <b> " + _numRa + " </b></p><p>El codigo lo ingresa al iniciar sesion, con el se completa el registro.</p><br><br>";
                            mail.IsBodyHtml = true;
                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new NetworkCredential("ts.uam01@gmail.com", "gmail@pass");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                        log.numRan(txt_email.Text.ToLower().Trim(), _numRa);
                        gb_cod.Show();
                        gb_email.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales ingresadas no son validas.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede enviar el codigo.");
            }
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            gb_email.Show();
            gb_cod.Hide();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            int resp=-1;
            if(txt_codigo.Text != string.Empty)
            {
                resp = log.verificarCod(txt_email.Text.ToLower().Trim(),txt_codigo.Text.Trim());
                if (resp == 1)
                {
                    gb_cod.Hide();
                    gb_email.Hide();
                    gb_nuevaContra.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                    gb_cod.Show();
                }
            }
        }

        private void btn_nuevaContra_Click(object sender, EventArgs e)
        {
            G_Login g_log = new G_Login();
            if(txt_contraAct.Text != string.Empty)
            {
                log.nuevaContrasena(txt_email.Text.ToLower().Trim(), txt_contraAct.Text.Trim());
                MessageBox.Show("Contraseña actualizada");
                this.Hide();
                g_log.Show();
                
            }
        }


        private void G_recuperar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
