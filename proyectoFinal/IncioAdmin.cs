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
    public partial class IncioAdmin : Form 
    {
        public IncioAdmin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        private void BtnList_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 218)
            {
                MenuVertical.Width = 54;
            }
            else
            {
                MenuVertical.Width = 218;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012,0);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            LoginAdmin lg = new LoginAdmin();
            lg.Show();
            this.Hide();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Section Only for Admin");
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
      

        private void BtnUser_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar());
        }

        private void PicUser_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar());
        }

        private void BtnContactos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new AnadirContacto());
        }

        private void PicAnadir_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new AnadirContacto());
        }

        private void BtnListaContactos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContactosAdmin());
        }

        private void PicContacto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContactosAdmin());
        }

        private void BtnEnviarMenaje_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new EnviarMensaje());
        }

        private void PicEnviar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new EnviarMensaje());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }

        private void PicReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte());
        }

        private void BtnEliminarContacto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void PicEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ListaDeContacto());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar()); ;
        }

        private void PicAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
