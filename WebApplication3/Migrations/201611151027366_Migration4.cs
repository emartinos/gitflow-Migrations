namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration4 : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE TABLE STATS 
(ID INTEGER, 
MONTH INTEGER CHECK (MONTH BETWEEN 1 AND 12), 
TEMP_F REAL CHECK (TEMP_F BETWEEN -80 AND 150), 
RAIN_I REAL CHECK (RAIN_I BETWEEN 0 AND 100), 
PRIMARY KEY (ID, MONTH));");
        }
        
        public override void Down()
        {
        }
    }
}
