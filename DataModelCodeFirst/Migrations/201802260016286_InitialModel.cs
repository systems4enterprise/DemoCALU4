namespace DataModelCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Authors (name) VALUES ('Hristijan Pejchinoski')");
        }
        
        public override void Down()
        {
        }
    }
}
