using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_uygulamasi2
{
    internal sealed class Personel:OrtakTip
    {
        public DateTime iseBaslamaTarihi;
        public DateTime isiBirakmaTarihi;
        public string akademikDurum { get; set; }
        public Personel()
        {
            iseBaslamaTarihi = DateTime.Now;
            akademikDurum = "Yukseklisans";
        }

    }
}
