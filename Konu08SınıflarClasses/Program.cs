using Konu08SınıflarClasses;

namespace Konu08SiniflarClasses
{
    internal class Ev // sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
    /*
            Erişim belirteçleri 4 ana sınıfa ayrılır
         public     : Erişim kısıtı yoktur, her yerden erişilebilir.
         protected  : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
         internal   : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
         private    : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
     */
    public class deneme
    {
        public string UrunAdi = "public öğeye herkes ulaşabilir";
        protected class test
        {
            string UrunAdi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08SiniflarClasses");
            #region Örnek1
            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından ilkev adında somut bir nesne oluşturduk.
            ilkEv.sokakAdi = "Pınar sk.";
            ilkEv.kapiNo = 10;

            Console.WriteLine("ilkEv sokakAdi: " + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapiNo: " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new();

            yazlikEv.sokakAdi = "Deniz sk.";
            yazlikEv.kapiNo = 18;

            Console.WriteLine("yazlikEv sokakAdi: " + yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapiNo: " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                kapiNo = 25,
                sokakAdi = "Maho ağa sokak."
            };

            Console.WriteLine("koyEvi sokakAdi: " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapiNo: " + koyEvi.kapiNo);

            Console.WriteLine();
            #endregion

            #region Örnek 2
            Kullanici kullanici = new()
            {
                Adi = "Murat",
                Soyadi = "Yılmaz",
                KullaniciAdi = "murt",
                Sifre = "m123",
                Id = 1
            };

            Console.WriteLine("Kullanıcı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                // sisteme giriş yap
                Console.WriteLine($"Hoşgeldin {kullanici.Adi} {kullanici.Soyadi}");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
            }
            #endregion

            #region
            Araba araba = new()
            {
                Id = 1,
                KasaTipi = "SUV",
                Model = "T10x",
                Renk = "Kırmızı"

            };

            #endregion

            #region ornek 4 

            Kategori kategori = new()
            {
                Id = 3,
                KategorilerAdi = "Elektronik"

            };

            Kategori kategori2 = new()
            {
                Id = 4,
                KategorilerAdi = "Araba"

            };

            Kategori kategori3 = new()
            {
                Id = 5,
                KategorilerAdi = "Telefon"

            };

            Console.WriteLine();
            Console.WriteLine($"Anasayfa Hakkımızda {kategori.KategorilerAdi} {kategori2.KategorilerAdi} {kategori3.KategorilerAdi} iletişim" );


            #endregion

            #region ornek5 

            SinifMetotKullanimi metotKullanimi = new();

            var sonuc = metotKullanimi.LoginControl(kullaniciAdi, sifre);

            if (sonuc == true)
            {
                Console.WriteLine("Giriş Başarılı");
                Console.WriteLine("Hoşgeldin Admin");

            }

            else
            
                Console.WriteLine("Giriş Başarısız");

                Console.WriteLine();


                var toplamasonucu = metotKullanimi.Toplamayap(10, 8);
                Console.WriteLine("Toplama sonucu: " + toplamasonucu);

                Console.WriteLine();

            Console.WriteLine("toplama sonucu: " + toplamasonucu);

            Console.WriteLine();

            Console.WriteLine("Statik degisgen" + SinifMetotKullanimi.StatikDegisgen);

            Console.WriteLine("Dinamik degisgen" + metotKullanimi.DinamikDegisgen);


            #endregion

            #region ornek 6

            User user = new()
            {
                Id = 1,
                CreateDate = DateTime.Now,
                Name = "Test",
                Email = "test@test.co",
                Phone = "1234567890",
                Password = sifre,
                Username = kullaniciAdi


            };
            Console.WriteLine();
            bool kullaniciGirisSonuc = user.KullaniciGiris(user.Username, user.Password);
            Console.WriteLine("Kullanici girş sonuc: " + kullaniciGirisSonuc);

            #endregion
        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}