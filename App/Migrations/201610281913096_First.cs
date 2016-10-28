namespace ProgrammingEfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "FirstVisit", c => c.DateTime(nullable: false));
            DropColumn("dbo.Patients", "VisitFirst");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "VisitFirst", c => c.DateTime(nullable: false));
            DropColumn("dbo.Patients", "FirstVisit");
        }
    }
}
