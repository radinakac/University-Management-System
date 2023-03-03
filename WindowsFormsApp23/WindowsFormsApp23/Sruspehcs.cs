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
    public partial class Sruspehcs : Form
    {
        public Sruspehcs()
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
            StreamReader p = new StreamReader("Otchet-sruspeh.txt");
            String line;
            while ((line = p.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            p.Close();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string[] vidove = new string[10];
            int [] broi = new int[10];
            double[] sruspeh = new double[10];


            StreamReader p = new StreamReader("Disciplini.txt");
            String line; int x = 0;
            while ((line = p.ReadLine()) != null)
            {
                vidove[x++] = line;
            }
            p.Close();

            FileStream f = new FileStream("danni3.dat", FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(f);
            while (f.Position<f.Length)
            {
               string data = r.ReadString();
               int  faknomer = r.ReadInt32();
               string  ime = r.ReadString();
               int kurs = r.ReadInt32();
               int disciplina = r.ReadInt32();
               int ocenka = r.ReadInt32();
                int br = r.ReadInt32();
                

                broi[disciplina] ++ ;
                sruspeh[disciplina] += ocenka;
            }

            StreamWriter txt = new StreamWriter("Otchet-sruspeh.txt");
            txt.WriteLine("СРЕДЕН УСПЕХ ПО ДИСЦИПЛИНИ");
            string ddd = DateTime.Today.ToString();
            ddd = ddd.Substring(0, ddd.IndexOf(" ") + 1);
            txt.WriteLine("към дата: "+ddd+"\n\n");
            txt.WriteLine("==============================================================");
            
            for(int i=0; i<10; i++)
            {
                if (vidove[i] == null) break;
                //txt.WriteLine(vidove[i] + "\t\t" + broi[i] + "\t\t" + sruspeh[i]/broi[i]);
                txt.WriteLine("{0,-30}{1,5}{2,10:F}", vidove[i], broi[i], sruspeh[i] / broi[i]);
                
            }
            txt.WriteLine("==============================================================");
            txt.WriteLine();
            txt.WriteLine("Подпис: ...............               " + DateTime.Now.ToString());
            txt.Close();
        }
    }
}
