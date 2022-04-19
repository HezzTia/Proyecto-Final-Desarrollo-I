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
using System.Data.SqlClient;

namespace ProyectoFinal.Exams
{
    public partial class M1 : Form
    {

        int vPunt;
        int vPorcentaje;
        int vNumPregunta = 1;
        int vResCorrecta;
        int vCantPreguntas;
        int vTagRes;

        public M1()
        {
            InitializeComponent();

            MostrarPreg(vNumPregunta);

            vCantPreguntas = 6;
        }

        public string User { get; set; }

        private void RevRespuestas(object sender, EventArgs e)
        {
            var vSenderObject = (CheckBox)sender;

            vTagRes = Convert.ToInt32(vSenderObject.Tag);
        }

        private void MostrarPreg(int vNumPregunta)
        {
            switch (vNumPregunta)
            {
                case 1:
                    ClearBoxes();

                    LblPregunta.Text = "¿Qué es el software?";

                    CBA1.Text = "Conjunto de Instrucciones que hacen funcionar una computadora";
                    CBA2.Text = "Parte física de un computador";
                    CBA3.Text = "Programa en el cual se desarrollan programas";

                    vResCorrecta = 1;
                    break;

                case 2:
                    ClearBoxes();

                    LblPregunta.Text = "¿Cuál es el término para referirse a las personas que crean Software?";

                    CBA1.Text = "Creador de Software";
                    CBA2.Text = "Ingeniero de Software";
                    CBA3.Text = "Desarrollador";

                    vResCorrecta = 3;
                    break;

                case 3:
                    ClearBoxes();

                    LblPregunta.Text = "¿Cuál es la principal diferencia entre un lenguaje de alto nivel y uno de bajo nivel?";

                    CBA1.Text = "El lenguaje de alto nivel se parece más al lenguaje humano. El lenguaje de bajo nivel se parece más al lenguaje de máquinas";
                    CBA2.Text = "Los lenguajes de alto nivel son interpretados y los de bajo nivel compilados";
                    CBA3.Text = "El Lenguaje de alto nivel es más díficil de comprender que el lenguaje de bajo nivel";

                    vResCorrecta = 1;
                    break;

                case 4:
                    ClearBoxes();

                    LblPregunta.Text = "¿Qué es un IDE?";

                    CBA1.Text = "Integrador Dinámico de Entornos";
                    CBA2.Text = "Lenguaje de programación";
                    CBA3.Text = "Entorno de Desarrollo";

                    vResCorrecta = 3;
                    break;

                case 5:
                    ClearBoxes();

                    LblPregunta.Text = "¿Cuál es la diferencia entre un algoritmo y un proceso?";

                    CBA1.Text = "El algoritmo es malicioso y el proceso es benigno";
                    CBA2.Text = "El algoritmo es un conjunto de operaciones a ejecutar, el proceso es un algoritmo en ejecución";
                    CBA3.Text = "El algoritmo es un proceso en ejecución, el proceso es un conjunto de operaciones a ejecutar";

                    vResCorrecta = 2;
                    break;

                case 6:
                    ClearBoxes();

                    LblPregunta.Text = "El diagrama de flujo suele utilizarse para:";

                    CBA1.Text = "Describir procesos, sistemas o algoritmos";
                    CBA2.Text = "Dibujar";
                    CBA3.Text = "Diseñar programas, infraestructuras y empresas";

                    vResCorrecta = 1;

                    BtnSig.Text = "Finalizar";
                    break;
            }
        }

        private void SiguientePag(object sender, EventArgs e)
        {
            if (vTagRes == vResCorrecta)
            {
                vPunt++;
            }

            if (vNumPregunta == vCantPreguntas)
            {
                vPorcentaje = (int)Math.Round((double)(vPunt * 100) / vCantPreguntas);

                MessageBox.Show("Examen Módulo #1 Finalizado!" + Environment.NewLine +
                    $"Total de preguntas acertadas: {vPunt}" + Environment.NewLine +
                    $"Puntuación: {vPorcentaje}%" + Environment.NewLine +
                    "Haga click en Ok para ir al menú principal");

                GuardarNota(User, vPorcentaje);
                this.Hide();
                Menu menu = new Menu();
                menu.User = User;
                menu.ShowDialog();
            }

            vNumPregunta++;
            MostrarPreg(vNumPregunta);
        }

        private void ClearBoxes()
        {
            CBA1.Checked = false;
            CBA2.Checked = false;
            CBA3.Checked = false;
        }

        private void FinExamen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vPorcentaje = (int)Math.Round((double)(vPunt * 100) / vCantPreguntas);

            MessageBox.Show("Examen Módulo #1 Finalizado!" + Environment.NewLine +
                $"Total de preguntas acertadas: {vPunt}" + Environment.NewLine +
                $"Puntuación: {vPorcentaje}%" + Environment.NewLine +
                "Haga click en Ok para ir al menú principal");

            GuardarNota(User, vPorcentaje);
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
            SqlCommand guardar = new SqlCommand("update Registrar set M1E='"+nota+"' where Username='"+user+"'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
