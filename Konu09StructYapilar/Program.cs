namespace Konu09StructYapilar
{
    public struct Yapi
    {

        // public struct ad = "Ali"; 

        public int sayi;
        public string metin;
        public int MyProperty {  get; set; }

        public void Metot()
        {
            Console.WriteLine("yapi içindeki meotot çalışrı");
        }


    }
         

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu09StructYapilar");
            Yapi yapi = new Yapi();
            yapi.metin = "yapı metin";
            yapi.sayi = 1;
            yapi.Metot();
            Console.WriteLine(yapi.metin);
        }
    }
}
