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
        static void Main(string[] args)
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
            string nombre;
            string apellido;
            string correoElectronico ="@";
            string clave;
            Console.WriteLine("");
            
            Console.WriteLine("Ingrese las siguientes informaciones");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
             Console.Write("Apellido: ");
            apellido = Console.ReadLine();
             Console.Write("Correo Electronico: ");
            correoElectronico = Console.ReadLine();
             Console.Write("Contraseña: ");
            clave = Console.ReadLine();
            bool vErrorFormato = int.TryParse(nombre, out );
            try 
	        {	        
                if (nombre.ToString())
                {

                }
	        }
	catch (FormatException)
	{

		Console.WriteLine("Error en el tipo de formato del texto");
	}


        }
        static void LogIn()
        {

        }

    }
}
