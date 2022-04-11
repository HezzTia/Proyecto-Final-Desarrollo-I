using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoFinal.Clases
{
    internal class Login
    {
        public bool Acceder(string usuario, string pass)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();
           
            if (resultado == false)
            {
                return false;
            }
                SqlCommand consulta = new SqlCommand("select * from Registrar where Username = '"+usuario+"' and Password = '"+pass+"' ",conexion.con);
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader read = consulta.ExecuteReader();
            if (read.Read())
            {
                conexion.CerrarConexion();

                return true;
            }

            conexion.CerrarConexion();
            return false;
           
        }
    }
}
