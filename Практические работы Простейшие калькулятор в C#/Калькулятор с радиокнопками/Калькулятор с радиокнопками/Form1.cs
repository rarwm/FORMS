using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_с_радиокнопками
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = 0;
            if (radioButton1.Checked == true) c = a + b;
            if (radioButton2.Checked == true) c = a - b;
            if (radioButton3.Checked == true) c = a * b;
            if (radioButton4.Checked == true) c = a / b;
            textBox3.Text = Convert.ToString(c);
        }
    }
}
