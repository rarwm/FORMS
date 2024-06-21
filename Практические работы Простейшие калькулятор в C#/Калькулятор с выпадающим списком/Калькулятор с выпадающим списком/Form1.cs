using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_с_выпадающим_списком
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = 0;
            int k = comboBox1.SelectedIndex;
            if (k == 0) c = a + b;
            if (k == 1) c = a - b;
            if (k == 2) c = a * b;
            if (k == 3) c = a / b;
            textBox3.Text = Convert.ToString(c);

        }
    }
}
