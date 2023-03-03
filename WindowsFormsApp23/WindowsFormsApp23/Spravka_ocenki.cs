using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp23
{
    public partial class Spravka_ocenki : Form
    {
        public Spravka_ocenki()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!File.Exists("danni3.dat"))
            {
                MessageBox.Show("Липсва файл: danni3.dat"); return;


            }
            string tarsene = textBox1.Text.ToUpper();
            dataGridView1.Rows.Clear();
            FileStream f = new FileStream("danni3.dat", FileMode.Open, FileAccess.Read);
            BinaryReader chete = new BinaryReader(f);
            string[] broi_kurs = { "1", "2", "3", "4" };
            string[] vid_disciplina = { "Компютърни архитектури", "Програмиране", "Математика", "Икономика", "Компютърни мрежи" };
            string[] vid_pol = { "мъж", "женa" };
            string data, ime; int faknomer, kurs, disciplina, ocenka, pol;
            while (f.Position < f.Length)
            {
                data = chete.ReadString();
                faknomer = chete.ReadInt32();
                ime = chete.ReadString();
                kurs = chete.ReadInt32();
                disciplina = chete.ReadInt32();
                ocenka = chete.ReadInt32();
                pol = chete.ReadInt32();


                if(ime.ToUpper().Contains(tarsene) )
                dataGridView1.Rows.Add(ime, vid_disciplina[disciplina], ocenka);
                   
            }
            f.Close();
        }
    }
    }

