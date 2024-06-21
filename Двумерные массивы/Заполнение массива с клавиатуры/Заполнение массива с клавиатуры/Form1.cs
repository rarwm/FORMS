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
        float[,] a = new float[100, 100];
        int i, j, n, m;

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
            // здесь может быть обработка массива...
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    dataGridView2[j, i].Value = Convert.ToString(a[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text); // определяем число строк
            m = Convert.ToInt32(textBox2.Text); // определяем число столбцов
                                                // задаем размеры таблицы
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
