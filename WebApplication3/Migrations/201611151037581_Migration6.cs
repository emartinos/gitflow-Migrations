namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration6 : DbMigration
    {
        public override void Up()
        {
            Sql(@"TRUNCATE TABLE departments");
        }
        
        public override void Down()
        {
        }
    }
}
