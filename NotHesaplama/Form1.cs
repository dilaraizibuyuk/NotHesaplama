using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
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

        private void button1_Click(object sender, EventArgs e)
        {
            double vize1, vize2, ortalama;
            vize1 = Convert.ToDouble(textBox2.Text);
            vize2 = Convert.ToDouble(textBox3.Text);
            ortalama = (vize1 + vize2) / 2;
            textBox4.Text = ortalama.ToString();
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);

            if (ortalama>=65)
            {
                listBox5.Items.Add("Geçtin!");
            }
            else
                listBox5.Items.Add("Kaldın!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
