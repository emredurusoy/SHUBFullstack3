using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SınıflarClasses
{
    internal class Urun
    {
        internal int Id;
        internal string Adi;
        internal decimal Fiyati;
        // class içinde property kullanılmaz 

        public string UrunAciklamasi {  get; set; }
        public string Markasi {  get; set; }
        public bool Durum {  get; set; }
        public int  KategoriId {  get; set; }
        public Kategori Kategori {  get; set; } 


    }
}
