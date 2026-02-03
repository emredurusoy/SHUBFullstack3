
namespace Konu14InterfacesArayuzler
{
    internal interface ISinifGereksinimleri // bu interface her classta  bulunması gereken zorunlu özllikleri içeriyor 
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } // nesnenin oluşma zamanını tutacak özellik 
        public DateTime UpdateDate { get; set; }// nesnenin son güncelleme zamanı tuttacak özellik 
        public bool IsActive  { get; set; } // nesnenin aktiflik durumu tutacak olan özellik 
    }
}
