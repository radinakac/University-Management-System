using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show(" Сигурни ли сте? ", " Изход от програмата ", MessageBoxButtons.YesNo)==
           DialogResult.Yes) Close();


        }

        private void въвежданеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vavejdane().Show();
        }

        private void всичкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Izvejdane().Show();

        }

        private void поДисциплинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Spravka_disciplina().Show();
        }

        private void наОценкиПоИмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Spravka_ocenki().Show();
        }

        private void среденУспехToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sruspehcs().Show();
        }

        private void полToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pol().Show();


        }
    }
}
