using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int artiKontrol = 0;
        int eksiKontrol = 0;
        int carpimKontrol = 0;
        int bolmeKontrol = 0;
        double ilksayi;
        double ikincisayi;
        private void button1_Click(object sender, EventArgs e)
        {

            string bir = "1";
            textBox1.Text += bir;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string sifir = "0";
            textBox1.Text += sifir;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string iki = "2";
            textBox1.Text += iki;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string uc = "3";
            textBox1.Text +=uc;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string dort = "4";
            textBox1.Text += dort;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string bes = "5";
            textBox1.Text += bes;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string alti = "6";
            textBox1.Text += alti;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string yedi = "7";
            textBox1.Text += yedi;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string sekiz = "8";
            textBox1.Text += sekiz;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string dokuz = "9";
            textBox1.Text += dokuz;
        }

        private void button15_Click(object sender, EventArgs e) // VİRGÜL
        {
            string virgül = ",";
            textBox1.Text += virgül;
        }

       

        private void button17_Click(object sender, EventArgs e) // EŞİTTİR BUTONU
        {
            ikincisayi=Convert.ToDouble(textBox1.Text);
            double sonuc = 0;
            if (artiKontrol == 1)
            {
                sonuc = ilksayi + ikincisayi;
                textBox1.Text=Convert.ToString(sonuc);
                artiKontrol = 0;
            }
            else if (eksiKontrol == 1) {
                sonuc = ilksayi - ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                eksiKontrol = 0;
            }
            else if (carpimKontrol == 1)
            {
                sonuc = ilksayi * ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                carpimKontrol = 0;
            }
            if (bolmeKontrol == 1 && ikincisayi != 0)
            {
                sonuc = ilksayi / ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                bolmeKontrol = 0;
            }
            else if (bolmeKontrol == 1 && ikincisayi == 0)
            {

                textBox1.Font = new Font("Segoe Script",11);
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.Text = "SIFIRA BÖLÜNEMEZ";
                bolmeKontrol = 0;

            }


        }
        private void button16_Click(object sender, EventArgs e) // TOPLAMA İŞLEMİ
        {
            
            ilksayi=Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            artiKontrol++;

        }
        private void button13_Click(object sender, EventArgs e) // ÇIKARMA İŞLEMİ
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            eksiKontrol++;

        }

        private void button10_Click(object sender, EventArgs e)  // ÇARPMA İŞLEMİ 
        {
            ilksayi = Convert.ToDouble(textBox1.Text); 
            textBox1.Text = "";
            carpimKontrol++;
        }

        private void button11_Click(object sender, EventArgs e) // BÖLME İŞLEMİ
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            bolmeKontrol++;
        }



        private void button12_Click_1(object sender, EventArgs e) // SİLME BUTONU
        {
            string ekran = "";
            textBox1.Text = ekran;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }
    }
}
