namespace ProjetoFinal.ProdutosMarcas.Persistencia.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Inicial_Criacao_Produto_Marca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MARCAS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PRODUTOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        MarcaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MARCAS", t => t.MarcaId)
                .Index(t => t.MarcaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRODUTOS", "MarcaId", "dbo.MARCAS");
            DropIndex("dbo.PRODUTOS", new[] { "MarcaId" });
            DropTable("dbo.PRODUTOS");
            DropTable("dbo.MARCAS");
        }
    }
}
