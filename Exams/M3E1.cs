using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Exams
{
    public partial class M3E1 : Form
    {
        public M3E1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M3E2 m3e2 = new M3E2();
            m3e2.ShowDialog();
        }
    }
}
