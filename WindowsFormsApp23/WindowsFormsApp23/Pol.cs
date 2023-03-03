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
    public partial class Pol : Form
    {
        public Pol()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            StreamReader l = new StreamReader("Otchet-pol.txt");
            String line;
            while ((line = l.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            l.Close();






        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] polove = new string[10];
            int[] broi = new int[10];
            double[] sruspeh = new double[10];

            StreamReader l = new StreamReader("Pol.txt");
            String line; int x = 0;
            while ((line = l.ReadLine()) != null)
            {
                polove[x++] = line;
            }
            l.Close();

            FileStream f = new FileStream("danni3.dat", FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(f);
            while (f.Position < f.Length)
            {
                string data = r.ReadString();
                int faknomer = r.ReadInt32();
                string ime = r.ReadString();
                int kurs = r.ReadInt32();
                int disciplina = r.ReadInt32();
                int ocenka = r.ReadInt32();
                int pol = r.ReadInt32();


                broi[pol] ++;
                sruspeh[pol] += ocenka;
                
            }
            StreamWriter txt = new StreamWriter("Otchet-pol.txt");
            txt.WriteLine("УСПЕХ ПО ПОЛ");
            string ddd = DateTime.Today.ToString();
            ddd = ddd.Substring(0, ddd.IndexOf(" ") + 1);
            txt.WriteLine("към дата: " + ddd + "\n\n");
            txt.WriteLine("==============================================================");

            for (int i = 0; i < 10; i++)
            {
                if (polove[i] == null) break;
                txt.WriteLine(polove[i] + "\t\t"  + sruspeh[i]/broi[i]);
                
                
                
                


            }
            txt.WriteLine("==============================================================");
            txt.WriteLine();
            txt.WriteLine("Подпис: ...............               " + DateTime.Now.ToString());
            txt.Close();
            


        }
    }
    }
