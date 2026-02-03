namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("1- For Döngüsü ");
            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine("i değişkenin değeri {0}", i);

            }
            Console.WriteLine();

            Console.WriteLine("2 - while dongusu");

            int j = 0;
            while (0 < 5)
            {
                Console.WriteLine("j değerinin değeri {0}");
                j++;
            }

            Console.WriteLine();

            Console.WriteLine("3 do while döngüsü");

            int toplam = 5;

            do
            {
                Console.WriteLine("toplamın değeri " + toplam );
            }

            while (toplam < 5 ); // sonra şarta bakar 

            Console.WriteLine();

            Console.WriteLine("4- Forech Döngüsü");

            string[] kategoriler = { "Elektronik", "Bilgisayar ", "Telefon", "Beyaz eşya" };

            foreach (var item in kategoriler)

            {

                Console.WriteLine(item);

            }

            Console.WriteLine();


            Console.WriteLine(" iç içe döngüsü kullanımı");

            string[] urun = { "ürün 1", "ürün 2 ", "ürün 3 ", "ürüm 4" }; // elimzdeki örnek ürün listesi 

            foreach (var kategori in kategoriler) // katagöriler isimli dizide dönüyoruz
            {
                Console.WriteLine(kategori);
                foreach (string item in urun)
                {
                    Console.WriteLine(item);

                }

            }

            Console.WriteLine();

            Console.WriteLine();


            for (int i = 0; i < 3; i++)

            {

                Console.WriteLine("1 döngüdeki  i nin değeri: " + i);

                for (int k = 0; k < 3; k++)

                {
                    Console.WriteLine("2. döngüdeki k nin değeri: " + k);
                }



            }





        }
    }
}
