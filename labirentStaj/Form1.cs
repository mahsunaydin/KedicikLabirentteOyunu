using labirentStaj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace labirentStaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureCat.Image = kedi_rengi;
            timer1.Interval = timer1_interval;
            label112.Text = seviye_text;
            
        }


        int hareketKontrol = 0;
        public string seviye_text;
        public Image kedi_rengi = labirentStaj.Properties.Resources.cat1_png;
        public Image kedi_rengi_sol = labirentStaj.Properties.Resources.cat_png;
        public int timer1_interval;
        int mak_skor = 0;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureCat.Location.X;
            int y = pictureCat.Location.Y;

            if (e.KeyCode == Keys.F5)
            {
                hareketKontrol = 1;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = true;
                label110.Visible = false;
            }
            if (e.KeyCode == Keys.F3)
            {
                hareketKontrol = 0;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = false;
            }

            if (hareketKontrol == 1 && (e.KeyCode == Keys.Right || e.KeyCode == Keys.D))
            {
                x = x + 5;
                this.pictureCat.Image = kedi_rengi;
            }

            if (hareketKontrol == 1 && (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && x >= 2)
            {
                x = x - 5;
                this.pictureCat.Image = kedi_rengi_sol;
            }

            if (hareketKontrol == 1 && (e.KeyCode == Keys.Up || e.KeyCode == Keys.W))
            {
                y = y - 5;
            }

            if (hareketKontrol == 1 && (e.KeyCode == Keys.Down || e.KeyCode == Keys.S))
            {
                y = y + 5;
            }


            if (pictureCat.Bounds.IntersectsWith(label106.Bounds) || pictureCat.Bounds.IntersectsWith(label107.Bounds))
            {
                x = 20;
                y = 330;
            }

            if (pictureCat.Bounds.IntersectsWith(pictureFish.Bounds))
            {
                pictureFish.Visible = false; //balık görünürlüğü false yapıldı
                timer3.Stop(); //saniye durduruldu
                

                if (mak_skor == 0)
                {
                    label116.Text = saniye.ToString();
                    mak_skor = saniye;
                }
                else if (saniye < mak_skor)
                {
                    label116.Text = saniye.ToString();
                    mak_skor = saniye;
                }

                saniye = 0; //saniye yeniden sıfırlandı

                if (MessageBox.Show("Tebrikler. Kedinin Karnı Doydu :) \n "+label109.Text+" Saniyede Bitirdin.. Tekrar Oynamak İster Misin?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    x = 20;
                    y = 330;
                    pictureFish.Visible = true;
                    saniye = 0;
                    label109.Text = saniye.ToString();
                    timer3.Start();

                }
                else
                {
                    Application.Exit();
                }
            }

            pictureCat.Location = new Point(x, y);
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            hareketKontrol = 1;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = true;
            label110.Visible = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            hareketKontrol = 0;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = false;
        }

        // aşağıda timer1 ile köpeklerin ileri geri hareketleri kontrol ediliyor
        // bool tip değişkenler ile hareket kontrolü sağlanıyor

        bool dog1yon = true;
        bool dog2yon = true;
        bool dog3yon = true;
        bool dog4yon = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pictureDog1 in yukarı-aşağı otomatik hareketi

            int ydog1 = pictureDog1.Location.Y;

            if (dog1yon)
            {
                ydog1 -= 1;
                if (ydog1 <= 107)
                    dog1yon = false;

            }
            else
            {
                ydog1 += 1;
                if (ydog1 >= 151)
                    dog1yon = true;
            }

            pictureDog1.Location = new Point(pictureDog1.Location.X, ydog1);

            // pictureDog2 nin sağa-sola otomatik hareketi

            int xdog2 = pictureDog2.Location.X;

            if (dog2yon)
            {
                xdog2 -= 1;
                if (xdog2 <= 286)
                    dog2yon = false;

            }
            else
            {
                xdog2 += 1;
                if (xdog2 >= 392)
                    dog2yon = true;
            }

            pictureDog2.Location = new Point(xdog2, pictureDog2.Location.Y);

            //pictureDog3 ün sağa-sola otomatik hareketi

            int xdog3 = pictureDog3.Location.X;

            if (dog3yon)
            {
                xdog3 -= 1;
                if (xdog3 <= 448)
                    dog3yon = false;

            }
            else
            {
                xdog3 += 1;
                if (xdog3 >= 555)
                    dog3yon = true;
            }

            pictureDog3.Location = new Point(xdog3, pictureDog3.Location.Y);

            //pictureDog4 ün sağa-sola otomatik hareketi

            int xdog4 = pictureDog4.Location.X;

            if (dog4yon)
            {
                xdog4 -= 1;
                if (xdog4 <= 610)
                    dog4yon = false;

            }
            else
            {
                xdog4 += 1;
                if (xdog4 >= 830)
                    dog4yon = true;
            }

            pictureDog4.Location = new Point(xdog4, pictureDog4.Location.Y);

        }

        int saniye = 0 ;

        private void timer3_Tick(object sender, EventArgs e)
        {
            saniye += 1;
            label109.Text = saniye.ToString();
        }

        bool timer2_bool = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //köpeklere çarpıp çarmadığının kontrolü ve olayları
            //

            if (timer2_bool &&
                (
                pictureCat.Bounds.IntersectsWith(pictureDog1.Bounds)
                ||
                pictureCat.Bounds.IntersectsWith(pictureDog2.Bounds)
                ||
                pictureCat.Bounds.IntersectsWith(pictureDog3.Bounds)
                ||
                pictureCat.Bounds.IntersectsWith(pictureDog4.Bounds))
                )
            {
                timer2_bool = false;
                timer1.Stop();
                timer3.Stop();

                if (MessageBox.Show("Köpekçik Seni Yakaladı!!! Oyuna Devam Mı ? :)", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int x = pictureCat.Location.X;
                    int y = pictureCat.Location.Y;

                    x = 20;
                    y = 330;

                    saniye = 0;
                    label109.Text = saniye.ToString();

                    timer1.Start();
                    timer3.Start();
                    timer2_bool = true;

                    pictureCat.Location = new Point(x, y);
                }
                else
                {
                    Application.Exit();
                }
            }

            //kedinin duvarlara çarpıp çarpmadığının kontrolü ve olayları
            //

            foreach (Control tool in this.panel1.Controls)
            {
                if (tool is Label && tool.Tag == "duvar")
                {
                    if (pictureCat.Bounds.IntersectsWith(tool.Bounds))
                    {
                        timer2_bool = false;
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        label109.Text = saniye.ToString();
                        if (MessageBox.Show("Duvara Çarptın. Tekrar Oynamak İster misin ???", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int x = pictureCat.Location.X;
                            int y = pictureCat.Location.Y;
                            x = 20;
                            y = 330;
                            pictureCat.Location = new Point(x, y);

                            saniye = 0;
                            label109.Text = saniye.ToString();
                            timer1.Start();
                            timer2.Start();
                            timer3.Start();
                            timer2_bool = true;
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
                
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
