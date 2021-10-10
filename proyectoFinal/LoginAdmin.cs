using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace proyectoFinal
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("program created by Christopher Severino \n\n registration 20186100 \n\n Copyright© 2019-2020");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void BtnIncioAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select * FROM LoginAdmi WHERE Usuario='{0}'AND contraseña= '{1}' ", TxtAdminUser.Text.Trim(), TextAdminContra.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(cmd);

                string cuenta = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["contraseña"].ToString().Trim();

                if(cuenta == TxtAdminUser.Text.Trim() && contra == TextAdminContra.Text.Trim())
                {
                    if ( ds.Tables[0].Rows[0]["T_usuario"].ToString().Trim() == "Administrador")
                    {
                        IncioAdmin ia = new IncioAdmin();
                        ia.Show();
                        this.Hide();
                    }
                    else
                    {
                        IncioUser iu = new IncioUser();
                        iu.Show();
                        this.Hide();
                    }
                }
                
            }
            catch(Exception eroor)
            {
                MessageBox.Show("mensaje o contraseña incorecta");                
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
