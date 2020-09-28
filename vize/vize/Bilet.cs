using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize
{
    class Bilet
    {
        private Koltuk[] koltuklar;

        //bilet sahibi
        private string ad, soyad, tcNo;
        private Gosterim gosterim;
        private double fiyat;

        public Bilet(Koltuk[] koltuklar, string ad, string soyad, string tcNo, Gosterim gosterim, double fiyat)
        {
            this.koltuklar = koltuklar;
            this.ad = ad;
            this.soyad = soyad;
            this.tcNo = tcNo;
            this.gosterim = gosterim;
            this.fiyat = fiyat;
        }

        public virtual void bilgiYazdirGonder()
        {
            ToString();
        }

        public override string ToString()
        {
            string str = "";
            str += "bilet ozet bilgi fisi \n + bilet sahibi bilgileri: \n " +ad +soyad + "\n "+tcNo +"bilet bilgileri \n"+ gosterim.ToString() + "fiyat \n" +fiyat;

            return str;
        }
    }
}
