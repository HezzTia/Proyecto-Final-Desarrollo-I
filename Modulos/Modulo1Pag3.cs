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
    public partial class Modulo1Pag3 : Form
    {
        int nota = 100;
        public Modulo1Pag3()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuardarNota(User, nota);
            Modulo1Pag2 modulo1Pag2 = new Modulo1Pag2();
            modulo1Pag2.User = User;
            modulo1Pag2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuardarNota(User, nota);
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
            SqlCommand guardar = new SqlCommand("update Registrar set M1='"+nota+"' where Username='"+user+"'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
