﻿using System;
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
    public partial class M5 : Form
    {

        int vPunt;
        int vPorcentaje;
        int vNumPregunta = 1;
        int vResCorrecta;
        int vCantPreguntas;
        int vTagRes;

        public M5()
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

                    LblPregunta.Text = "¿Cuál es la función de un arreglo?";

                    CBA1.Text = "Organizar datos numéricos de menor a mayor";
                    CBA2.Text = "Organizar datos de texto desde la A a la Z";
                    CBA3.Text = "Almacenar una colección de datos del mismo tipo";

                    vResCorrecta = 3;
                    break;

                case 2:
                    ClearBoxes();

                    LblPregunta.Text = "¿Qué número recibe la primera posición de un arreglo?";

                    CBA1.Text = "1";
                    CBA2.Text = "0";
                    CBA3.Text = "N - 1";

                    vResCorrecta = 2;
                    break;

                case 3:
                    ClearBoxes();

                    LblPregunta.Text = "¿La lista es un tipo de arreglo?";

                    CBA1.Text = "Verdadero";
                    CBA2.Text = "Falso";
                    CBA3.Text = "' OR 1==1 '";

                    vResCorrecta = 1;
                    break;

                case 4:
                    ClearBoxes();

                    LblPregunta.Text = "¿Qué es un método?";

                    CBA1.Text = "Es una secuencia de enunciados dentro de una unidad lógica de un programa";
                    CBA2.Text = "Es una serie de secuencias que se ejecutan en base a una condición dada";
                    CBA3.Text = "Es un objeto que almacena valores";

                    vResCorrecta = 1;
                    break;

                case 5:
                    ClearBoxes();

                    LblPregunta.Text = "¿Qué ventaja brindan los métodos?";

                    CBA1.Text = "Mayor rápidez en el código";
                    CBA2.Text = "Un código objeto más estetico";
                    CBA3.Text = "Código fuente mejor organizado y legible";

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

                MessageBox.Show("Examen Módulo #5 Finalizado!" + Environment.NewLine +
                    $"Total de preguntas acertadas: {vPunt}" + Environment.NewLine +
                    $"Puntuación: {vPorcentaje}%" + Environment.NewLine +
                    "Haga click en Ok para ir al menú principal");

                if (vPorcentaje >= 75)
                {
                    MessageBox.Show("¡Felicidades!" + Environment.NewLine + 
                                    "Usted ha aprobado satisfactoriamente el curso de C#" + Environment.NewLine +
                                    "En las próximas 48 horas nos pondremos en contacto" + Environment.NewLine + 
                                    "para entregarle su certificado");
                }

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

            MessageBox.Show("Examen Módulo #5 Finalizado!" + Environment.NewLine +
                $"Total de preguntas acertadas: {vPunt}" + Environment.NewLine +
                $"Puntuación: {vPorcentaje}%" + Environment.NewLine +
                "Haga click en Ok para ir al menú principal");

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
            SqlCommand guardar = new SqlCommand("update Registrar set M5E='" + nota + "' where Username='" + user + "'", conexion.con);


            guardar.ExecuteNonQuery();

            conexion.CerrarConexion();


            return true;
        }
    }
}
