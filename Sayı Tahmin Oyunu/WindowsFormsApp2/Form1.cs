using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int sayi = 0, tahminSayisi = 0, puan = 1000;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = 0;
            tahminSayisi++;

            if (tahminSayisi <= 9)
            {
                tahmin = Convert.ToInt32(textBox1.Text);
                label6.Text = Convert.ToString(tahminSayisi);

                if(sayi < tahmin)
                {
                    label5.Text = "Tahmininizi Azaltınız.";
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                }
                else if (tahmin < sayi)
                {
                    label5.Text = "Tahmininizi Arttırınız.";
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                } 
                else
                {
                    label5.Text = "Tebrikler " + label6.Text + " defada bilip " + label7.Text + " puan aldınız.";
                    button2.Enabled = true;
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                }
            }else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin hakkınız kalmadı! Oyun Kapatılacak!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);

            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;

            tahminSayisi = 0;
            puan = 1000;

            label8.Text = "";
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
        }
    }
}
