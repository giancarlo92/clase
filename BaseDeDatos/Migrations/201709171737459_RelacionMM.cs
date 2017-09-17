namespace BaseDeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelacionMM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AplicacionesMoviles", "Nombre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AplicacionesMoviles", "Nombre");
        }
    }
}
