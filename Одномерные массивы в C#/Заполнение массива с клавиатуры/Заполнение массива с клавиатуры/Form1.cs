using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Заполнение_массива_с_клавиатуры
{
    public partial class Form1 : Form
    {
        float[] a = new float[1000];
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = textBox1.Lines.Count();// количество строк
            textBox3.Text = Convert.ToString(n);
            textBox2.Clear();
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToSingle(textBox1.Lines[i]);
                // здесь будет обработка массива
                textBox2.Text = textBox2.Text +
                Convert.ToString(a[i]) + "\r\n";
            }
        }
    }
}
