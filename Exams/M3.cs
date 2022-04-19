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
    public partial class M3 : Form
    {

        int vPunt;
        int vPorcentaje;
        int vNumPregunta = 1;
        int vResCorrecta;
        int vCantPreguntas;
        int vTagRes;

        public M3()
        {
            InitializeComponent();

            MostrarPreg(vNumPregunta);

            vCantPreguntas = 5;
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

                    LblPregunta.Text = "Las estructuras de toma de decisiones de C# son:";

                    CBA1.Text = "If, else, elif y switch";
                    CBA2.Text = "If y Switch";
                    CBA3.Text = "If, Else, Switch y Case";

                    vResCorrecta = 2;
                    break;

                case 2:
                    ClearBoxes();

                    LblPregunta.Text = "El acumulador es:";

                    CBA1.Text = "Una variable utilizada para sumar datos";
                    CBA2.Text = "Una variable utilizada para guardar datos";
                    CBA3.Text = "Una variable que almacena más de un valor";

                    vResCorrecta = 1;
                    break;

                case 3:
                    ClearBoxes();

                    LblPregunta.Text = "El contador es:";

                    CBA1.Text = "Constante que cuenta las veces que se repite un ciclo";
                    CBA2.Text = "Variable que almacena solo números";
                    CBA3.Text = "Variable utilizada específicamente para contar";

                    vResCorrecta = 3;
                    break;

                case 4:
                    ClearBoxes();

                    LblPregunta.Text = "Son tipos de la estructura if:";

                    CBA1.Text = "if y else";
                    CBA2.Text = "If then, if then else e if then else if";
                    CBA3.Text = "If, if then, if then else, if then else if e if anidado";

                    vResCorrecta = 2;
                    break;

                case 5:
                    ClearBoxes();

                    LblPregunta.Text = "Es una mala práctica de uso de If:";

                    CBA1.Text = "If then else if";
                    CBA2.Text = "If then";
                    CBA3.Text = "Else";

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
            SqlCommand guardar = new SqlCommand("update Registrar set M3E='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
