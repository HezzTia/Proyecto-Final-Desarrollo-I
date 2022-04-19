using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class Modulo2Pag2 : Form
    {
        int nota = 66;
        public Modulo2Pag2()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Modulo2Pag2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Modulo2Pag1 modulo2Pag1 = new Modulo2Pag1();
            modulo2Pag1.User = User;
            modulo2Pag1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Modulo2Pag3 modulo2Pag3 = new Modulo2Pag3();
            modulo2Pag3.User = User;
            modulo2Pag3.ShowDialog();
        }

        private bool GuardarNota(string user, int nota)
        {

            Clases.Conexion conexion = new Clases.Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand guardar = new SqlCommand("update Registrar set M2='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
