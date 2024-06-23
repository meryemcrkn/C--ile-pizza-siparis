using System;
using System.Collections.Generic;
using System.Text;

namespace _202113709049_Meryem_Çirkin_Final_Proje
{
    class Pizza
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Ebat Ebati { get; set; }
        public KenarTip KenarTipi { get; set; }
        public List<string> Malzemeler { get; set; }
        public decimal Tutar
        {
            get
            {
                decimal tutar = 0;
                tutar = Fiyat * (decimal)Ebati.Carpan;
                tutar += KenarTipi.EkFiyat;
                return tutar;
            }
        }
        public override string ToString()
        {
            return Adi;
        }
       


       
    }
}
