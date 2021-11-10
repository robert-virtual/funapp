namespace funapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDbCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Clave = c.String(maxLength: 433),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
