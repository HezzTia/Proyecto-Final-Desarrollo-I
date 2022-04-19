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
    public partial class M4 : Form
    {

        int vPunt;
        int vPorcentaje;
        int vNumPregunta = 1;
        int vResCorrecta;
        int vCantPreguntas;
        int vTagRes;

        public M4()
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

                    LblPregunta.Text = "¿Cuántos bucles hay en C#?";

                    CBA1.Text = "3";
                    CBA2.Text = "2";
                    CBA3.Text = "4";

                    vResCorrecta = 3;
                    break;

                case 2:
                    ClearBoxes();

                    LblPregunta.Text = "El bucle While:";

                    CBA1.Text = "Comprueba una condición y ejecuta unas sentencias hasta que la condición es falsa";
                    CBA2.Text = "Ejecuta unas sentencias y luego comprueba la condición";
                    CBA3.Text = "Se utiliza en aquellas situaciones en las cuales conocemos la cantidad de veces que se ejecutarán las sentencias";

                    vResCorrecta = 1;
                    break;

                case 3:
                    ClearBoxes();

                    LblPregunta.Text = "El bucle For:";

                    CBA1.Text = "Comprueba una condición y ejecuta unas sentencias hasta que la condición es falsa";
                    CBA2.Text = "Ejecuta unas sentencias y luego comprueba la condición";
                    CBA3.Text = "Se utiliza en aquellas situaciones en las cuales conocemos la cantidad de veces que se ejecutarán las sentencias";

                    vResCorrecta = 3;
                    break;

                case 4:
                    ClearBoxes();

                    LblPregunta.Text = "El bucle Do/While:";

                    CBA1.Text = "Comprueba una condición y ejecuta unas sentencias hasta que la condición es falsa";
                    CBA2.Text = "Ejecuta unas sentencias y luego comprueba la condición";
                    CBA3.Text = "Se utiliza en aquellas situaciones en las cuales conocemos la cantidad de veces que se ejecutarán las sentencias";

                    vResCorrecta = 2;
                    break;

                case 5:
                    ClearBoxes();

                    LblPregunta.Text = "Foreach se suele utilizar para:";

                    CBA1.Text = "Iterar con los elementos de un arreglo o colección";
                    CBA2.Text = "Agregar datos a una variable";
                    CBA3.Text = "Ejecutar sentencias cuando el valor de una variable es mayor a 0";

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

                MessageBox.Show("Examen Módulo #4 Finalizado!" + Environment.NewLine +
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

            MessageBox.Show("Examen Módulo #4 Finalizado!" + Environment.NewLine +
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
            SqlCommand guardar = new SqlCommand("update Registrar set M4E='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
