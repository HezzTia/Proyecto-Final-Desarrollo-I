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
    public partial class Modulo1Pag2 : Form
    {
        int nota = 66;
        public Modulo1Pag2()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Modulo1Pag2_Load(object sender, EventArgs e)
        {

        }

        private void Modulo1Pag2_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuardarNota(User, nota);
            Modulo1Pag3 modulo1Pag3 = new Modulo1Pag3();
            modulo1Pag3.User = User;
            modulo1Pag3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuardarNota(User, nota);
            Modulo1Pag1 modulo1Pag1 = new Modulo1Pag1();
            modulo1Pag1.User = User;
            modulo1Pag1.ShowDialog();
        }

        private bool GuardarNota(string user, int nota)
        {

            Clases.Conexion conexion = new Clases.Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand guardar = new SqlCommand("update Registrar set M1='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
