namespace Konu17HataYönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu17HataYönetimi!");
            Console.WriteLine();
            Console.WriteLine("Kdv Hesaplamak İçin Fiyat Girin : ");
            var fiyat = Console.ReadLine();
            
            try // try tab tab yaoarak try catch bloğu oluşturuyoruz 
            {
                // try bloğu deneyeceğimiz alandır 
                KdvHesapla(double.Parse(fiyat));
            }
            catch (Exception hata ) // eğer try bloğunda hata oluşursa o zaman catch bloğu çalıştırır
            {   // exception a bir isim vererek hatayı yakalayabilirirz 
                Console.WriteLine("Hata oluştu! lütfen Sadece sayısal değer girin!!");
                // throw; //  bu da hatayı fırlatma sağlar 
                
                Console.WriteLine(hata.Message);

                // ayrıca uygulama hata oluşursa oluşan hatalar veritabanaı veya fiziksel bir dosyaya kaydedilir bunada loglama denir
               
            }

            finally 
            {
                Console.WriteLine("try catch bloğundan her seferinde çalışmasını istedğimiz bir işlem varsa bu blokta çalıştrabilirz kullanımı zorunlı değildir ");
                Console.WriteLine("Kdv Hesaplamak İçin Fiyat Giriniz: ");
                var fiyat2 = Console.ReadLine();
                KdvHesapla(double.Parse(fiyat2));


            }

        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat :" + fiyat);
            Console.WriteLine("Kdv : " + (fiyat * 0.20));
            Console.WriteLine("Kdv Dahil Toplam Tutar : " + (fiyat + (fiyat * 0.20)));
        }
    }
}
