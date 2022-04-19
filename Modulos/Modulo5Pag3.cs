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
    public partial class Modulo5Pag3 : Form
    {
        int nota = 100;
        public Modulo5Pag3()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Modulo5Pag2 modulo5Pag2 = new Modulo5Pag2();
            modulo5Pag2.User = User;
            modulo5Pag2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Menu menu = new Menu();
            menu.User = User;
            menu.ShowDialog();
        }

        private bool GuardarNota(string user, int nota)
        {

            Clases.Conexion conexion = new Clases.Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand guardar = new SqlCommand("update Registrar set M5='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
