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
    public partial class ListaDeContactosAdmin : Form
    {
        public ListaDeContactosAdmin()
        {
            InitializeComponent();
        }
        GuardarC gb = new GuardarC();
        private void LoginProyectoDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void ListaDeContactosAdmin_Load(object sender, EventArgs e)
        {
            duv1.DataSource = gb.mostraradmin();
            duv2.DataSource = gb.MostrarDatos();
        }

        private void Duv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = duv1.Rows[e.RowIndex];
                txtNa.Text = Convert.ToString(fila.Cells[0].Value);
                txtAa.Text = Convert.ToString(fila.Cells[1].Value);
                txtUa.Text = Convert.ToString(fila.Cells[2].Value);
                txtCa.Text = Convert.ToString(fila.Cells[3].Value);
                txtTuA.Text = Convert.ToString(fila.Cells[4].Value);
            }
            catch
            {

            }
        }

        private void Duv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = duv2.Rows[e.RowIndex];
                txtNu.Text = Convert.ToString(fila.Cells[0].Value);
                txtAu.Text = Convert.ToString(fila.Cells[1].Value);
                txtCu.Text = Convert.ToString(fila.Cells[2].Value);
                txtNumeroU.Text = Convert.ToString(fila.Cells[3].Value);
            }
            catch
            {

            }
        }

        private void BtnEliminarU_Click(object sender, EventArgs e)
        {
            if (gb.eliminar(txtCu.Text))
            {
                MessageBox.Show("Datos eliminados");
                duv2.DataSource = gb.MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se ah podido eliminar");
            }
        }

        private void BtnElminarA_Click(object sender, EventArgs e)
        {
            if (gb.eliminarAdministrador(txtUa.Text))
            {
                MessageBox.Show("Datos eliminados");
                duv1.DataSource = gb.MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se ah podido eliminar");
            }
        }
    }
}
