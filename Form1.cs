using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int chair01 = 0;
        int chair02 = 0;
        int chair03 = 0;
        int chair04 = 0;
        int chair05 = 0;
        int chair06 = 0;
        int chair07 = 0;
        int chair08 = 0;
        int chair09 = 0;
        int chair10 = 0;
        int chair11 = 0;
        int chair12 = 0;
        int chair13 = 0;
        int chair14 = 0;
        int chair15 = 0;
        int chair16 = 0;
        int chair17 = 0;
        int chair18 = 0;
        int chair19 = 0;
        int chair20 = 0;

        private void btn_chair01_Click(object sender, EventArgs e)
        {
           
            if (chair01 == 0)
            {
                 btn_chair01.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\ahmet\source\repos\SinemaOtomasyonu\Sinema-Otomasyonu\images\redchair.png");
                 chair01 = 1;
            } 

            else if (chair01==1)
            { 
                btn_chair01.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\ahmet\source\repos\SinemaOtomasyonu\Sinema-Otomasyonu\images\greenchair.png");
                chair01 = 0;
            }

        }
    }
}
