using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Ortalama_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ders_adi;
            int vize, final, vize_agirlik, final_agirlik;
            double ortalama;
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) ||
            string.IsNullOrWhiteSpace(textBox4.Text) ||
            string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            ders_adi = textBox3.Text;
            vize = Convert.ToInt16(textBox1.Text);
            final = Convert.ToInt16(textBox2.Text);
            vize_agirlik = Convert.ToInt16(textBox4.Text);
            final_agirlik = Convert.ToInt16(textBox5.Text);
            if (vize_agirlik + final_agirlik != 100)
            {
                MessageBox.Show("Vize ve Final ağırlıklarının toplamı 100 olmalıdır.");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(ders_adi, @"^[a-zA-ZğüşöçıİĞÜŞÖÇ\s]+$"))
            {
                MessageBox.Show("Ders adı sadece harflerden oluşmalıdır.");
                return;
            }
            if (vize < 0 || vize > 100 || final < 0 || final > 100)
            {
                MessageBox.Show("Vize ve Final notları 0 ile 100 arasında olmalıdır.");
                return;
            }
            if (vize_agirlik < 0 || vize_agirlik > 100 || final_agirlik < 0 || final_agirlik > 100)
            {
                MessageBox.Show("Vize ve Final ağırlıkları 0 ile 100 arasında olmalıdır.");
                return;
            }
            
                ortalama = (vize * vize_agirlik / 100) + (final * final_agirlik / 100);
                richTextBox1.Text = "Ders Adı: " + ders_adi + "\n" +
                    "Vize Notu: " + vize + "\n" +
                    "Final Notu: " + final + "\n" +
                    "Ortalama: " + ortalama.ToString("0.00") + "\n";

            }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
