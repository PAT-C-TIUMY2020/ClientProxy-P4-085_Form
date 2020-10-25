using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_085_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new
            ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);

            ServiceReference1.Koordinat a = new
            ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new
            ServiceReference1.Koordinat();
            a.X = 7;
            a.Y = 8;

            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) +
            Math.Pow(selisihY, 2));
            Console.WriteLine("Hasil Koordinat " + jarak);
            Console.ReadLine();

            textBox1.Text = "1";            textBox2.Text = "3";            textBox3.Text = "2";            textBox4.Text = "2";            textBox5.Text = jarak.ToString();            textBox6.Text = "2";            textBox7.Text = "2";            textBox8.Text = "2";            textBox9.Text = "2";            textBox10.Text = hasilTambah.ToString();            textBox11.Text = hasilKurang.ToString();            textBox12.Text = hasilKali.ToString();            textBox13.Text = hasilBagi.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
