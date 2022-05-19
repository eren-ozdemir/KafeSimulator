using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSimulator
{
    public class CalisanManager
    {
        private byte calisanSayisi;

        public byte CalisanSayisi
        {
            get { return calisanSayisi; }
            set
            {
                if(value <4 || value > 5)
                    calisanSayisi = value;
            }
        }


    }
}
