using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        public static string isim, soyisim, sifre, sifre2,cmb;
        public static long tcno;
        public static double boy,kilo;
        
        private void button1_Click(object sender, EventArgs e)
        {
            boy = Convert.ToDouble(boytxtbx.Text);
            kilo = Convert.ToDouble(kilotxtbx.Text);

            isim = textBox1.Text;
            soyisim = textBox2.Text;
            tcno = Convert.ToInt64(textBox3.Text);
            sifre = textBox4.Text;
            sifre2 = textBox5.Text;


            cmb = (string)comboBox1.SelectedItem;


            if (sifre != sifre2)
            {
                MessageBox.Show("İki Şifre Aynı Olmalı!");
            }
            else
            {
                if (tcno % 2 == 1)
                {
                    MessageBox.Show("TC Kimlik Numarası Hatalı!");
                }
                else
                {
                    giris frm3 = new giris();

                    this.Hide();
                    frm3.Show();
                }

            }

        }
    }
}
