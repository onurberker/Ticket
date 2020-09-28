using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize
{
    class Koltuk
    {
        private int sıraNo;
        private int koltukNo;
        private bool doluMu;

        public Koltuk(int sıraNo, int koltukNo)
        {
            this.sıraNo = sıraNo;
            this.koltukNo = koltukNo;
            doluMu = false;
        }

        public int SıraNo
        {
            get
            {
                return sıraNo;
            }
            set
            {
                sıraNo = value;
            }
        }

        public int KoltukNo
        {
            get
            {
                return koltukNo;
            }
            set
            {
                koltukNo = value;
            }
        }

        public bool DoluMu
        {
            get
            {
                return doluMu;
            }
            set
            {
                doluMu = value;
            }
        }

        public bool yerAyirma()
        {
            if(doluMu)
            {
                return false;
            }
            else
            {
                doluMu = true;
                return true;
            }
                
        }
        
    }
}
