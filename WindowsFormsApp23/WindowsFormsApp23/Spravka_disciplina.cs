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
    public partial class Spravka_disciplina : Form
    {
        public Spravka_disciplina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("danni3.dat"))
            {
                MessageBox.Show("Липсва файл: danni3.dat"); return;


            }
            int tarsene = comboBox1.SelectedIndex;
            
            dataGridView1.Rows.Clear();
            FileStream f = new FileStream("danni3.dat", FileMode.Open, FileAccess.Read);
            BinaryReader chete = new BinaryReader(f);
            string[] broi_kurs = { "1", "2", "3", "4" };
            
            string[] vid_disciplina = { "Компютърни архитектури", "Програмиране", "Математика", "Икономика", "Компютърни мрежи" };
            string[] vid_pol = { "мъж", "женa" };
            string data, ime ; int  faknomer, kurs, disciplina,  ocenka, pol;
            while (f.Position < f.Length)
            {
                data = chete.ReadString();
                faknomer = chete.ReadInt32();
                ime = chete.ReadString();
                kurs = chete.ReadInt32();
                disciplina = chete.ReadInt32();
                ocenka = chete.ReadInt32();
                pol = chete.ReadInt32();

                
                if(disciplina.ToString().Contains(tarsene.ToString()))
                dataGridView1.Rows.Add( data,ime, vid_disciplina [disciplina], ocenka,
                    vid_pol [pol]);
            }
            f.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
