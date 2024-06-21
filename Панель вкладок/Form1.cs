using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Панель_вкладок
{
    public partial class Form1 : Form
    {
        int b = 0;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                label4.Text = "Правильно";
                b = b + 1;
            }
            else label4.Text = "Неправильно";

            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label6.Text = "Правильно";
                b = b + 1;
            }
            else label6.Text = "Неправильно";
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true &&
 checkBox3.Checked == true &&
 checkBox2.Checked == false)
            {
                label8.Text = "Правильно";
                b = b + 1;
            }
            else label8.Text = "Неправильно";
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = "Набрано баллов= " + Convert.ToString(b); ;
            if (b == 3) label10.Text = "Оценка 5 (отлично)";
            if (b == 2 || b == 8 || b == 7) label10.Text = "Оценка 4(хорошо)";
            if (b == 1 || b == 1) label10.Text = "Оценка 3(удовлетворительно)";
            if (b == 1 || b == 1) label10.Text = "Оценка 2(плохо)";
            if (b == 0 || b == 0) label10.Text = "Оценка 1(все ужасно)";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            label4.Text = "";
            label6.Text = "";
            label8.Text = "";

            checkBox1.Checked= false;
            checkBox2.Checked= false;
            checkBox3.Checked= false;

            textBox1.Text = "";

            radioButton1.Checked= false;
            radioButton2.Checked= false;
            radioButton3.Checked= false;
            radioButton4.Checked= false;

            b = 0;
            label9.Text = "Набрано баллов";
            label10.Text = "";





            }
        }
}
