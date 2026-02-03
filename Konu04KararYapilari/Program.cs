using System.ComponentModel.Design;
using System.Xml;

namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karar Yapıları");
            /*
            Console.WriteLine("Bir Sayi Giriniz ");
            var sayi = Convert.ToDecimal(Console.ReadLine());
            if (sayi > 0) 
                {
                    Console.WriteLine("Sayi Pozitif");
                }


             else if (sayi < 0)

                {
                    Console.WriteLine("Sayı Negatif ise");
                
                }
              else
                {
                    Console.WriteLine("Sayı sıfır ise");
                }
            
            Console.WriteLine("Kullanıcı adınız");

            var kullanıcıadi = Console.ReadLine();
            Console.WriteLine("Şifreniz");
            var sifre = Console.ReadLine();

            if (kullanıcıadi == "admin" && sifre == "a123" )
            {
                Console.WriteLine("Giriş Başırılı");
                Console.WriteLine("Hoşgeliniz");
            }

            else
            {
                Console.WriteLine("Giriş Başarısız");
            }

            */

            int saat = DateTime.Now.Hour;

            if (saat < 18)
            {
                Console.WriteLine("İyi günler, Saat : " + saat);

            }
            else
            {
                Console.WriteLine("İyi Akşamlar, Saat : " + saat);
            }

            Console.WriteLine("Switch case yapısı ile akış kontrolü");

            int ay = DateTime.Now.Month;
            Console.WriteLine("Bulunduğumuz ay: " + ay);
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Kış");
                    break;
                default:
                    Console.WriteLine("Bir Sorun oluştu");
                    break;
            }

            }
                
        }
    }

