using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using proyectoFinal;

namespace proyectoFinal
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Utilidades.Ejecutar();
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Ah ocurrido un error" + error);
            //}
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add("cristopherseverino82@gmil.com");
            msg.Subject = ("Registrar");
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Bcc.Add("cristopherseverino82@gmail.com");
            msg.Body = ("Nomobre:" + TxtNombre + "Apellido:" + TxtApellido + "Usuario:" + TxtTusuario + "Contraseña:" + TxtContrasena + "Tipo de usuario:" + TxtTusuario );
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            msg.IsBodyHtml = false;
            msg.From = new System.Net.Mail.MailAddress("proyectofinalrobles@gmail.com");

            System.Net.Mail.SmtpClient clientes = new System.Net.Mail.SmtpClient();
            clientes.Credentials = new System.Net.NetworkCredential("proyectofinalrobles@gmail.com", "severino007");

            clientes.Port = 587;
            clientes.EnableSsl = true;
            clientes.Host = "smtp.gmail.com";

            try
            {
                imsg Mostra = new mostrar();
                Mostra.msj();
            }
            catch (Exception error)
            {
                MessageBox.Show("AH sucedido un error", error.Message);

            }
            if (AgregarU.CrearCuentas(TxtNombre.Text, TxtApellido.Text, Variable.Text, TxtContrasena.Text, TxtTusuario.Text) > 0)
            {
                imsg Mostra = new mostrar();
                Mostra.msj();
            }
            else
            {
                MessageBox.Show("La cuenta no puede ser creada");
            }
        }

        private void TxtTusuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
