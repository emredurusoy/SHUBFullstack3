namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu15AbstractClasses!");
            Console.WriteLine();
            //  Datebase database = new Datebase(); // abstaract class bu şeklinde new lenmezzz !!!
            Datebase sql = new SqlServer(); // Datebase sınıfından bir örnek oluşturmak için alıt sınıflar newlenir 
            sql.Add();
            sql.Get();
            sql.Update();
            sql.Delete();

            Console.WriteLine();

            Datebase mysql = new MySql();

            mysql.Add();
            mysql.Get();
            mysql.Update();
            mysql.Delete();
        }
    }
   abstract class Datebase // class önüne yazarak yapıyı oluşturuyoruz
    {
       public void Add()   
        {
            Console.WriteLine("Ekleme metodu çalıştı.");
        }
        internal abstract void Delete(); // silme metodu imzası
        internal abstract void Update();// güncelleme metodu imzası 
        internal abstract void Get(); //  veri getiröe metodu imzası
        
    }
    class SqlServer : Datebase
    {
        internal override void Delete()
        {
            Console.WriteLine("SqlServer Silme metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("SqlServer Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("SqlServer Güncelleme metodu çalıştı.");
        }
    }
    class Oracle : Datebase
    {
        internal override void Delete()
        {
            Console.WriteLine("Oracle Silme metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("Oracle Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("Oracle Güncelleme metodu çalıştı.");
        }
    }
    class MySql : Datebase
    {
        internal override void Delete()
        {
            Console.WriteLine("MySql Silme metodu çalıştı.");
        }

        internal override void Get()
        {
            Console.WriteLine("MySql Get metodu çalıştı.");
        }

        internal override void Update()
        {
            Console.WriteLine("MySql Güncelleme metodu çalıştı.");
        }
    }
}
