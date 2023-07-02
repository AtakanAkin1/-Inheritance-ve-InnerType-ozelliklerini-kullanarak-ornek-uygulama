using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_uygulamasi2
{
    internal  sealed class Yonetici:OrtakTip
    {
        public DateTime iseBaslamaTarihi;
        public DateTime isiBirakmaTarihi;
        public string yoneticiIsmi { get; set; }
        public string unvan { get; set; }
        public string akademikDurum { get; set; }
        public int isyeriRutbesi { get; set; }// Mudur: 1 Ceo:2 Teknik sorumlu: 3
        public Yonetici()
        {
            iseBaslamaTarihi = DateTime.Now;
            unvan = "Software developer";
            yoneticiIsmi = "Atakan Akin";
            akademikDurum = "OnLisans";
            isyeriRutbesi = 3;
        }
    }
}
