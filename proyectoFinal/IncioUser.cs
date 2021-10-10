using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyectoFinal
{
    public partial class IncioUser : Form
    {
        public IncioUser()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panelLateral.Width == 218)
            {
                panelLateral.Width = 54;
            }
            else
            {
                panelLateral.Width = 218;
            }
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            LoginAdmin lg = new LoginAdmin();
            lg.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar());
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new EnviarMensaje());
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }
    }
}
