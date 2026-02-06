using System.Collections; // KOLEKSİYONLARI KULLANABİLMEK İÇİN KÜTÜPHANE
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Konu16CollectionKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu16CollectionKoleksiyonlar");
            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            // Ornek5();
            ListKullanımı();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("iki");
            arrayList.Add(3.0);
            arrayList.Add(true);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList İlk Eleman:  " + arrayList[0]); // listede bulunan ini verdiğimiz elemana ulaşır 
        }

        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("İstanbul");
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Sivas");
            arrayList.Add("Çankırı");
            arrayList.Add("Zonguldak");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine();
            Console.WriteLine("ArrayList de sıralama yapabiliriz");
            arrayList.Sort(); // a - z ye göre sıralama 
            foreach (var item in arrayList)
            {  Console.WriteLine(item); }

            Console.WriteLine();

            arrayList.Reverse(); // tersten sıralama
            foreach(var item in arrayList)
            { Console.WriteLine(item); }

            Console.WriteLine();


        }

        static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add ("istanbul");
            strings.Add ("Ankara");
            strings.Add ("İzmir");
            strings.Add ("Bursa");
            strings.Add ("Adna");

            Console.WriteLine("StringColletion");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        static void Ornek4()
        {
            var dictionary = new StringDictionary();
            

            dictionary.Add("18", "Çankırı");
            dictionary.Add("06", "Ankara");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("35", "İzmir");
            dictionary.Add("01", "Adana");

            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dictionary.Keys");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dictionary.Valuse");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            
        }

        static void Ornek5()
        {
            Dictionary<string, string> dictionary = new(); // hangi veri tipinden olacağını bizim belirlediğimiz liste tanımı
            {
                Console.WriteLine();
                dictionary.Add("book", "kitap");
                dictionary.Add("18", "Çankırı");
                dictionary.Add("06", "Ankara");
                dictionary.Add("34", "İstanbul");
                Console.WriteLine(dictionary["book"]);


                Dictionary<int, string> dictionary2 = new();

                dictionary2.Add(1 , "kitap");
                dictionary2.Add(18, "Çankırı");
                dictionary2.Add(06, "Ankara");
                dictionary2.Add(34, "İstanbul");


                Console.WriteLine("dictionray2 Values :");

                foreach (var item in dictionary2)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();

                Console.WriteLine("dictionray2 Keys :");

                foreach (var item in dictionary2)
                {
                    Console.WriteLine(item.Key);
                }

            }
        }

        static void ListKullanımı()
        {
            Console.WriteLine("List Kullanimi");
            List<string> sehirler = new(); // string veri tipi alabilen bir liste
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Kocaeli");
            sehirler.Add("Sivas 58");
            sehirler.Add("Çankırı");
            // sehirler.Add(18); // !! List<string> dediğimiz için string dışında listeye ekleme yapamayız!
            Console.WriteLine("Şehirler:");
            foreach (var item in sehirler) // sehirler isimli listede dön
            {
                Console.WriteLine(item); // listedeki her nesneyi ekrana yaz
            }
            Console.WriteLine();

            List<User> users = new();
            users.Add(new User
            {
                Id = 1,
                Name = "Mesut",
                Email = "mesut",
                Password = "123"
            });
            users.Add(new User
            {
                Id = 2,
                Name = "Alp",
                Email = "alp",
                Password = "321"
            });
            Console.WriteLine("Kullanıcılar:");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            List<User> kullanicilar = new()
            {
                new User
                {
                    Id = 3,
                    Name = "Pusat",
                    Email = "pusat",
                    Password = "gmr12"
                },
                new User
                {
                    Id = 4,
                    Name = "Murat",
                    Email = "yilmaz",
                    Password = "mry25"
                }
            };
            Console.WriteLine("Kullanıcılar 2:");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            var yeniKullanici = new User
            {
                Id = 5,
                Name = "Aslan",
                Password = "789"
            };
            Console.WriteLine("Kullanıcılar listesinde yeniKullanici var mı? :");
            var varmi = kullanicilar.Contains(yeniKullanici); // Contains metoduyla bir listede arama yapabiliriz.
            Console.WriteLine("varmi ? " + varmi);
            kullanicilar.Add(yeniKullanici);
            Console.WriteLine("şimdi varmı? " + kullanicilar.Contains(yeniKullanici));
            Console.WriteLine();
            Console.WriteLine("Kullanıcılar 3:");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            kullanicilar.AddRange(users); // AddRange metodu listeye çoklu kayıt eklememizi sağlar.
            kullanicilar.Insert(0, yeniKullanici); // Insert metodu listeye verdiğimiz indexe ekleme yapmamızı sağlar
            Console.WriteLine();
            Console.WriteLine("Kullanıcılar 4:");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name + " " + item.Password);
            }
            Console.WriteLine();
            Console.WriteLine("Listedeki kayıt sayısı: " + kullanicilar.Count); // Count listedeki eleman sayısını getirir.


        }
    }
}
