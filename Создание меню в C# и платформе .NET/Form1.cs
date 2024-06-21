using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Создание_меню_в_C__и_платформе.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Рис1.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Рис2.jpg");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Рис3.jpg");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\user\Desktop\Раб\Коты"; // Замените путь на свой путь к папке forms
            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening folder: " + ex.Message);
            }

        }
    }
} 

