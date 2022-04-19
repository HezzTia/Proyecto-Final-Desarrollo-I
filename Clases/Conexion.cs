using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{

    public class Conexion
    {
        public string cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbo.usuarios.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection con = new SqlConnection();


        public bool AbrirConexion()
        {
            try
            {
                con.ConnectionString = cadena;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
        public bool CerrarConexion()
        {
            con.Close();
            return true;
        }

    }
}
