using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        static void MenuMain()
        {
            Application.Run(new Menu());
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo1Pag1 modulo1Pag1 = new Modulo1Pag1();
            modulo1Pag1.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo2Pag1 modulo2Pag1 = new Modulo2Pag1();
            modulo2Pag1.ShowDialog();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exams.M1 m1 = new Exams.M1();
            m1.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exams.M2 m2 = new Exams.M2();
            m2.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exams.M3 m3 = new Exams.M3();
            m3.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Exams.M4 m4 = new Exams.M4();
            m4.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Exams.M5 m5 = new Exams.M5();
            m5.ShowDialog();
            this.Hide();
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modulo3Pag1 modulo3Pag1 = new Modulo3Pag1();
            modulo3Pag1.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Modulo4Pag1 modulo4Pag1 = new Modulo4Pag1();
            modulo4Pag1.ShowDialog();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Modulo5Pag1 modulo5Pag1 = new Modulo5Pag1();
            modulo5Pag1.ShowDialog();
            this.Hide();
        }
    }
}
