using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class EnviarMensaje : Form
    {
        public EnviarMensaje()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add(txtPara.Text.Trim());
            msg.Subject = txtAsunto.Text.Trim();    
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Bcc.Add("cristopherseverino82@gmail.com");
            msg.Body = txtRedactar.Text.Trim();
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            msg.IsBodyHtml = false;
            msg.From = new System.Net.Mail.MailAddress("proyectofinalrobles@gmail.com");

            System.Net.Mail.SmtpClient clientes =  new System.Net.Mail.SmtpClient();
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
                MessageBox.Show("AH sucedido un error",error.Message);
                
            }
        }

        private void EnviarMensaje_Load(object sender, EventArgs e)
        {

        }

        private void TxtPara_TextChanged(object sender, EventArgs e)
        {
            //txtPara.AutoCompleteCustomSource = CargarDatos();
            //txtPara.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtPara.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //private AutoCompleteStringCollection CargarDatos()
        //{
        //    AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

        //    datos.Add("@Gmail.com");
        //    datos.Add("@Yopmail.com");
        //    datos.Add("@Hotmail.com");

        //    return datos;

        //}
    }
}
