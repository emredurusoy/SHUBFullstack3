using System.Net.Mail;
using System.Runtime.InteropServices;

namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metotlar!");
            Console.WriteLine();
            Toplamayap();
        }

        static void Toplamayap() // Metot tanımlama 
        {
            // void olan metotlar geriye değer döndürmeyen metotlardır
            Console.WriteLine(10 + 8);
            Console.WriteLine();
            Toplamayap(10, 8);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Geriğe değer döndğren metot: ");
            int sonuc = Toplamayap(6, 6, 6);
            Console.WriteLine("Sayıların Toplamı:" + sonuc);
            Console.WriteLine();
            Console.WriteLine("Email girinz:");
            var email = Console.ReadLine();
            var mailGonderildimi = MailGonder(email);
            if (mailGonderildimi == true)
            {
                Console.WriteLine("Mail Başarıyla Gönderildi");

            }
            else
                Console.WriteLine("Mail Gönderilmedi");
        }
        static void Toplamayap(int sayi1, int sayi2) // Parametreli tanımlama 
        {

            Console.WriteLine(sayi1 + sayi2);

        }
        static int Toplamayap(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static bool MailGonder(string mailAdresi)
        {
        if (!string.IsNullOrEmpty(mailAdresi))
        { 

        return true;

         }
            return false; 

        }
    }
}
