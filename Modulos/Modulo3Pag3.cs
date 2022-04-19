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
    public partial class Modulo3Pag3 : Form
    {
        int nota = 75;
        public Modulo3Pag3()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Modulo3Pag2 modulo3Pag2 = new Modulo3Pag2();
            modulo3Pag2.User = User;
            modulo3Pag2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarNota(User, nota);
            this.Hide();
            Modulo3Pag4 modulo3Pag4 = new Modulo3Pag4();
            modulo3Pag4.User = User;
            modulo3Pag4.ShowDialog();

        }

        private void Modulo3Pag3_Load(object sender, EventArgs e)
        {

        }

        private bool GuardarNota(string user, int nota)
        {

            Clases.Conexion conexion = new Clases.Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand guardar = new SqlCommand("update Registrar set M3='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
