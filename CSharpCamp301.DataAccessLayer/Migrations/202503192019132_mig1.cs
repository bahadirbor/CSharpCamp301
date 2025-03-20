namespace CSharpCamp301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            //Update yaparsan bu işlem yapılacak
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //İşlemden vazgeçersen bu işlem yapılacak
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
