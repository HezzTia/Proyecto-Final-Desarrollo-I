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
    public partial class M1E1 : Form
    {
        public static void Whatever()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new M1E1());
        }
        public M1E1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void M1Exam_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void M1E1F1_Click(object sender, EventArgs e)
        {

        }

        private void M1E1B1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M1E2 M1e2 = new M1E2();
            M1e2.ShowDialog();
            M1e2 = null;
            Show();
        }
    }
}
