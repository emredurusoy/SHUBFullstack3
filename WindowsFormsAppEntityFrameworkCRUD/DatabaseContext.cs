using System.Data.Entity;
using System.Management.Instrumentation;
using WindowsFormsAppAdoNetCRUD; // entity framewrok kullanabilmek için gerekli 

namespace WindowsFormsAppEntityFrameworkCRUD
{
    internal class DatabaseContext : DbContext // DbContext Sınıfı entity framework paketiyle birlikte gelir 
    {
        public virtual DbSet<Category> Categories { get; set; } // dbset tanımlayarak veritabanındaki tabloları sembolize edioyruz
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<User> Users { get; set; }


    }
}
