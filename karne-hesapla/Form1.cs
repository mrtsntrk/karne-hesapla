using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karne_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OkullarKapanacak()
        {
            int gun, saat, dakika, saniye, ay, yl;
            DateTime dt = new DateTime(2018, 06, 8, 00, 00, 00);//YIL,AY,GUN,SAAT,DAKIKA,SANIYE
            long tic = dt.Ticks;
            gun = dt.Day - DateTime.Now.Day;
            saat = dt.Hour - DateTime.Now.Hour;
            dakika = dt.Minute - DateTime.Now.Minute;
            saniye = dt.Second - DateTime.Now.Second;
            ay = dt.Month - DateTime.Now.Month;
            yl = dt.Year - DateTime.Now.Year;
            if (gun < 0) gun += 30;
            //if (saat < 0) saat += 24;
            //if (dakika < 0) dakika += 60;
            //if (saniye < 0) saniye += 60;
            if (ay < 0) ay += 12;
            if (yl < 0) yl += 1;
            label5.Text = gun.ToString("0") + " gun ";
            //label2.Text = saat.ToString("00") + " saat ";
            //label3.Text = dakika.ToString("00") + " dakika ";
            //label4.Text = saniye.ToString("00") + " saniye kaldi";
            label4.Text = ay.ToString("0") + " ay ";
            label3.Text = yl.ToString("0") + " yıl ";
        }
        public void Okullaracilacak()
        {
            int gun, saat, dakika, saniye, ay, yl;
            DateTime dt = new DateTime(2018, 09, 17, 00, 00, 00);//YIL,AY,GUN,SAAT,DAKIKA,SANIYE
            long tic = dt.Ticks;
            gun = dt.Day - DateTime.Now.Day;
            saat = dt.Hour - DateTime.Now.Hour;
            dakika = dt.Minute - DateTime.Now.Minute;
            saniye = dt.Second - DateTime.Now.Second;
            ay = dt.Month - DateTime.Now.Month;
            yl = dt.Year - DateTime.Now.Year;
            if (gun < 0) gun += 30;
            //if (saat < 0) saat += 24;
            //if (dakika < 0) dakika += 60;
            //if (saniye < 0) saniye += 60;
            if (ay < 0) ay += 12;
            if (yl < 0) yl += 1;
            label9.Text = gun.ToString("0") + " gun ";
            //label2.Text = saat.ToString("00") + " saat ";
            //label3.Text = dakika.ToString("00") + " dakika ";
            //label4.Text = saniye.ToString("00") + " saniye kaldi";
            label8.Text = ay.ToString("0") + " ay ";
            label7.Text = yl.ToString("0") + " yıl ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OkullarKapanacak();
            Okullaracilacak();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Sinif6 sinif6 = new Sinif6();
                sinif6.Show();
            }
            if(comboBox1.SelectedIndex == 1)
            {
                Sinif7 sinif7 = new Sinif7();
                sinif7.Show();
            }
        }
    }
}
