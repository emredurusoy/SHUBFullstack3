using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10StringSinifi");
            string degisken; 
            char karakter = 'a';
            string metinlericin = "yanyana karakterlerden oluşan metin";
            Ornek1();
            StringMetotlari();
            SplitMetodu();
        }

        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birsayi = "12345";
            System.String birTarih = "21.01.2026";
            string kod = "//45634fdg\n";//buradaki \n kodu enter görvi görür ve kendinden sonra geleck olan metni bir alt satıra kaydırır  
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine("For Dögüsü");
            for (int i = 0; i < s.Length; i++) // s değişkenin uzunluğu kadar dön
            {
                Console.WriteLine(s[i]); // s değişkenin i. indexindeki değri yazdır. 
            }
            Console.WriteLine("For Dögüsü");

            Console.WriteLine();

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }


        }

        static void StringMetotlari()
        {
            string metin = "Stringin Birçok metodu vardır";
            Console.WriteLine(metin);
            Console.WriteLine("metin in karakter sayısı: metin.Leght" + metin.Length);
            Console.WriteLine();

            var klon = metin.Clone(); // Clone metodu değişkenin klonlayıp klon değişkeninine atar 
            Console.WriteLine("metin klonu:" + klon);

            Console.WriteLine();

            metin = "My name is Ali";
            Console.WriteLine(metin + "EndsWith i: " + metin.EndsWith("i"));
            Console.WriteLine(metin + "EndsWith r: " + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + "StartsWith S: " + metin.StartsWith("S"));
            Console.WriteLine(metin + "StartsWith m: " + metin.StartsWith("m"));
            Console.WriteLine(metin + "StartsWith M: " + metin.StartsWith("M"));
            Console.WriteLine(metin + "StartsWith M: " + metin.StartsWith("M"));

            Console.WriteLine();

            Console.WriteLine(metin + " İndexOf name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + " İndexOf Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " LastİndexOf i: " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + " Insert Merhaba : " + metin.Insert(0, "Merhaba :"));
            Console.WriteLine(metin);

            Console.WriteLine();

            Console.WriteLine("Substring 2 : " + metin.Substring(2));
            Console.WriteLine("Substring 2, 5  : " + metin.Substring(2, 5)); // 2.indexten başlayarak 5 karakter 

            Console.WriteLine();

            Console.WriteLine(" metin.ToLower: " + metin.ToLower()); // metni küçük harfe çevirir
            Console.WriteLine(" metin.ToUpper " + metin.ToUpper()); // metni büyük harfe çevirir
            Console.WriteLine(" metin.ToLower().Replace :" + metin.ToLower().Replace("", "-")); // metni küçük harfe çevir ve içindeki boşlukları - ile değiştir 
            Console.WriteLine(" metin.Remove 2 : " + metin.Remove(2));
            Console.WriteLine(" metin.Remove 2, 5 : " + metin.Remove(2, 5));

        }

        static void SplitMetodu()
        {
            string sehirler = "istanbul,Ankara,İzmir,Sivas,Çankırı";
            Console.WriteLine(sehirler);
            string[] sehirlerArray = sehirler.Split(','); // split verilen karaktere göre metini parçalar 
            Console.WriteLine("4. şehir : " + sehirlerArray[3] );
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir: " + item);
            }


        }

    }
}
