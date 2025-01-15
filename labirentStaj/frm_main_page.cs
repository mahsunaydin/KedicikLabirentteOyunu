using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirentStaj
{
    public partial class frm_main_page : Form
    {
        public frm_main_page()
        {
            InitializeComponent();

            radioButton1.Select();
            radioButton6.Select();

        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureCatMain.Image = labirentStaj.Properties.Resources.cat1_png;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureCatMain.Image = labirentStaj.Properties.Resources.cat_pink_rigth;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureCatMain.Image = labirentStaj.Properties.Resources.cat_green_right;
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureCatMain.Image = labirentStaj.Properties.Resources.cat_blue_rigth;
        }

        // F5 veya F3 tuşlarına göre oyunun başlatılması yada kapatılması olayları
        private void frm_main_page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Form1 form1 = new Form1();

                //seçilen renge göre form1'deki kedinin renklerinin güncellenmesi

                if (radioButton1.Checked)
                {
                    form1.kedi_rengi = labirentStaj.Properties.Resources.cat1_png;
                    form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_png;
                }

                if (radioButton2.Checked)
                {
                    form1.kedi_rengi = labirentStaj.Properties.Resources.cat_pink_rigth;
                    form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_pink_left;
                }
                else if (radioButton3.Checked)
                {
                    form1.kedi_rengi = labirentStaj.Properties.Resources.cat_green_right;
                    form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_green_left;
                }
                else if (radioButton4.Checked)
                {
                    form1.kedi_rengi = labirentStaj.Properties.Resources.cat_blue_rigth;
                    form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_blue_left;
                }

                //seçilen zorluk derecesine göre köpeklerin hızının ayarlanması

                if (radioButton5.Checked)
                {
                    form1.timer1_interval = 45;
                    form1.seviye_text = "Kolay";
                }
                else if (radioButton6.Checked)
                {
                    form1.timer1_interval = 30;
                    form1.seviye_text = "Normal";
                }
                else if (radioButton7.Checked)
                {
                    form1.timer1_interval = 15;
                    form1.seviye_text = "Zor";
                }

                this.Hide();
                form1.ShowDialog();
            }

            else if (e.KeyCode == Keys.F3)
            {
                Application.Exit();
            }
        }

        //exit butonuna basılıp uygulamanın kapatılması
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        //start butonuna basılıp, oyunun başlatılması
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();


            if (radioButton1.Checked)
            {
                form1.kedi_rengi = labirentStaj.Properties.Resources.cat1_png;
                form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_png;
            }

            if (radioButton2.Checked)
            {
                form1.kedi_rengi = labirentStaj.Properties.Resources.cat_pink_rigth;
                form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_pink_left;
            }
            else if (radioButton3.Checked)
            {
                form1.kedi_rengi = labirentStaj.Properties.Resources.cat_green_right;
                form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_green_left;
            }
            else if (radioButton4.Checked)
            {
                form1.kedi_rengi = labirentStaj.Properties.Resources.cat_blue_rigth;
                form1.kedi_rengi_sol = labirentStaj.Properties.Resources.cat_blue_left;
            }

            if (radioButton5.Checked)
            {
                form1.timer1_interval = 45;
                form1.seviye_text = "Kolay";
            }
                else if (radioButton6.Checked)
                 {
                       form1.timer1_interval = 30;
                       form1.seviye_text = "Normal";
                 }
                else if (radioButton7.Checked)
                 {
                       form1.timer1_interval = 15;
                       form1.seviye_text = "Zor";
                 }

            this.Hide();
            form1.ShowDialog();
            

        }
    }
}
