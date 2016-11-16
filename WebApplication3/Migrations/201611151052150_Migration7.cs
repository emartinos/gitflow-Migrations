namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration7 : DbMigration
    {
        public override void Up()
        {
            Sql(@"insert into suppliers values(1,'a','b')");
        }
        
        public override void Down()
        {
        }
    }
}
