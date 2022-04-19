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
    public partial class Modulo4Pag1 : Form
    {
        int nota = 50;
        public Modulo4Pag1()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Modulo4Pag2 modulo4Pag2 = new Modulo4Pag2();
            modulo4Pag2.User = User;
            modulo4Pag2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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
            SqlCommand guardar = new SqlCommand("update Registrar set M4='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
