namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        public string BolumAdi; // dışarıdan erişime kapalı değişmez
        public string GetBolumAdi()
        {
            return BolumAdi;
        }
        public void SetBolumAdi(string istenenEgitim)
        {
            if (istenenEgitim == "Yazılım Eğitimi")
            {
                Console.WriteLine("Kurumumuzda bu eğirim verilmemektedir");
            }
            else
            {
                BolumAdi = istenenEgitim; // Mutator (setter) seçilen eğitimw izin verildi 
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13KapsullemeEncapsulation!");
            Console.WriteLine("Metotile kapsülleme ");
            Bolum bolum = new Bolum(); // Bolum classından bolum adına bir nesne üret 
            Console.WriteLine("Hangi alanda eğitim almak istersiniz?"); 
            var bolumadi = Console.ReadLine(); // ekran girilecek değeri oku 
            bolum.SetBolumAdi(bolumadi); // Girilen değeri bolum nesnesindeki set moduna gönder 
            Console.WriteLine("Bölüm : " + bolum.GetBolumAdi()); // bolum nesnesindeki metotuna private değişkenin değerini oku

            Console.WriteLine();

            //property ile kapsülleme 

            Console.WriteLine("property ile kapsülleme ");
            Fakulte fakulteNesnesi = new Fakulte(); // burada nesneyi oluşturuyoruz     
            fakulteNesnesi.Bolum = bolumadi; // veri atama : set bloğu çalıştırı 
            Console.WriteLine("Fakülte Bölüm" + fakulteNesnesi.Bolum); // veri okuma : get bloğu çalıştırır 


        }
    }
    public class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }
            set
            {
                if (value == "Yazılım Eğitimi")
                {
                    bolum = value;
                }
                else
                {
                    Console.WriteLine("Kurumumuzda bu eğirim verilmemektedir");
                }

            }
    }   }
}
