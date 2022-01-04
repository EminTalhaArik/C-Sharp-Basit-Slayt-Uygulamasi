using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavProje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resimYolu = @".\Resimler\";
        int resimIndex = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "1";
            ResmiGuncelle();
        }

        private void ResmiGuncelle()
        {
            pictureBox1.ImageLocation = resimYolu + resimIndex + ".jpeg";
            label3.Text = resimIndex.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resimIndex = 1;
            ResmiGuncelle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resimIndex = 10;
            ResmiGuncelle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resimIndex == 1)
            {
                resimIndex = 10;
            }
            else
            {
                resimIndex--;
            }
            ResmiGuncelle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resimIndex == 10)
            {
                resimIndex = 1;
            }
            else
            {
                resimIndex++;
            }
            ResmiGuncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                timer1.Interval = Convert.ToInt32(float.Parse(comboBox1.Text) * 1000);

                if (!timer1.Enabled)
                    timer1.Start();

                KapatAc(false);
            }
            else
            {
                MessageBox.Show("Lütfen Resim Slayt Türünü Seçiniz!");
            }
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (resimIndex == 10)
                {
                    resimIndex = 1;
                }
                else
                {
                    resimIndex++;
                }
            }
            else
            {
                resimIndex = random.Next(1, 11);
            }
            ResmiGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }

            KapatAc(true);
        }

        private void KapatAc(bool deger)
        {
            button2.Enabled = !deger;
            button1.Enabled = deger;

            comboBox1.Enabled = deger;
            radioButton1.Enabled = deger;
            radioButton2.Enabled = deger;

            button3.Enabled = deger;
            button4.Enabled = deger;
            button5.Enabled = deger;
            button6.Enabled = deger;
        }
    }
}
