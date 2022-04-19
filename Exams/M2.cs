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

namespace ProyectoFinal.Exams
{
    public partial class M2 : Form
    {

        int vPunt;
        int vPorcentaje;
        int vNumPregunta = 1;
        int vResCorrecta;
        int vCantPreguntas;
        int vTagRes;

        public M2()
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

                    LblPregunta.Text = "¿Cuántos tipos de datos posee C# en total?";

                    CBA1.Text = "8";
                    CBA2.Text = "14";
                    CBA3.Text = "16";

                    vResCorrecta = 3;
                    break;

                case 2:
                    ClearBoxes();

                    LblPregunta.Text = "¿En cuáles grupos se dividen los tipos de datos?";

                    CBA1.Text = "Dos: simples y no simples";
                    CBA2.Text = "Dos: variables y constantes";
                    CBA3.Text = "Tres: númericos, matemáticos y de texto";

                    vResCorrecta = 1;
                    break;

                case 3:
                    ClearBoxes();

                    LblPregunta.Text = "¿Cuáles son los tipos de operadores?";

                    CBA1.Text = "Matemáticos, decisivos, booleanos y relacionales";
                    CBA2.Text = "Lógicos e ilógicos";
                    CBA3.Text = "Aritméticos, lógicos, de asignación y relacionales";

                    vResCorrecta = 3;
                    break;

                case 4:
                    ClearBoxes();

                    LblPregunta.Text = "Un ejemplo de operador relacional es:";

                    CBA1.Text = "=, compara si un valor es igual a otro";
                    CBA2.Text = "<, compara si un valor es menor que otro";
                    CBA3.Text = "==, asigna valor a una variable";

                    vResCorrecta = 2;
                    break;

                case 5:
                    ClearBoxes();

                    LblPregunta.Text = "Un ejemplo de operador de asignación es:";

                    CBA1.Text = "=, asigna valor a una variable";
                    CBA2.Text = "++, asigna dos valores a una variable";
                    CBA3.Text = "--, resta dos valores a una variable";

                    vResCorrecta = 1;
                    break;

                case 6:
                    ClearBoxes();

                    LblPregunta.Text = "Un ejemplo de operador lógico es:";

                    CBA1.Text = "!, exclamación";
                    CBA2.Text = "||, AND";
                    CBA3.Text = "||, OR";

                    vResCorrecta = 3;

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

                MessageBox.Show("Examen Módulo #2 Finalizado!" + Environment.NewLine +
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

            MessageBox.Show("Examen Módulo #2 Finalizado!" + Environment.NewLine +
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
            SqlCommand guardar = new SqlCommand("update Registrar set M2E='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
