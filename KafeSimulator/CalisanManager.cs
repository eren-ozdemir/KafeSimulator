using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSimulator
{
    public static class CalisanManager
    {
        private static byte calisanSayisi;

        public static byte CalisanSayisi
        {
            get { return calisanSayisi; }
            set
            {
                if (value < 4 || value > 5)
                    throw new Exception("Çalışan sayısı 4 ya da 5 olmalı");
                else 
                    calisanSayisi = value;
            }
        }

        public static List<Calisan> CalisanListesi { get; set; } = new List<Calisan>();
    }
}
