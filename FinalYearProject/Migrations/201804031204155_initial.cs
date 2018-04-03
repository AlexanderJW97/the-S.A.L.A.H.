namespace theSALAH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.addresses",
                c => new
                    {
                        addressIdentifier = c.Int(nullable: false, identity: true),
                        houseNumberOrName = c.String(),
                        street = c.String(),
                        city = c.String(),
                        county = c.String(),
                        country = c.String(),
                        postcode = c.String(),
                    })
                .PrimaryKey(t => t.addressIdentifier);
            
            CreateTable(
                "dbo.scouts",
                c => new
                    {
                        scoutID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        secondName = c.String(),
                        dateOfBirth = c.DateTime(nullable: false),
                        parentEmail = c.String(),
                        parentFirstName = c.String(),
                        parentSecondName = c.String(),
                        parentEmergencyNumb = c.Int(nullable: false),
                        healthInfo = c.String(),
                        Address_addressIdentifier = c.Int(),
                        group_groupID = c.Int(),
                    })
                .PrimaryKey(t => t.scoutID)
                .ForeignKey("dbo.addresses", t => t.Address_addressIdentifier)
                .ForeignKey("dbo.groups", t => t.group_groupID)
                .Index(t => t.Address_addressIdentifier)
                .Index(t => t.group_groupID);
            
            CreateTable(
                "dbo.locations",
                c => new
                    {
                        locationID = c.Int(nullable: false, identity: true),
                        locationName = c.String(),
                        Address_addressIdentifier = c.Int(),
                    })
                .PrimaryKey(t => t.locationID)
                .ForeignKey("dbo.addresses", t => t.Address_addressIdentifier)
                .Index(t => t.Address_addressIdentifier);
            
            CreateTable(
                "dbo.resources",
                c => new
                    {
                        resourceID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        quantity = c.Int(nullable: false),
                        notes = c.String(),
                        storageLocation_locationID = c.Int(),
                        group_groupID = c.Int(),
                    })
                .PrimaryKey(t => t.resourceID)
                .ForeignKey("dbo.locations", t => t.storageLocation_locationID)
                .ForeignKey("dbo.groups", t => t.group_groupID)
                .Index(t => t.storageLocation_locationID)
                .Index(t => t.group_groupID);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        password = c.String(),
                        storedSalt = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.groups",
                c => new
                    {
                        groupID = c.Int(nullable: false, identity: true),
                        group_name = c.String(),
                        meeting_place = c.String(),
                        group_type = c.String(),
                        user_ID = c.Int(),
                    })
                .PrimaryKey(t => t.groupID)
                .ForeignKey("dbo.users", t => t.user_ID)
                .Index(t => t.user_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.groups", "user_ID", "dbo.users");
            DropForeignKey("dbo.scouts", "group_groupID", "dbo.groups");
            DropForeignKey("dbo.resources", "group_groupID", "dbo.groups");
            DropForeignKey("dbo.resources", "storageLocation_locationID", "dbo.locations");
            DropForeignKey("dbo.locations", "Address_addressIdentifier", "dbo.addresses");
            DropForeignKey("dbo.scouts", "Address_addressIdentifier", "dbo.addresses");
            DropIndex("dbo.groups", new[] { "user_ID" });
            DropIndex("dbo.resources", new[] { "group_groupID" });
            DropIndex("dbo.resources", new[] { "storageLocation_locationID" });
            DropIndex("dbo.locations", new[] { "Address_addressIdentifier" });
            DropIndex("dbo.scouts", new[] { "group_groupID" });
            DropIndex("dbo.scouts", new[] { "Address_addressIdentifier" });
            DropTable("dbo.groups");
            DropTable("dbo.users");
            DropTable("dbo.resources");
            DropTable("dbo.locations");
            DropTable("dbo.scouts");
            DropTable("dbo.addresses");
        }
    }
}
