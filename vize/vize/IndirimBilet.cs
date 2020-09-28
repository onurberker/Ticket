using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize
{
    class IndirimBilet :Bilet
    {
        private string indirimKodu;
        private double indirimMiktari;

        public IndirimBilet(Koltuk[] koltuklar, string ad, string soyad, string tcNo, Gosterim gosterim, double fiyat, string indirimKodu, double indirimMiktari):base(koltuklar, ad,soyad, tcNo, gosterim,fiyat)
        {
            this.indirimKodu = indirimKodu;
            this.indirimMiktari = indirimMiktari;
        }
    }
}
