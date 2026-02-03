using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SınıflarClasses
{
    internal class SinifMetotKullanimi
    {
        string kurucuMetot;
        public SinifMetotKullanimi() // ctor kısa kullanımı 

        {
            Console.WriteLine();
            kurucuMetot = "sıflarında constractor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturduğunda otamatik çalıştırır ve içindeki kodlar çaalışır ";

            Console.WriteLine(kurucuMetot);
            Console.WriteLine();

        }
        public bool LoginControl(string kullaniciadi, string sifre)
        {
            if (kullaniciadi == "admin" && sifre == "adm123")
            {
                return true;
            }

            return false;   
        }

        public int Toplamayap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static string StatikDegisgen = "Sınıfta statik degisgen kullanımı";
        public string DinamikDegisgen = "Dinamik Statik";

    }
}
