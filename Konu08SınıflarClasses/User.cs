using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SınıflarClasses
{
    internal class User
    {
        // claslarda property kullanımı
        // property değişken ve metotların karışımı gibi de kullanılabilir  


        public int MyProperty { get; set; } // prob + tab

        public int Id { get; set; } // prob + tab

        public string Name { get; set; } // user classından oluşturduğumuz nesne üzerinden buradaki property lere değer ataması yapsak set bloğu değer okuması  yaparsak get bloğu çaşışıtr 
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }

        public DateTime CreateDate{ get; set; }
        public bool KullaniciGiris(string kullaniciadi, string sifre)
        {
            if (kullaniciadi == "admin" && sifre == "adm123")
            {
                return true;
            }

            return false;
        }




    }
}
