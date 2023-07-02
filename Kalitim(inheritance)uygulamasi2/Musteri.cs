using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_uygulamasi2
{
    internal sealed class Musteri:OrtakTip
    {
        public int ucretBedeli { get; set; }
        public string verilenIs { get; set; }
        public DateTime isinVerilmeTarihi;
        public Yonetici Y1;
        public Musteri()
        {
            isinVerilmeTarihi = DateTime.Now;
            Y1 = new Yonetici();
        }
       
        
    }
}
