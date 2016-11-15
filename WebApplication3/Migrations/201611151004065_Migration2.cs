namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE TABLE customers
                ( customer_id int NOT NULL,
                customer_name char(50) NOT NULL,
                address char(50),
                city char(50),
                state char(25),
                zip_code char(10)
                );");
        }

        public override void Down()
        {
        }
    }
}
