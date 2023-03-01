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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string sifre,sifre2;
            long ad,ad2;
            ad = kayit.tcno;
            sifre = kayit.sifre;

            ad2 = Convert.ToInt64(textBox1.Text);
            sifre2 = textBox2.Text;
            if (ad==ad2 && sifre==sifre2)
            {
                Form1 frm1 = new Form1();

                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Sifre Veya TCNO Hatalı!");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit frm3 = new kayit();

            this.Hide();
            frm3.Show();
        }
    }
}
