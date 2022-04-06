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
    public partial class Modulo5Pag2 : Form
    {
        public Modulo5Pag2()
        {
            InitializeComponent();
        }

        private void Modulo5Pag2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Modulo5Pag1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Modulo5Pag3().Show();
            this.Hide();
        }
    }
}
