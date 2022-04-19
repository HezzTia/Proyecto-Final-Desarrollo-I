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
        public bool Identificacion (string correo) //Se crea un metodo tipo bool que retornara una variable
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();
            //Aqui abre conexion con la base de datos y se crea una variable llamada resultado para el metodo de AbrirConexion 

            if (resultado == false)
            {
                return false;
            }
            //Aqui se crea una variable de tipo SqlCommand llamado consulta que selecciona la tabla Registrar de las columna Correo Electronico, la cual estan asignadas a las variable correo
            SqlCommand consulta = new SqlCommand("select * from Registrar where [Correo Electronico] = '" + correo + "'", conexion.con);
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader read = consulta.ExecuteReader();
            if (read.Read())
            {
                conexion.CerrarConexion();

                return true;
            } 
            //Esto es lo mismo que el login
          
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
            //Esto es lo mismo que el correo electronico, pero con el usuario

            return false;
        }

        public bool ingresar(string nombre, string apellido, string correo,string usuario, string pass, string sexo , DateTime fecha )//Aqui se crea un metodo que retornara 7 variables
        {
            
            Conexion conexion = new Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            //Aqui se crea una variable de tipo SqlCommand llamado insertar la cual se ingresara en la tabla Registrar las 7 variables
            SqlCommand insertar = new SqlCommand("insert into Registrar (Username, Password, Nombre, Apellido, Sexo,[Correo Electronico], " +
                "[Fecha de Nacimiento]) values ('" + usuario + "', '"+ pass + "', '" + nombre + "', '" + apellido +"','" + sexo +"', '" + correo + "' ,'" + fecha + "')", conexion.con);
         
            //Aqui se ingresa los datos al query
            insertar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
