namespace Client.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_RepositoryDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Mobile", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Mobile", c => c.Int(nullable: false));
        }
    }
}
