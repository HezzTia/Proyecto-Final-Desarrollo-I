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
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            
            
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        static bool verificarCorreo(string email)
        {
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();

            if (NombreTxt.Text == "" || ApellidoTxt.Text == "" || CorreoElectronicoTxt.Text == "" || Sexo.Text == "" || UsuarioLITx.Text == "" || ClaveLiTx.Text == "")
            {
                MessageBox.Show("Por favor termine de llenar los campos vacios", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var validar = registrar.Identificacion(CorreoElectronicoTxt.Text);

            if (validar == true)
            {
                MessageBox.Show("Este correo ya esta utlizado", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var validarusuario = registrar.IdentificacionUsuario(UsuarioLITx.Text);

            if (validarusuario == true)
            {
                MessageBox.Show("Este usuario ya esta utlizado", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var validarcorreo = verificarCorreo(CorreoElectronicoTxt.Text);
            if (validarcorreo == false)
            {
                MessageBox.Show("Formato de correo invalido");
                return;
            }

            var insertar = registrar.ingresar(NombreTxt.Text, ApellidoTxt.Text, CorreoElectronicoTxt.Text, UsuarioLITx.Text, ClaveLiTx.Text, Sexo.Text, FechadeNacimiento.Value.Date);
            if (insertar)
            {
                MessageBox.Show("La cuenta se registro con exito");
                LogIn iniciarSesion = new LogIn();
                this.Hide();
                iniciarSesion.Show();
                return;
            }
           
        }

        private void IngresarCuentabtn_Click_1(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }
       
        private void CorreoElectronicoTxt_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}

