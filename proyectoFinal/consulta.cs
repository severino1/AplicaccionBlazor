using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoFinal
{
    interface imsg
    {
        void msj();
    }
    class mostrar : imsg
    {
        public void msj()
        {
            MessageBox.Show("Operacion Exictosa");
        }
    }
    class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, sq);

            DP.Fill(DS);

            sq.Close();

            return DS;
        }
    }
    class AgregarU
    {
        public static int CrearCuentas(string nombre, string apellido, string Usuario, string contraseña, string pusuario)
        {
            int resultado = 0;
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert Into LoginAdmi(nombre, apellido, Usuario, contraseña, T_usuario) values ('{0}','{1}','{2}','{3}','{4}')",nombre, apellido,Usuario,contraseña,pusuario),sq);
            resultado = comando.ExecuteNonQuery();
            sq.Close();
            return resultado;
        }
    }
    class GuardarC
    {
       
        private DataSet ds;
        public static int CrearContacto(string Nombre, string Apellido, string Correo, string Numero)
        {
            int resultado = 0;
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert Into Contactos(Nombre, Apellido, Correo, Numero) values ('{0}','{1}','{2}','{3}')", Nombre, Apellido, Correo, Numero), sq);
            resultado = comando.ExecuteNonQuery();
            sq.Close();
            return resultado;
        }
        public DataTable MostrarDatos()
        {
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();
            SqlCommand cmd = new SqlCommand("select * from Contactos", sq);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            sq.Close();
            return ds.Tables["tabla"];
        
        }
      
        public DataTable mostraradmin()
        {
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();
            SqlCommand cmd = new SqlCommand("select * from LoginAdmi", sq);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            sq.Close();
            return ds.Tables["tabla"];
        }
        
        public bool eliminar( string Correo)
        {
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Contactos where Correo = '{0}'",Correo), sq);
            int filasafectada = cmd.ExecuteNonQuery();
            sq.Close();
            if (filasafectada > 0) return true;
            else return false;
        }
        public bool eliminarAdministrador(string Usuario)
        {
            SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
            sq.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from LoginAdmi where Usuario = '{0}'", Usuario), sq);
            int filasafectada = cmd.ExecuteNonQuery();
            sq.Close();
            if (filasafectada > 0) return true;
            else return false;
        }

        //public conexion()
        //{
        //    SqlDataReader dr;
        //    try
        //    {
        //        SqlConnection sq = new SqlConnection("Data Source=.;Initial Catalog=LoginProyecto;Integrated Security=True");
        //        sq.Open();
        //        SqlCommand cmd = new SqlCommand(string.Format("Select Correo from Contactos = "), sq);
        //        dr = cmd.ExecuteReader();
        //        whlile
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

    }
}
