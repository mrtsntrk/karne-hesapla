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
    public partial class Sinif6 : Form
    {
        public Sinif6()
        {
            InitializeComponent();
        }

        public void hesaplama()
        {
            double d1, d2, d3, topla, sonuc;
            if(comboBox1.SelectedIndex == 0)
            {
                d1 = (Convert.ToDouble(textBox11.Text)*1);
                label27.Text = d1.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label27.Text);
                sonuc = topla / 30;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                d1 = (Convert.ToDouble(textBox11.Text) * 2);
                label27.Text = d1.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label27.Text);
                sonuc = topla / 31;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                d1 = (Convert.ToDouble(textBox11.Text) * 3);
                label27.Text = d1.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label27.Text);
                sonuc = topla / 32;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                d1 = (Convert.ToDouble(textBox11.Text) * 4);
                label27.Text = d1.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label27.Text);
                sonuc = topla / 33;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox2.SelectedIndex == 0)
            {
                d2 = (Convert.ToDouble(textBox12.Text) * 1);
                label28.Text = d2.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label28.Text);
                sonuc = topla / 30;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                d2 = (Convert.ToDouble(textBox12.Text) * 2);
                label28.Text = d2.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label28.Text);
                sonuc = topla / 31;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                d2 = (Convert.ToDouble(textBox12.Text) * 3);
                label28.Text = d2.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label28.Text);
                sonuc = topla / 32;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox2.SelectedIndex == 3)
            {
                d2 = (Convert.ToDouble(textBox12.Text) * 4);
                label28.Text = d2.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label28.Text);
                sonuc = topla / 33;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox3.SelectedIndex == 0)
            {
                d3 = (Convert.ToDouble(textBox13.Text) * 1);
                label29.Text = d3.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label29.Text);
                sonuc = topla / 30;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox3.SelectedIndex == 1)
            {
                d3 = (Convert.ToDouble(textBox13.Text) * 2);
                label29.Text = d3.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label29.Text);
                sonuc = topla / 31;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox3.SelectedIndex == 2)
            {
                d3 = (Convert.ToDouble(textBox13.Text) * 3);
                label29.Text = d3.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label29.Text);
                sonuc = topla / 32;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            if (comboBox3.SelectedIndex == 3)
            {
                d3 = (Convert.ToDouble(textBox13.Text) * 4);
                label29.Text = d3.ToString();
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3) + Convert.ToDouble(label29.Text);
                sonuc = topla / 33;
                label26.Text = sonuc.ToString();
            }
            else
            {
                topla = (Convert.ToDouble(textBox1.Text) * 2) + (Convert.ToDouble(textBox2.Text) * 2) + (Convert.ToDouble(textBox3.Text) * 2) + (Convert.ToDouble(textBox4.Text) * 4) + (Convert.ToDouble(textBox5.Text) * 1) + (Convert.ToDouble(textBox6.Text) * 5) + (Convert.ToDouble(textBox7.Text) * 1) + (Convert.ToDouble(textBox8.Text) * 3) + (Convert.ToDouble(textBox9.Text) * 6) + (Convert.ToDouble(textBox10.Text) * 3);
                sonuc = topla / 29;
                label26.Text = sonuc.ToString();
            }
            

        }
        private void Sinif6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)44;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesaplama();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if(Convert.ToDouble(label26.Text) < 50)
            {
                label31.ForeColor = Color.Red;
                label31.Text = "Malesef hiçbir belge almaya"+"\n"+"hak kazanamadınız";
            }
            if (Convert.ToDouble(label26.Text) >= 50 && Convert.ToDouble(label26.Text) < 60)
            {
                label31.ForeColor = Color.Orange;
                label31.Text = "Direk geçtiniz.";
            }
            if (Convert.ToDouble(label26.Text) >= 60 && Convert.ToDouble(label26.Text) < 70)
            {
                label31.ForeColor = Color.Blue;
                label31.Text = "Ortlama ile geçtiniz.";
            }
            if (Convert.ToDouble(label26.Text) >= 70 && Convert.ToDouble(label26.Text) < 84)
            {
                label31.ForeColor = Color.DarkBlue;
                label31.Text = "Tebrikler! Teşekkür belgesi almaya"+"\n"+ "hak kazandınız.";
            }
            if (Convert.ToDouble(label26.Text) >= 85)
            {
                label31.ForeColor = Color.DarkGreen;
                label31.Text = "Tebrikler! Teşekkür belgesi almaya"+"\n"+"hak kazandınız";
            }


        }
    }
}
