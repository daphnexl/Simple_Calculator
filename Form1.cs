using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        private char islem;
        private bool ekranTemizleme;
        private int ilkSayi;
        
        public Form1()
        {
            InitializeComponent();
        }
         private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (ekranTemizleme)
            {
                ekranLabel.Text = "";
                ekranTemizleme = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }
        private void buttontopla_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizleme = true;
            ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }
        private void buttoncikar_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizleme = true;
            ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }
        private void buttoncarp_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranTemizleme = true;
            ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }
        private void buttonbol_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizleme = true;
            ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }
        private void buttonsil_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
        private void buttonesittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (islem)
            {
                case '+':
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0; break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

    }
    
}
