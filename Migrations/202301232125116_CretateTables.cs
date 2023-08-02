namespace pys.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CretateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjeEkibis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kisis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        adi = c.String(),
                        soyadi = c.String(),
                        cinsiyet = c.String(),
                        eposta = c.String(),
                        telefon = c.String(),
                        dogumTarihi = c.DateTime(nullable: false),
                        adres = c.String(),
                        isTecrubesi = c.Double(nullable: false),
                        ProjeEkibi_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProjeEkibis", t => t.ProjeEkibi_ID)
                .Index(t => t.ProjeEkibi_ID);
            
            CreateTable(
                "dbo.Projes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        projeAdi = c.String(),
                        stratejikEtki = c.String(),
                        projeNo = c.String(),
                        amac = c.String(),
                        problemTanimi = c.String(),
                        kapsam = c.String(),
                        kayitTarihi = c.DateTime(nullable: false),
                        projeBaslangici = c.DateTime(nullable: false),
                        projeBitisi = c.DateTime(nullable: false),
                        tahminiBaslangic = c.DateTime(nullable: false),
                        tahminiBitis = c.DateTime(nullable: false),
                        projeDurumu = c.Int(nullable: false),
                        parasalGetiri = c.Double(nullable: false),
                        getiriTipi = c.Int(nullable: false),
                        document = c.String(),
                        projeTipi = c.Int(nullable: false),
                        kmTaslari = c.String(),
                        projeEkibi_ID = c.Int(),
                        projeYurutucusu_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProjeEkibis", t => t.projeEkibi_ID)
                .ForeignKey("dbo.Kisis", t => t.projeYurutucusu_ID)
                .Index(t => t.projeEkibi_ID)
                .Index(t => t.projeYurutucusu_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projes", "projeYurutucusu_ID", "dbo.Kisis");
            DropForeignKey("dbo.Projes", "projeEkibi_ID", "dbo.ProjeEkibis");
            DropForeignKey("dbo.Kisis", "ProjeEkibi_ID", "dbo.ProjeEkibis");
            DropIndex("dbo.Projes", new[] { "projeYurutucusu_ID" });
            DropIndex("dbo.Projes", new[] { "projeEkibi_ID" });
            DropIndex("dbo.Kisis", new[] { "ProjeEkibi_ID" });
            DropTable("dbo.Projes");
            DropTable("dbo.Kisis");
            DropTable("dbo.ProjeEkibis");
        }
    }
}


