using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ProyectoFinal
{
    internal class Program
    {
        static void Mai(string[] args)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Escribe a cual archivo entrar");
            Console.WriteLine("1. LogIn\n2.SignUp\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    new LogIn().Show();
                    break;
                case 2:
                    new SignUp().Show();
                    break;
            }

            Console.ReadKey();
        }
    }
}
