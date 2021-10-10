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
    public partial class ListaDeContacto : Form
    {
        public ListaDeContacto()
        {
            InitializeComponent();
        }
        GuardarC gb = new GuardarC();
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                TxtNombre.Text = Convert.ToString(fila.Cells[0].Value);
                TxtApellido.Text = Convert.ToString(fila.Cells[1].Value);
                txtCorreo.Text = Convert.ToString(fila.Cells[2].Value);
                TxtNumero.Text = Convert.ToString(fila.Cells[3].Value);
            }
            catch
            {

            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ListaDeContacto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gb.MostrarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (gb.eliminar(txtCorreo.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView1.DataSource = gb.MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se ah podido eliminar");
            }
        }

        private void BtnAcrualizar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
