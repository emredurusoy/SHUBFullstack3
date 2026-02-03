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
            Console.WriteLine("Liste kullanımı");
            List<string> sehirler = new(); // string veri tipi alabilen bir liste
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Adana");
            sehirler.Add("Mersin");
            sehirler.Add("Bursa");

            Console.WriteLine("Şehirler");
            foreach (var item in sehirler) // sehirler ismli listede dön 
            {
                Console.WriteLine(item); // listedeki her nesneyi ekrana yaz
            } 

            Console.WriteLine();


        }
    }
}
