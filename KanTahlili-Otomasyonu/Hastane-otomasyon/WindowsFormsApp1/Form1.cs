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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label11.Text = "Merhaba " + kayit.isim + " " + kayit.soyisim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double glukoz, hdl,ldl,b12,hidroksi,demir,mg,alb,index;

            glukoz = Convert.ToInt32(textBox1.Text);
            hdl = Convert.ToInt32(textBox2.Text);
            ldl = Convert.ToInt32(textBox3.Text);
            b12 = Convert.ToInt32(textBox4.Text);
            hidroksi = Convert.ToInt32(this.alb.Text);
            demir = Convert.ToDouble(this.mg.Text);
            mg = Convert.ToInt32(textBox7.Text);
            alb = Convert.ToInt32(textBox8.Text);



            Form2 frm2 = new Form2();
            if (glukoz > 100)
            {
                frm2.label25.Text =glukoz+" Yüksek";
                frm2.label25.ForeColor = Color.Red;
                if (glukoz<150)
                {
                    frm2.bolumlstbx.Items.Add("Glukoz Seviyeniz " + glukoz + " Dahiliye Bölümünden Randevu Alabilirsiniz");
                }
                
                frm2.bolumlstbx.Items.Add("Glukoz Seviyeniz " + glukoz + " Endokronoloji  Bölümünden Randevu Alabilirsiniz");
            }
            else if (glukoz < 70)
            {
                frm2.label25.Text = glukoz + " Düşük";
                frm2.label25.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("Glukoz Seviyeniz " + glukoz + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label25.Text = glukoz + " İyi";
                frm2.label25.ForeColor = Color.Green;

            }

            /////////////////////////////////////////////

            if (hdl > 70)
            {
                frm2.label24.Text = hdl + " Yüksek";
                frm2.label24.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("HDL Kolestrol Seviyeniz " + hdl + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }
            else if (hdl < 45)
            {
                frm2.label24.Text = hdl + " Düşük";
                frm2.label24.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("HDL Kolestrol Seviyeniz " + hdl + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label24.Text = hdl + " İyi";
                frm2.label24.ForeColor = Color.Green;

            }

            /////////////////////////////////////////////

            if (ldl > 130)
            {
                frm2.label23.Text = ldl + " Yüksek";
                frm2.label23.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("LDL Kolestrol Seviyeniz " + ldl + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }
            else if (ldl < 0)
            {
                frm2.label23.Text = ldl + " Düşük";
                frm2.label23.ForeColor = Color.Blue;
            }
            else
            {
                frm2.label23.Text = ldl + " İyi";
                frm2.label23.ForeColor = Color.Green;
            }

            /////////////////////////////////////////////

            if (b12 > 883)
            {
                frm2.label22.Text = b12 + " Yüksek";
                frm2.label22.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("B12 Seviyeniz " + b12 + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }
            else if (b12 < 187)
            {
                frm2.label22.Text = b12 + " Düşük";
                frm2.label22.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("B12l Seviyeniz " + b12 + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label22.Text = b12 + " İyi";
                frm2.label22.ForeColor = Color.Green;
            }

            /////////////////////////////////////////////

            if (hidroksi > 55)
            {
                frm2.label21.Text = hidroksi + " Yüksek";
                frm2.label21.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("Hidroksi Seviyeniz " + hidroksi + " Endokronoloji  Bölümünden Randevu Alabilirsiniz");
            }
            else if (hidroksi < 25)
            {
                frm2.label21.Text = hidroksi + " Düşük";
                frm2.label21.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("Hidroksi Seviyeniz " + hidroksi + " Endokronoloji  Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label21.Text = hidroksi + " İyi";
                frm2.label21.ForeColor = Color.Green;
            }

            /////////////////////////////////////////////

            if (demir > 144)
            {
                frm2.label20.Text = demir + " Yüksek";
                frm2.label20.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("Demir Seviyeniz " + demir + " Dahiliye  Bölümünden Randevu Alabilirsiniz");
            }
            else if (demir < 31)
            {
                frm2.label20.Text = demir + " Düşük";
                frm2.label20.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("Demir Seviyeniz " + demir + " Dahiliye  Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label20.Text = demir + " İyi";
                frm2.label20.ForeColor = Color.Green;
            }

            /////////////////////////////////////////////

            if (mg > 2.6)
            {
                frm2.label19.Text = mg + " Yüksek";
                frm2.label19.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("Magnezyum Seviyeniz " + mg + " Dahiliye  Bölümünden Randevu Alabilirsiniz");
            }
            else if (mg < 1.6)
            {
                frm2.label19.Text = mg + " Düşük";
                frm2.label19.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("Magnezyum Seviyeniz " + mg + " Dahiliye  Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label19.Text = mg + " İyi";
                frm2.label19.ForeColor = Color.Green;
            }

            /////////////////////////////////////////////

            if (alb > 50)
            {
                frm2.label18.Text = alb + " Yüksek";
                frm2.label18.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("Albümin Seviyeniz " + alb + " Nefroloji Bölümünden Randevu Alabilirsiniz");
            }
            else if (alb < 35)
            {
                frm2.label18.Text = alb + " Düşük";
                frm2.label18.ForeColor = Color.Blue;
                frm2.bolumlstbx.Items.Add("Albümin Seviyeniz " + alb + " Nefroloji Bölümünden Randevu Alabilirsiniz");
            }
            else
            {
                frm2.label18.Text = alb + " İyi";
                frm2.label18.ForeColor = Color.Green;
            }

            /////////////////////////////////////////////
            ///


            index = Convert.ToInt32( kayit.kilo / (kayit.boy * kayit.boy) * 10000);


            if ( index < 18.5)
            {
                frm2.label30.Text = index + " BMI - Zayıf";
                frm2.label30.ForeColor = Color.Orange;
                frm2.bolumlstbx.Items.Add("Kilonuz " + kayit.kilo + " Dahiliye Bölümünden Randevu Alabilirsiniz");
            }

            else if (index >= 18.5 && index <= 24.9)
            {
                frm2.label30.Text = index + " BMI - Normal";
                frm2.label30.ForeColor = Color.Green;
            }

            else if (index >= 25 && index <= 29.9)
            {
                frm2.label30.Text = index + " BMI - Fazla Kilolu";
                frm2.label30.ForeColor = Color.Orange;
                frm2.bolumlstbx.Items.Add("Kilonuz " + kayit.kilo + " Diyetisyen Bölümünden Randevu Alabilirsiniz");
            }

            else if (index >= 30 && index <= 34.9)
            {
                frm2.label30.Text = index + " BMI - I. Derece Obezite";
                frm2.label30.ForeColor = Color.OrangeRed;
                frm2.bolumlstbx.Items.Add("Kilonuz " + kayit.kilo + " Diyetisyen Bölümünden Randevu Alabilirsiniz");
            }

            else if (index >= 35)
            {
                frm2.label30.Text = index + " BMI - II. Derece Obezite";
                frm2.label30.ForeColor = Color.Red;
                frm2.bolumlstbx.Items.Add("Kilonuz " + kayit.kilo + " Diyetisyen Bölümünden Randevu Alabilirsiniz");
            }

            //////////////////////////////////////////////////////////


            if (kayit.cmb == "Erkek")
            {
                frm2.vkelbl.Text = "20-25";
            }
            else
            {
                frm2.vkelbl.Text = "19-24";
            }

            //////////////////////////////////////////////////////////
            ///

            frm2.isimlbl.Text = kayit.isim;
            frm2.soyisimlbl.Text = kayit.soyisim;
            frm2.tclbl.Text = ""+kayit.tcno;


            this.Hide();
            frm2.Show();

        }
    }
}
