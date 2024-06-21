using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сохранение_и_чтение_массивов
{
    public partial class Form1 : Form
    {
        float[] a = new float[1000];
        int n;
        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
             saveFileDialog1.ShowDialog();
            string f = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(f, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.ShowDialog();
           string f = openFileDialog1.FileName;
           textBox2.Text = System.IO.File.ReadAllText(f);
            MessageBox.Show(" Файл открыт ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            for (int i = 0; i < n; i++)
            {
                float temp = rand.Next(1, 99);
                a[i] = temp / 10;
                textBox2.Text = textBox2.Text +
                Convert.ToString(a[i]) + "\r\n";
            }
        }
    }
}
