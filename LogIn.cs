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
using ProyectoFinal.Clases;

namespace ProyectoFinal
{
    public partial class LogIn : Form
    {

        static void Main()
        {
            Application.Run(new LogIn());
        }
        public LogIn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            //Al presionar al label entraras al registrar
            new SignUp().Show();
            this.Hide();
        }

        private void ClaveLITxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarClaveBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Si el texto tiene caracter * al precionar al check mostrará los caracteres
            if (ClaveLITxt.PasswordChar == '*') 
            {
                ClaveLITxt.PasswordChar = '\0';
            }
            else
            {
                ClaveLITxt.PasswordChar= '*';
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
          Login iniciarSesion = new Login(); //Entra a la clase de Login
           var validar = iniciarSesion.Acceder(UsuarioLITxt.Text , ClaveLITxt.Text); //Crea una variable llamada validar del metodo Acceder de la clase iniciar sesion. La cual utilizara los datos de los textbox
            if (validar)
            {
                //Si estan los datos en la base datos, entrara al menu
                Menu MenuPrincipal = new Menu();
                this.Hide();
                MenuPrincipal.User = UsuarioLITxt.Text;
                MenuPrincipal.Show();
            }
            else
            {
                //Si no estan uno de los datos, presentara un messagebox
                MessageBox.Show("Usuario/Contraseña incorrecta");
            }
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void UsuarioLITxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
