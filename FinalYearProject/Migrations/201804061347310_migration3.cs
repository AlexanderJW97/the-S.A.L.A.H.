namespace theSALAH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.users", "Password", c => c.Binary());
            AlterColumn("dbo.users", "StoredSalt", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "StoredSalt", c => c.String());
            AlterColumn("dbo.users", "Password", c => c.String());
        }
    }
}
