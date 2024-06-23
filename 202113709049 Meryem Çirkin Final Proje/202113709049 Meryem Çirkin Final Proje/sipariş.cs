using System;
using System.Collections.Generic;
using System.Text;

namespace _202113709049_Meryem_Çirkin_Final_Proje
{
    class sipariş
    {
        public Pizza Pizza { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public override string ToString()
        {
            string spr = "";
            spr += Pizza.Ebati.Adi + ",";
            spr += Pizza.Adi + ",";
            spr += Pizza.KenarTipi.Adi + ",";
            foreach(string mlz in Pizza.Malzemeler)
            {
                spr += string.Format("{0},",mlz);
            }
            spr = spr.Remove(spr.Length - 1, 1);
            spr += string.Format(" {0} x {1} ={2}", Adet, Pizza.Tutar, Adet * Pizza.Tutar);
            return spr;
        }
    }
}
