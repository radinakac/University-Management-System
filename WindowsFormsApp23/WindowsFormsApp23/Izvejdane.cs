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
    public partial class Izvejdane : Form
    {
        public Izvejdane()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( !File.Exists("danni3.dat"))
            {
                MessageBox.Show("Липсва файл: danni3.dat"); return;

            }
            FileStream f = new FileStream("danni3.dat", FileMode.Open, FileAccess.Read);
            BinaryReader chete = new BinaryReader(f);
            dataGridView1.Rows.Clear();
            string[] broi_kurs = { "1", "2", "3", "4" };
            string[] vid_disciplina = new string[10]; //= { "Компютърни архитектури", "Програмиране", "Математика", "Икономика", "Компютърни мрежи" };
            StreamReader vid = new StreamReader("Disciplini.txt");
            int elem = 0;
            while (!vid.EndOfStream)
            {
                string red = vid.ReadLine();
                vid_disciplina [elem++] = red;
            }
            vid.Close();
            string[] vid_pol = { "мъж", "женa" };

            string data, ime;   int nomer=0, faknomer, kurs, disciplina, ocenka, pol;
            while (f.Position < f.Length)
            {
                data = chete.ReadString();
                faknomer = chete.ReadInt32();
                ime = chete.ReadString();
                kurs = chete.ReadInt32();
                disciplina = chete.ReadInt32();
                ocenka = chete.ReadInt32();
                pol = chete.ReadInt32();
                dataGridView1.Rows.Add(++nomer, data, faknomer, ime,broi_kurs [kurs], vid_disciplina [disciplina], ocenka, 
                    vid_pol [pol]);
            }
            f.Close();

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("danni3.dat", FileMode.Open, FileAccess.Read);
            BinaryReader chete = new BinaryReader(f);

            FileStream f2 = new FileStream("temp.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter pishi = new BinaryWriter(f2);


            string data, ime; int nomer = 0, faknomer, kurs, disciplina, ocenka, pol;
            while (f.Position < f.Length)
            {
                data = chete.ReadString();
                faknomer = chete.ReadInt32();
                ime = chete.ReadString();
                kurs = chete.ReadInt32();
                disciplina = chete.ReadInt32();
                ocenka = chete.ReadInt32();
                pol = chete.ReadInt32();
                if (faknomer!=0 ) { pishi.Write(data); pishi.Write(faknomer); pishi.Write(ime); pishi.Write(kurs); pishi.Write(disciplina);
                    pishi.Write(ocenka); pishi.Write(pol);
                }
                
            }
            f.Close();
            f2.Close();
            File.Delete("danni3.dat");
            File.Copy("temp.dat", "danni3.dat");
            MessageBox.Show("Студентите с 0 фак. номер са премахнати!");
        }
    }
}
