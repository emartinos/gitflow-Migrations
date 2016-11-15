namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration8 : DbMigration
    {
        public override void Up()
        {
            Sql(@"Truncate Table suppliers");
        }
        
        public override void Down()
        {
        }
    }
}
