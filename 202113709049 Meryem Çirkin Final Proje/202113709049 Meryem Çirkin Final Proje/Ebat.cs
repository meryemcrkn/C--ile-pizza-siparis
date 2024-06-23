using System;
using System.Collections.Generic;
using System.Text;

namespace _202113709049_Meryem_Çirkin_Final_Proje
{
    class Ebat
    {
        public string Adi { get; set; }
        public double Carpan { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", Adi, Carpan);
        }
    }
   
}
