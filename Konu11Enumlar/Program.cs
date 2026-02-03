namespace Konu11Enumlar
{
    internal class Program
    {
        //Ennum(Numaratör ) lar nesneleri numaralandırmak için kullanılır 
        /* 
         * Enum tipleri üzerindeki kısıtlar 
         * 1-Enum blokunda metot tanımlamaz 
         * 2-Arayüzler (interface) kullanamaz 
         * 3- Enum blokunda property kulllanılmaz 
         */ 

        enum Aylar : byte
        {
            Ocak = 1, Şubat , Mart, Nisan , Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }

        enum SiparisDurumu
        {
            Hazılanıyor, Hazırlandı , KargoBekleniyor , Kargolandı, İadeEdildi 
        }
        enum Meyveler : int
        {
            Elma = 3 , Armut = 7 , Çilek = 1 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Konu11Enumlar");

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma} = {b}, {Meyveler.Çilek} = {c} ");

            Ornek(SiparisDurum : 1);
            Ornek(3);

        }
        static void Ornek(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazılanıyor)
            {
                Console.WriteLine("Siparişiniz Hazırlanıyor ");
            }
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
            {
                Console.WriteLine("Siparişiniz Hazırlandı ");
            }
            if (SiparisDurum == (int)SiparisDurumu.KargoBekleniyor)
            {
                Console.WriteLine("Siparişiniz KargoBekleniyor ");
            }
            if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
            {
                Console.WriteLine("Siparişiniz Kargolandı ");
            }
            if (SiparisDurum == (int)SiparisDurumu.İadeEdildi)
            {
                Console.WriteLine("Sipariş İadeEdildi ");
            }
        }
    }
}
