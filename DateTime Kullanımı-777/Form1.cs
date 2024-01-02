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

namespace DateTime_Kullanımı_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "En Küçük: " + DateTime.MinValue;
            label2.Text = "En Büyük: " + DateTime.MaxValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Now  : " + DateTime.Now;
            label2.Text = "Today: " + DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat = new DateTime();
            tarihSaat = DateTime.Now;

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;

            label1.Text = tarihSaat.ToString();
            label2.Text = tarih.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = new DateTime(2022, 8, 25);


            label1.Text = "Tarih: " + bugun.ToShortDateString();
            label2.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = dateTimePicker1.Value;


            label1.Text = "Tarih: " + bugun.ToShortDateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label1.Text = bugun.ToString();
            label2.Text = bugun.AddDays(5).ToString() + " 5 gün eklendi."; //Bugünün tarihine 5 gün ekle.
            label3.Text = bugun.AddMonths(2).ToString() + " 2 ay eklendi.";//Bugünün tarihine 2 ay ekle.
            label4.Text = bugun.AddYears(2).ToString() + " 2 yıl eklendi.";//Bugünün tarihine 2 yıl ekle.
            label5.Text = bugun.AddHours(3).ToString() + " 3 saat eklendi.";//Anlık saate 3 saat ekle
            label6.Text = bugun.AddMinutes(15).ToString() + " 15 dakika eklendi.";//Anlık saate 15 dakika ekle.
            label7.Text = bugun.AddSeconds(20).ToString() + " 20 saniye eklendi.";//Anlık saate 2

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            DateTime sonOdeme = new DateTime(2022, 3, 30, 14, 30, 50, 20);
            label1.Text = "Bugün: " + bugun.ToString();
            label2.Text = "Son Ödeme: " + sonOdeme.ToString();
            TimeSpan tarihFark = sonOdeme - bugun;
            label3.Text = "Gün Farkı: " + tarihFark.Days.ToString();
            label4.Text = "Saat Farkı: " + tarihFark.Hours.ToString();
            label5.Text = "Dakika Farkı: " + tarihFark.Minutes.ToString();
            label6.Text = "Saniye Farkı: " + tarihFark.Seconds.ToString();
            label7.Text = "MiliSaniye Farkı: " + tarihFark.Milliseconds.ToString();
        }

       
    }
}

