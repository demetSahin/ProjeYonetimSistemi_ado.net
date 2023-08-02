using pys.Entity;
using System.Data.Entity;

namespace pys.Context
{
    internal class MyContext : DbContext //Code first DB yaratmak için DbContext sınıfından inheritance yoluyla MyContext oluşturulur.
    {
        //Modellere göre DB'leri yaratmak için.
        public DbSet<Kisi> Kisiler { get; set; } 
        public DbSet<ProjeEkibi> Ekipler { get; set; } 
        public DbSet<Proje> Projeler { get; set; }
    }
}


