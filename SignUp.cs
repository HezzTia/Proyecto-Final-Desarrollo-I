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
            if (new EmailAddressAttribute().IsValid(email)) //Aqui se verifica si tiene formato de correo
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
            Registrar registrar = new Registrar(); //Aqui se abre la clase registrar

            if (NombreTxt.Text == "" || ApellidoTxt.Text == "" || CorreoElectronicoTxt.Text == "" || Sexo.Text == "" || UsuarioLITx.Text == "" || ClaveLiTx.Text == "")
            {
                MessageBox.Show("Por favor termine de llenar los campos vacios", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //El return es para que no siga leyendo las otras condiciones
            }

            var validar = registrar.Identificacion(CorreoElectronicoTxt.Text); //Se crea una variable validar para abrir el metodo Identificacion la cual usara el texbox del correo

            if (validar == true)
            {
                MessageBox.Show("Este correo ya esta utlizado", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                //Si validar es true (Quiere decir que si leyo un correo electronico), aparecera un messageBox
            }

            var validarusuario = registrar.IdentificacionUsuario(UsuarioLITx.Text);//Se crea una variable validarusuario para abrir el metodo IdentificacionUsuario que usara el text del usaurio

            if (validarusuario == true)
            {
                MessageBox.Show("Este usuario ya esta utlizado", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                //Sucede lo mismo que el correo eletronico
            }

            var validarcorreo = verificarCorreo(CorreoElectronicoTxt.Text); //Se crea una variable validarcorreo para el metodo verificar correo que se usara el text del correo
            if (validarcorreo == false)
            {
                MessageBox.Show("Formato de correo invalido");
                return;
                //Esto es para verificar si el correo esta bien escrito
            }

            var insertar = registrar.ingresar(NombreTxt.Text, ApellidoTxt.Text, CorreoElectronicoTxt.Text, UsuarioLITx.Text, ClaveLiTx.Text, Sexo.Text, FechadeNacimiento.Value.Date);
            if (insertar)
            {
                //Se crea una variable del metodo, y se registra con exito mandara un messagebox y pasara al login
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
            //Esto es para ingresar al login
        }
       
        private void CorreoElectronicoTxt_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}

