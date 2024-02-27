namespace CardFile.DataAccess.PostgreSql.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeFix : DbMigration
    {
        public override void Up()
        {
            DropColumn("public.Employees", "BirthDateText");
            DropColumn("public.Employees", "EmploymentDateText");
        }
        
        public override void Down()
        {
            AddColumn("public.Employees", "EmploymentDateText", c => c.String());
            AddColumn("public.Employees", "BirthDateText", c => c.String());
        }
    }
}
