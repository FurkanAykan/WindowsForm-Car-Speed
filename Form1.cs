using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Hiz_Kontrol_Events
{
    public partial class Form1 : Form
    {
        Araba arac = new Araba();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arac.Id = 1;
            arac.Marka = "BMW";
            arac.Model = "5.20d";
            arac.Hiz = 10;
            arac.MaxHiz = 180;
            
            lblHiz.Text = arac.Hiz.ToString();
            arac.HizDegisti += Arac_HizDegisti;  // += yapıp tab tab yapıyoruz metodu yazıyor
          
        }

        

        private void Arac_HizDegisti(Araba araba, HizEventArgs e)
        {
            if (e.YeniHiz>araba.MaxHiz)
            {
                e.YeniHiz = 180;
                e.EskiHiz = 170;
                araba.Hiz = e.YeniHiz;

            }

            if (e.YeniHiz>=160)
            {
                lblHiz.BackColor = Color.Red;
            }
            else
            {
                lblHiz.BackColor = Color.Lime;
            }
            lblHiz.Text = e.YeniHiz.ToString();
        }

        private void HizArttir_Click(object sender, EventArgs e)
        {
            arac.Hiz+= 10; // 10 ar 10 ar artsın.

        }

        private void HizDusur_Click(object sender, EventArgs e)
        {
            arac.Hiz-= 10; // 10 ar 10 ar düşür.
        }

        private void HizArttir_MouseEnter(object sender, EventArgs e)
        {
            HizArttir.BackColor= Color.Red;
            HizArttir.ForeColor= Color.White;
        }

        private void HizArttir_MouseLeave(object sender, EventArgs e)
        {
            HizArttir.BackColor = Color.White;
            HizArttir.ForeColor = Color.Black;
        }
    }
}
