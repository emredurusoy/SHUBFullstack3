using System.Data; // veritabbanı işlemleri için gerekli kütüpahane
using System.Data.SqlClient; // sql işlemleri için ado.net kütüpahanesi 
using System.Security.Cryptography.X509Certificates; 
namespace WindowsFormsAppAdoNetCRUD
{
    internal class OrtakDAL
    {
       internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=WindowsFormsAppAdoNetCRUD; Integrated Security=True; "); // veritanaınımım bulunduğu server bilgisini connection string olarak burada tanımlıyorum
        internal void ConnectionKontrol()
        {
            if (_connection.State != ConnectionState.Open) // eğer veritabanı bağlantımızın durumu kapalı ise 
                _connection.Open(); // veritabanı bağlantısı aç
        } 
            public DataTable GetDataTable(string sqlSorgu) 
            {
            var dt = new DataTable(); // geri döndüreceğimiz data table nesnesi 

            ConnectionKontrol(); // veritabanı vağlantısı kapalıysa açacak metod

            var command = new SqlCommand(sqlSorgu, _connection); // server da sql sorgusu çalıştaracak nesne 

            SqlDataReader reader = command.ExecuteReader(); // sql komutunu çalıştırır ve dönen datayı rreader nesnesine aktar 

            dt.Load(reader); // reader içindekki verileri data table nesnesine yükle 

            reader.Close(); // reader nesnesini kapa 
            _connection.Close(); // connetion nesneini kapa 
            command.Dispose(); // komutu yoket 

            return dt; // db den okunan verileri gönder.

            }
    }
}

