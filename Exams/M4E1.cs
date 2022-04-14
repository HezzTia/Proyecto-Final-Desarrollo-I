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
    public partial class M4E1 : Form
    {
        public M4E1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M4E2 m4e2 = new M4E2();
            m4e2.ShowDialog();
        }
    }
}
