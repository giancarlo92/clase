namespace BaseDeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AplicacionesMoviles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Telefono",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(),
                        numeroTelefonico = c.Int(nullable: false),
                        FechaDeLanzamiento = c.DateTime(),
                        UsuarioId = c.Int(nullable: false),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        Edad = c.Int(nullable: false),
                        Dni = c.String(),
                        DiaDeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TelefonoAplicacionesMoviles",
                c => new
                    {
                        Telefono_Id = c.Int(nullable: false),
                        AplicacionesMoviles_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Telefono_Id, t.AplicacionesMoviles_Id })
                .ForeignKey("dbo.Telefono", t => t.Telefono_Id, cascadeDelete: true)
                .ForeignKey("dbo.AplicacionesMoviles", t => t.AplicacionesMoviles_Id, cascadeDelete: true)
                .Index(t => t.Telefono_Id)
                .Index(t => t.AplicacionesMoviles_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefono", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.TelefonoAplicacionesMoviles", "AplicacionesMoviles_Id", "dbo.AplicacionesMoviles");
            DropForeignKey("dbo.TelefonoAplicacionesMoviles", "Telefono_Id", "dbo.Telefono");
            DropIndex("dbo.TelefonoAplicacionesMoviles", new[] { "AplicacionesMoviles_Id" });
            DropIndex("dbo.TelefonoAplicacionesMoviles", new[] { "Telefono_Id" });
            DropIndex("dbo.Telefono", new[] { "UsuarioId" });
            DropTable("dbo.TelefonoAplicacionesMoviles");
            DropTable("dbo.Usuario");
            DropTable("dbo.Telefono");
            DropTable("dbo.AplicacionesMoviles");
        }
    }
}
