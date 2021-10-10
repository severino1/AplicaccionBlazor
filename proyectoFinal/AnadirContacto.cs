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
    public partial class AnadirContacto : Form
    {
        public AnadirContacto()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           if( GuardarC.CrearContacto(TxtNombre.Text, TxtApellido.Text, TxtMensaje.Text, TxtNumero.Text) > 0)
            {
                MessageBox.Show("Cuenta creada, exictosamente");
            }
            else
            {
                MessageBox.Show("La cuenta no puede ser creada");
            }
        }
    }
}
