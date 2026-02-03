

namespace Konu14InterfacesArayuzler
{
    internal class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } // nesnenin oluşma zamanını tutacak özellik 
        public DateTime UpdateDate { get; set; }// nesnenin son güncelleme zamanı tuttacak özellik 
        public bool IsActive { get; set; } // nesnenin aktiflik durumu t

        public string? Name { get; set; }

        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }

    }
}
