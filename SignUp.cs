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

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();

            if (NombreTxt.Text == "" || ApellidoTxt.Text == "" || CorreoElectronicoTxt.Text == "" || Sexo.Text == "" || UsuarioLITx.Text == "" || ClaveLiTx.Text == "")
            {
                MessageBox.Show("Por favor termine de llenar los campos vacios", "Fallo el proceso de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var validar = registrar.Identificacion (CorreoElectronicoTxt.Text);

           if (validar == true)
            {
                MessageBox.Show("Este correo ya esta utlizado");
                return;
            }

            var validarusuario = registrar.IdentificacionUsuario(UsuarioLITx.Text);

            if (validarusuario == true)
            {
                MessageBox.Show("Este usuario ya esta utlizado");
                return;
            }

           var insertar =  registrar.ingresar(NombreTxt.Text, ApellidoTxt.Text, CorreoElectronicoTxt.Text, UsuarioLITx.Text, ClaveLiTx.Text, Sexo.Text, FechadeNacimiento.Value.Date);

            if(insertar)
            {
                MessageBox.Show("La cuenta se registro con exito");
                LogIn iniciarSesion = new LogIn();
                this.Hide();
                iniciarSesion.Show();
            }
           
        }

        private void AnoTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiaTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioLITx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClaveLiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CorreoElectronicoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MesTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
