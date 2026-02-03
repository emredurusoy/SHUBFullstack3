namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 02 Tip Dönüşümleri!");
            // Implicit casting - otomatik dönüşüm
            // Explicit casting - manuel dönüşüm
            Console.WriteLine("Implicit casting - otomatik dönüşüm");
            Console.WriteLine("Implicit casting de daha küççük boyutlu verileri daha büğüğe oto çecirir ");

            int sayi = 19;
            double kesrlisayi = sayi;
            Console.WriteLine("sayi değeri: ");
            Console.WriteLine(sayi);
            Console.WriteLine("kesirlisayi değeri: ");
            Console.WriteLine(kesrlisayi);

            Console.WriteLine();
            Console.WriteLine("Explicit casting - manuel dönüşüm");
            double kesirliSayi2 = 18;
            int tamsayi = (int)kesirliSayi2;
            Console.WriteLine("kesirliSayi2");
            Console.WriteLine(kesirliSayi2);
            Console.WriteLine("tam sayi: ");
            Console.WriteLine(tamsayi);
            
            Console.WriteLine("Diğer Tür Dönüştürme Yöntemleri");
            int Tamsayi = 10;
            double kesirliSayi3 = 14.2;
            bool islemsonuc = true;

            Console.WriteLine("Lütfen değer giriniz: ");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("girilen degerin verinin tipi");
            Console.WriteLine(girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger); // int parse metodu kendisine verilen string değerinin tırnakalrını kaldıaran int tipine çeirir
            Console.WriteLine(parsayi + tamsayi);
            Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi2);
            Console.WriteLine(decimal.Parse(girilenDeger) + Tamsayi);
            Console.WriteLine();

            Console.WriteLine("Convert sınıfı metotlarıyla sınıf dönüştürme");
            Console.WriteLine(Tamsayi.GetType());
            Console.WriteLine(Convert.ToString(Tamsayi).GetType()); // tamsayi stringe çevir tipini doğrulamak  için ekrana yazır 
            Console.WriteLine(Convert.ToDouble(Tamsayi).GetType()); 
            Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType());
            Console.WriteLine(Convert.ToString(islemsonuc).GetType());

            Console.WriteLine();


            object nesne = "123456";
            Console.WriteLine("nesne nin veri tipi:" + nesne.GetType());
            nesne = Convert.ToDecimal(nesne);
            Console.WriteLine("nesne nin veri tipi:" + nesne.GetType());
            Console.WriteLine("nesne nin değeri : " + nesne);




        }
    }
}
