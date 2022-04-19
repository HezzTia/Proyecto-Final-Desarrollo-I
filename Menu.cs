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
    public partial class Menu : Form
    {
        int NotaModulo;
        public Menu()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo1Pag1 modulo1Pag1 = new Modulo1Pag1();
            modulo1Pag1.User = User;
            this.Hide();
            modulo1Pag1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M1E");
            if (NotaModulo >= 75)
            {
                Modulo2Pag1 modulo2Pag1 = new Modulo2Pag1();
                modulo2Pag1.User = User;
                this.Hide();
                modulo2Pag1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe aprobar el examen del Módulo #1 antes de iniciar este módulo.");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M1");
            if(NotaModulo != 100)
            {
                MessageBox.Show("Debe completar el Módulo #1 para tomar este examen.");
            }
            else
            {
                Exams.M1 m1 = new Exams.M1();
                this.Hide();
                m1.User = User;
                m1.ShowDialog();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M2");
            if (NotaModulo != 100)
            {
                MessageBox.Show("Debe completar el Módulo #2 para tomar este examen.");
            }
            else
            {
                Exams.M2 m2 = new Exams.M2();
                this.Hide();
                m2.User = User;
                m2.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M3");
            if (NotaModulo != 100)
            {
                MessageBox.Show("Debe completar el Módulo #3 para tomar este examen.");
            }
            else
            {
                Exams.M3 m3 = new Exams.M3();
                this.Hide();
                m3.User = User;
                m3.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M4");
            if (NotaModulo != 100)
            {
                MessageBox.Show("Debe completar el Módulo #4 para tomar este examen.");
            }
            else
            {
                Exams.M4 m4 = new Exams.M4();
                this.Hide();
                m4.User = User;
                m4.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M5");
            if (NotaModulo != 100)
            {
                MessageBox.Show("Debe completar el Módulo #5 para tomar este examen.");
            }
            else
            {
                Exams.M5 m5 = new Exams.M5();
                this.Hide();
                m5.User = User;
                m5.ShowDialog();
            }
        }

        private void Cerrar(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M2E");
            if (NotaModulo >= 75)
            {
                Modulo3Pag1 modulo3Pag1 = new Modulo3Pag1();
                modulo3Pag1.User = User;
                this.Hide();
                modulo3Pag1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe aprobar el examen del Módulo #2 antes de iniciar este módulo.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M3E");
            if (NotaModulo >= 75)
            {
                Modulo4Pag1 modulo4Pag1 = new Modulo4Pag1();
                modulo4Pag1.User = User;
                this.Hide();
                modulo4Pag1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe aprobar el examen del Módulo #3 antes de iniciar este módulo.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerificarNota(User, "M4E");
            if (NotaModulo >= 75)
            {
                Modulo5Pag1 modulo5Pag1 = new Modulo5Pag1();
                modulo5Pag1.User = User;
                this.Hide();
                modulo5Pag1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe aprobar el examen del Módulo #4 antes de iniciar este módulo.");
            }
        }

        private bool VerificarNota(string user, string modulo)
        {

            Clases.Conexion conexion = new Clases.Conexion();
            var resultado = conexion.AbrirConexion();
            if (resultado == false)
            {
                return false;
            }
            SqlCommand consulta = new SqlCommand($"SELECT {modulo} FROM Registrar WHERE Username='"+user+"'", conexion.con);

            SqlDataReader reader = consulta.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    NotaModulo = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tiene módulos pendientes antes de llegar a esta asignatura.");
            }
            reader.Close();

            conexion.CerrarConexion();
            return true;
        }
    }
}
