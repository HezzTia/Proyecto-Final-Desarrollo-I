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
        //Variable publica tipo string con la ubicacion de la base datos
        public string cadena = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbo.usuarios.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection con = new SqlConnection();
        //Variable publica tipo SqlConnection 

        public bool AbrirConexion()
        {
            try
            {
                //Creamos una conexion con la base de datos
                con.ConnectionString = cadena;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //Si hay conexion con la base datos retornara true
                    return true;
                }
                con.Open();
                return true;
                //Luego abre conexion 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                //Si falle conexion muestra un Messagebox con el error
            }


        }
        public bool CerrarConexion()
        {
            //Este metodo es para cerrar conexion
            con.Close();
            return true;
        }

    }
}
