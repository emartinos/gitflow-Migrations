namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE TABLE Users
                (
                UserID int,
                LastName varchar(255),
                FirstName varchar(255),
                Address varchar(255),
                City varchar(255)
                );");
        }
        
        public override void Down()
        {
        }
    }
}
