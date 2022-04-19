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
        public bool Acceder(string usuario, string pass) //Se crea un metodo que retornara las variables usuario y contraseña
        {
            Conexion conexion = new Conexion(); 
            var resultado = conexion.AbrirConexion();
            //Se abre conexion con la base de datos y se crea una variable llamada resultado para el metodo de AbrirConexion

            if (resultado == false) //Lo cual si es falla retornara falso
            {
                return false;
            }
            //Aqui se crea una variable de tipo SqlCommand llamado consulta que selecciona la tabla Registrar de las columnas Username y Password, la cual estan asignadas a las variables usuario y pass
                SqlCommand consulta = new SqlCommand("select * from Registrar where Username = '"+usuario+"' and Password = '"+pass+"' ",conexion.con);
            consulta.CommandType = System.Data.CommandType.Text;  //Los datos de la consulta son leido tipo text
            SqlDataReader read = consulta.ExecuteReader(); //Se crea una variable de tipo SqlDataReader llamada read la cual va leer los datos que estan en las columnas 
            if (read.Read())
            {
                //Si read es true, cierra conexion
                conexion.CerrarConexion();
                return true;
            }

            conexion.CerrarConexion();
            return false;
           
        }
    }
}
