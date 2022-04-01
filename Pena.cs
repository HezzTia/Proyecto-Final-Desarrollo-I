using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProyectoFinal
{
    internal class Pena
    {
        static void VictorP(string[] args)
        {
            Console.WriteLine("*Bienvenido a Sharp Me*\n");
            Console.WriteLine("Presiona\n1.SingUp\n2.LogIn ");
            int vEleccion = Convert.ToInt32(Console.ReadLine());
            switch (vEleccion)
	        {
                case 1:
                    Thread.Sleep(100);
                    SingUp();

                    break;
                case 2:
                    Thread.Sleep(100);
                    LogIn();    
                        break;
	        }

        }

         static void SingUp()
        {
//Declaraciones de variables para el registro
            string nombre;
            string apellido;
            string correoElectronico = "@";
            string clave;
            DateTime vFechaDeNacimiento;
            int vSexo;
            string vUsuario;
            
//El usuario registra sus datos
            Console.WriteLine("");
            Console.WriteLine("Sharp Me");
            Console.WriteLine("");
            Console.WriteLine("Ingrese las siguientes informaciones");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Correo Electronico: ");
            correoElectronico = Console.ReadLine();
            Console.Write("Fecha de Nacimiento(Formato - dd/mm/yyyy): ");
            vFechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Sexo: 1.Masculino 2. Femenino");
            vSexo =  Convert.ToInt32(Console.ReadLine());
            switch (vSexo)
            {
                case 1:
                    string masculino = "Masculino";
                    break;
                case 2:
                    string femenino = "Femenino";
                    break;
            }
            Console.Write("Contraseña: ");
            clave = Console.ReadLine();
//Verificacion por si el usuario escribe otro valor que no sea un string
            int vValidacion = 0;
            bool vErrorNombre = int.TryParse(nombre, out vValidacion);
            bool vErrorApellido = int.TryParse(apellido, out vValidacion);

            if (vErrorNombre == true)
            {
                Console.WriteLine("Error de formato");
            }
            else if (vErrorApellido == true)
            {
                Console.WriteLine("Error de formato");
            }
//El usuario crea su nombre de usuario
            Console.WriteLine("Bienvenido " +nombre+apellido);
            Console.Write("Ingresa tu nombre de usuario");
            vUsuario = Console.ReadLine();

            LogIn();
            Console.ReadKey();
        }
        static void LogIn()
        {
            Console.WriteLine("Sharp Me\n" );
            Console.WriteLine("Inicie Sesion\n");
            Console.Write("Usuario");
        }

    }
}
