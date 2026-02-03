namespace Konu14InterfacesArayuzler
{
    public interface OrnekArayuz // class yerine interface kelimesi kullanarak tanımluyoruz 
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster(); // metot imzası  
    }
    interface icerebilecekler : IDemo //    interfaceler  başka interfaceler miras alabilir
    {   //  bu interface i kullanacak olan classlar aşağıdaki varlıkları kullanmak zorunadaır 
        public int sayi {  get; set; }
        public static int sayi2 { get; set; }
        // interfacelerde meototları değil sadexe imazalar yer alır     
        void Topla(); // geri değeri döndürmeyen metot imzası 
        int Toplamayap(); // geri int değer döndürmesi gereken metot imzası 
            
    }

    class Arayuzkullanimi : icerebilecekler // bu şekildeki miras alındığnda interfaceler içerisindeki varlıklar classta tutulmak zorunda
    {
        public int sayi { get; set; }   
        public int Id { get; set; } //  class içerisinde  interface de olmayan ama classta olması içindeki varlıklar class ta olması gereken property veya metotlar bulunabilir
        public void Goster() // interfacete imzası bulunan metot class içinde kullanmak zorundadır 
        {
            Console.WriteLine("void Goster metodu");
        }

        public void Topla()
        {
            Console.WriteLine("void Topla metodu");
        }

        public int Toplamayap()
        {
            return sayi + 1; 
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu14InterfacesArayuzler!");

            Arayuzkullanimi arayuz = new Arayuzkullanimi();
            arayuz.Topla();
            arayuz.sayi = 1;
            arayuz.Goster();
            Console.WriteLine("Toplama Sonuc: " + arayuz.Toplamayap());

            Console.WriteLine();

            Kategori kategori = new Kategori()
            {
                Id = 1 , Name = "Elektroink", IsActive = true   
            };

            Console.WriteLine("Kategori ");
            Console.WriteLine(kategori.Name);

            Console.WriteLine();

            Urun urun = new Urun()
            {
                Id = 1, 
                Name = "Ayfon Çift sim Telefonu",
                IsActive = true,
                Price  = 10000
            };

            Console.WriteLine("Ürün bilgileri ");
            Console.WriteLine(urun.Name);
            Console.WriteLine(urun.Price + "Tl ");
        }
    }
}
