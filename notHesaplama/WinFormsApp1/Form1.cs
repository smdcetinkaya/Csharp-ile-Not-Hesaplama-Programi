using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        double vkNote;
        double fkNote;
        int adet, adet2;
        double ort;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            vkNote = 0; fkNote = 0; adet = 0; adet2 = 0;
            while (true)
            {
                    if (checkBox1.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text));
                        adet += Convert.ToInt32(textBox1.Text);
                    }
                    if (checkBox2.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox3.Text));
                        adet += Convert.ToInt32(textBox3.Text);
                    }
                    if (checkBox3.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text));
                        adet += Convert.ToInt32(textBox5.Text);
                    }
                    if (checkBox4.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox7.Text));
                        adet += Convert.ToInt32(textBox7.Text);
                    }
                    if (checkBox5.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox10.Text) * Convert.ToInt32(textBox9.Text));
                        adet += Convert.ToInt32(textBox9.Text);
                    }
                    if (checkBox6.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox12.Text) * Convert.ToInt32(textBox11.Text));
                        adet += Convert.ToInt32(textBox11.Text);
                    }
                    if (checkBox7.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox14.Text) * Convert.ToInt32(textBox13.Text));
                        adet += Convert.ToInt32(textBox13.Text);
                    }
                    if (checkBox8.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox16.Text) * Convert.ToInt32(textBox15.Text));
                        adet += Convert.ToInt32(textBox15.Text);
                    }
                    if (checkBox9.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox18.Text) * Convert.ToInt32(textBox17.Text));
                        adet += Convert.ToInt32(textBox17.Text);
                    }
                    if (checkBox10.Checked == true)
                    {
                        vkNote += (Convert.ToInt32(textBox20.Text) * Convert.ToInt32(textBox19.Text));
                        adet += Convert.ToInt32(textBox19.Text);
                    }

                    if (checkBox11.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox22.Text) * Convert.ToInt32(textBox21.Text));
                        adet2 += Convert.ToInt32(textBox21.Text);
                    }
                    if (checkBox12.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox24.Text) * Convert.ToInt32(textBox23.Text));
                        adet2 += Convert.ToInt32(textBox23.Text);
                    }
                    if (checkBox13.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox26.Text) * Convert.ToInt32(textBox25.Text));
                        adet2 += Convert.ToInt32(textBox25.Text);
                    }
                    if (checkBox14.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox28.Text) * Convert.ToInt32(textBox27.Text));
                        adet2 += Convert.ToInt32(textBox27.Text);
                    }
                    if (checkBox15.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox30.Text) * Convert.ToInt32(textBox29.Text));
                        adet2 += Convert.ToInt32(textBox29.Text);
                    }
                    if (checkBox16.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox32.Text) * Convert.ToInt32(textBox31.Text));
                        adet2 += Convert.ToInt32(textBox31.Text);
                    }
                    if (checkBox17.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox34.Text) * Convert.ToInt32(textBox33.Text));
                        adet2 += Convert.ToInt32(textBox33.Text);
                    }
                    if (checkBox18.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox36.Text) * Convert.ToInt32(textBox35.Text));
                        adet2 += Convert.ToInt32(textBox35.Text);
                    }
                    if (checkBox19.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox38.Text) * Convert.ToInt32(textBox37.Text));
                        adet2 += Convert.ToInt32(textBox37.Text);
                    }
                    if (checkBox20.Checked == true)
                    {
                        fkNote += (Convert.ToInt32(textBox40.Text) * Convert.ToInt32(textBox39.Text));
                        adet2 += Convert.ToInt32(textBox39.Text);
                    }
                    break;
                
                /*else
                {
                    MessageBox.Show(" Kutulardan Birini Boş Bıraktınız \n              Ya Da \n    Yanlış Bir Değer Girdiniz");
                    break;
                }*/
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ort = 0;
            richTextBox1.Text = null;
            if (vkNote != 0 || fkNote != 0)
            {
                ort = (vkNote / adet) * 0.4 + (fkNote / adet2) * 0.6;
                richTextBox1.Text = "vknote : " + vkNote + "\n" + "Vize kredi : " + adet + "\n" + "fknote : " +fkNote+"\n"+"Final kredi : "+adet2+"\n"+"Vize Ortalaması : " + Convert.ToString(vkNote/adet) + "\n" +"Final Ortalaması : " + Convert.ToString(fkNote/adet2) + "\n" + "Genel Ortalama : " + Convert.ToString(ort);
            }
            else
            {
                MessageBox.Show("Hiç Note Girilmedi Lütfen Önce Not Girişi Yapınız...");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
