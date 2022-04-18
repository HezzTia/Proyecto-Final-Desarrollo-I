using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoFinal.Clases
{
    internal class Registrar
    {
        public bool Identificacion (string correo)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();

            if (resultado == false)
            {
                return false;
            }
            SqlCommand consulta = new SqlCommand("select * from Registrar where [Correo Electronico] = '" + correo + "'", conexion.con);
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader read = consulta.ExecuteReader();
            if (read.Read())
            {
                conexion.CerrarConexion();

                return true;
            } 

          
            return false;
        }

        public bool IdentificacionUsuario(string usuario)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();

            if (resultado == false)
            {
                return false;
            }
            SqlCommand consulta = new SqlCommand("select * from Registrar where Username = '" + usuario + "'", conexion.con);
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader read = consulta.ExecuteReader();
            if (read.Read())
            {
                conexion.CerrarConexion();

                return true;
            }


            return false;
        }

        public bool ingresar(string nombre, string apellido, string correo,string usuario, string pass, string sexo , DateTime fecha )
        {
            
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand insertar = new SqlCommand("insert into Registrar (Username, Password, Nombre, Apellido, Sexo,[Correo Electronico], " +
                "[Fecha de Nacimiento]) values ('" + usuario + "', '"+ pass + "', '" + nombre + "', '" + apellido +"','" + sexo +"', '" + correo + "' ,'" + fecha + "')", conexion.con);
         

            insertar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
