using System.Xml.Linq;

namespace Konu12KalitimInheritance
{
    class Arac
    {
        public int Id { get; set; }

        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }

    class Otomobil : Arac // iki nokta üst üste araç dediğinizde araç sınıfındaki içerikler otomobil sınıfıda kullanulur 
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }

    class Tren : Arac
    {
        public int VagonSayisi { get; set; }
    }

    class Otobus : Arac
    {
        public int KoltukSayisi { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12KalitimInheritance");
            Arac arac = new Arac();
            arac.AracTuru = "Otomobil";
            arac.KornaCal();

            Otomobil otomobil = new Otomobil();
            otomobil.Id = 1;
            otomobil.AracTuru = "Otomobil"; // bu değişken arac sınıfından geliyor 
            arac.KornaCal(); // bu metot arac sınıfından geliyor 
            otomobil.Marka = "Tog";
            otomobil.Model = "T10x";
            Console.WriteLine("otomobil.AracTuru : " + otomobil.AracTuru);

            Console.WriteLine();

            Kategori kategori = new()
            {
                Id = 1,
                Name = "Elektronik",
                UstMenuGoster = true

             };        
            if (kategori.UstMenuGoster = true)
            {
                Console.WriteLine("Kategori adı :" + kategori.Name);
            }

            Console.WriteLine();

            Urun urun = new()
            {
                Id = 1,
                Name = "Klavye",
                Fiyat = 999,
                Kdv = 20 
            };


            Console.WriteLine("Ürün Bilgileri:");
            Console.WriteLine("Ürün Adı: " + urun.Name);
            Console.WriteLine("Ürün Fiyatı: " + urun.Fiyat);
            Console.WriteLine("Kdv: %" + urun.Kdv);
            decimal kdvOrani = 0.20m;
            decimal kdvTutari = urun.Fiyat * kdvOrani;
            decimal toplamFiyat = urun.Fiyat + kdvTutari;
            Console.WriteLine("Kdv Tutarı: " + kdvTutari + " TL");
            Console.WriteLine("Toplam Tutar: " + toplamFiyat + " TL");


            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();
                
            foreach (var item in birCizici)
            {
                item.Ciz();
            }



        }



    }
    // Poliforizm - Çok biçimlilk

    public class Cizici
    {
        public virtual void Ciz() // virtual keywordu ile  bu metodu override - ezilebilir hale getiriyoruz 
        {
            Console.WriteLine("Cizici");
        }
     

    }
    public class DogruCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Düz Cizgi");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire Cizgi");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Kare Cizgi");
        }
    }


}
