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
    public partial class Vavejdane : Form
    {
        public Vavejdane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Липсва факултетен номер! ");
                textBox1.Focus(); return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show(" Липсва име на студента! ");
                textBox2.Focus(); return;
            }
            if (comboBox3.SelectedIndex==-1)
            {
                MessageBox.Show(" Изберете курс!");
                comboBox3.Focus(); return;
                
            }
            if(comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show(" Не сте избрали дисциплина! ");
                comboBox1.Focus(); return;
            }
            if(numericUpDown2.Value==0)
            {
                MessageBox.Show(" Посочете оценка! ");
                numericUpDown2.Focus(); return;
            }
            if(comboBox2.SelectedIndex== -1)
            {
                MessageBox.Show(" Не сте избрали пол! ");
                comboBox2.Focus(); return;
            }
            string data = dateTimePicker1.Value.ToString();
            int faknomer = 0;
            
            
            try
            {
                faknomer = int.Parse(textBox1.Text);
            }
            catch (FormatException z)
            {
                MessageBox.Show("Некоректен факултетен номер!");
                faknomer = 0;
            };
            string ime = textBox2.Text;
            int kurs = comboBox3.SelectedIndex;
            int disciplina = comboBox1.SelectedIndex;
            int ocenka = (int)numericUpDown2.Value;
            int pol = comboBox2.SelectedIndex;

            FileStream fp = new FileStream("danni3.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter zapis = new BinaryWriter(fp);
            fp.Seek(0, SeekOrigin.End);
            zapis.Write(data); zapis.Write(faknomer); zapis.Write(ime); zapis.Write(kurs);
            zapis.Write(disciplina); zapis.Write(ocenka); zapis.Write(pol);
            fp.Close();
            MessageBox.Show(" Студентът е записан. ");
            Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Vavejdane_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            StreamReader vid = new StreamReader("Disciplini.txt");
            
            while (!vid.EndOfStream)
            {
                string red = vid.ReadLine();
                comboBox1.Items.Add(red);
                
            }
            vid.Close();

            comboBox2.Items.Clear();
            StreamReader pol = new StreamReader("Pol.txt");
            while (!pol.EndOfStream)
            {
                string red = pol.ReadLine();
                comboBox2.Items.Add(red);

            }
            vid.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
