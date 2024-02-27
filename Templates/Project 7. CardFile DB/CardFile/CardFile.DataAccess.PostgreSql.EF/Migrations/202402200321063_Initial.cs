namespace CardFile.DataAccess.PostgreSql.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        BirthDateText = c.String(),
                        Position = c.String(),
                        Division = c.String(),
                        EmploymentDate = c.DateTime(nullable: false),
                        EmploymentDateText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("public.Employees");
        }
    }
}
