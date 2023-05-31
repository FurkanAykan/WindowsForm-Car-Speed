using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Hiz_Kontrol_Events
{
    public delegate void HizHandler(Araba arac, HizEventArgs e);
    public class Araba
    {
        public event HizHandler HizDegisti;
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaxHiz { get; set; }
        //public DateTime UretimYili { get; set; }
        //public string Renk { get; set; }

        int hiz;
        public int Hiz
        {
            get
            {
                return hiz;
            }

            set
            {
                HizEventArgs ah = new HizEventArgs();
                ah.EskiHiz = hiz;
                hiz = value;
                
                if (value<=0)
                {
                    hiz = 0;
                    ah.YeniHiz = 0;
                }
                else
                {
                    hiz= value;
                    ah.YeniHiz = value;
                }
              
                if (HizDegisti!=null)
                {
                    HizDegisti(this, ah);
                }
                //HizDegisti?.Invoke(this,ah) // null değilse çalıştır demek

            }
        }
        //public string Ozellikler { get; set; }

        //public string UretimYeri { get; set; }


    }

    public class HizEventArgs
    {
        public int EskiHiz { get; set; }
        public int YeniHiz { get; set; }
    }
}
