namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE TABLE departments
( department_id int NOT NULL,
  department_name char(50) NOT NULL,
  CONSTRAINT departments_pk PRIMARY KEY (department_id)
);");
        }
        
        public override void Down()
        {
        }
    }
}
