namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1- Aritmatik Operatörler");

            double sayi1 = 3;
            double sayi2 = 4;
            double sayi3 = 5;

            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2 : {sayi2} sayi3 : {sayi3}"); // strng tırnağının $  önüne işareti interplosyaınu yapılıyor

            Console.WriteLine("1234" + sayi3); // string ile int  arasına + koyarak onların birleşmesine yardımıcı oluyoruz 
            Console.WriteLine();

            Console.WriteLine("Hesaplama işlemleri: ");

            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 + sayi2) );
            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 - sayi2) );
            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 * sayi2) );
            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 / sayi2) );
            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 % sayi2) );

            Console.WriteLine();

            Console.WriteLine("ARtım ve Azaltım operetörleri");

            sayi2++; // değişkenin değerini artırır 
            Console.WriteLine("sayi2 :" + sayi2);
            sayi2--; //değeri azalt 
            Console.WriteLine("sayi2 :" + sayi2);

            Console.WriteLine();

            Console.WriteLine("Atama Operatörleri ");
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2 : {sayi2} sayi3 : {sayi3}");
            Console.WriteLine("sayi1 += sayi2 : " + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2 : " + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2 : " + (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2 : " + (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2 : " + (sayi1 %= sayi2));

            Console.WriteLine("İlişkisel operetörler"); // Birden fazla değeri karşılaştırıp aralarındaki durumu öğrenmek için kullanılır 

            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2 : {sayi2} sayi3 : {sayi3}");
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 == sayi2));
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 != sayi2));
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 < sayi2));
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 > sayi2));
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 >= sayi2));
            Console.WriteLine("sayi1 == sayi2 : " + (sayi1 <= sayi2));

            Console.WriteLine();

            Console.WriteLine("Ternary operetörü"); // eğer karşılaştırma iiçin 2 değer kullancaksa karşılatırmmanın kısayolu olarak kullanırız 

            Console.WriteLine("Ternary: ");
            Console.WriteLine((sayi1 == sayi2) ? " sayılar eşit " : "sayılar eşit değil ") ;

            Console.WriteLine();

            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & Opareötrü");

            Console.WriteLine("& Operetörü her iki şartın da sağlamasını iseter");

            string email = "admin@site.co", sifre = "abc123";
            Console.WriteLine("Mail Giriniz");
            var girilenMail = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz");
            var girilineSifre = Console.ReadLine();
           // Console.WriteLine(girilenMail == email && girilineSifre == sifre ? "Giriş Başarılı" : "Giriş Başarısız");

            Console.WriteLine();

            Console.WriteLine("Veya | Opareötrü");
            Console.WriteLine("|| operetörü her iki şartan birinin sağlamasını siter ");

            Console.WriteLine();

            Console.WriteLine(girilenMail == email | girilineSifre == sifre ? "Giriş Başarılı" : "Giriş Başarısız");

            








        }
    }
}
