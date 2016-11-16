namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE TABLE suppliers
( supplier_id int NOT NULL,
  supplier_name char(50) NOT NULL,
  contact_name char(50),
  CONSTRAINT suppliers_pk PRIMARY KEY (supplier_id)
);");
        }
        
        public override void Down()
        {
        }
    }
}
