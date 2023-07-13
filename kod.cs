using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int birinciat, ikinciat, ücüncüat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int birgenislik, ikigenisliki, ücgenislik;
            birgenislik = pictureBox47.Width;
            ikigenisliki= pictureBox48.Width;
            ücgenislik= pictureBox49.Width;

            int label1g,label2g,label3g;
            pictureBox47.Left = pictureBox47.Left + random.Next(5, 15);
            pictureBox48.Left = pictureBox48.Left + random.Next(5, 15);
            pictureBox49.Left = pictureBox49.Left + random.Next(5, 15);

            birinciat = pictureBox47.Left;
            ikinciat = pictureBox48.Left;
            ücüncüat = pictureBox48.Left;

            label1g = label1.Left;
            label2g = label2.Left;
            label3g = label3.Left;

           

            for(int j=1; j<=100; j++)
            {
                if (birinciat > ikinciat + 5 )
                {
                    button2.Text = "Birinci At Önde !!";

                }
                if (birinciat > ücüncüat + 5)
                {
                    button2.Text = "Birinci At Yarışı Bitiriyor!!";

                }
                if (ikinciat > birinciat + 5)
                {
                    button2.Text = "İkinci At Birinci atı toz etti!!";

                }
                if(ikinciat> ücüncüat+5)
                {
                    button2.Text = "İkinci At Üçüncüyü Solladı!";
                }
                if (ücüncüat > birinciat + 5)
                {
                    button2.Text = "Üçüncü at birinci atı geride bırakıyor....";
                }
                if (ücüncüat > ikinciat + 5)
                {
                    button2.Text = "Üçüncü at ikiye ciddi fark attı!....";
                }

                for (int i = 1; i <= 100; i++)
                {
                    if (birgenislik + pictureBox47.Left >= label1g)
                    {
                        timer1.Enabled = false;
                        button2.Text = "Birinci At Kazandı!!!";

                    }
                    if (ikigenisliki + pictureBox48.Left >= label2g)
                    {
                        timer1.Enabled = false;
                        button2.Text = "İkinci At Kazandı!!!";

                    }
                    if (ücgenislik + pictureBox49.Left >= label3g)
                    {
                        timer1.Enabled = false;
                        button2.Text = "İkinci At Kazandı!!!";

                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            birinciat = pictureBox47.Left;
            ikinciat = pictureBox48.Left;
            ücüncüat= pictureBox49.Left;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Text = "İşte Büyük Yarış Başladı!!!";
            


        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
