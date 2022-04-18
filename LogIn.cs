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

        static void Ma()
        {
            Application.Run(new LogIn());
        }
        public LogIn()
        {
            InitializeComponent();
        }
       

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEB.4.0;Data Source=db_usuarios.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void ClaveLITxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarClaveBtn_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
          Login iniciarSesion = new Login();
           var validar = iniciarSesion.Acceder(UsuarioLITxt.Text , ClaveLITxt.Text);
            if (validar)
            {
                MessageBox.Show("Exitoso");
                Menu MenuPrincipal = new Menu();
                this.Hide();
                MenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Fallido");
            }
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
