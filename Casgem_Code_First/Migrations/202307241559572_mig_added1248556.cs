namespace Casgem_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_added1248556 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Destination = c.String(),
                        Duration = c.String(),
                        Mail = c.String(),
                        BookingDate = c.DateTime(nullable: false),
                        BookingStatus = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Guides",
                c => new
                    {
                        GuideID = c.Int(nullable: false, identity: true),
                        GuideName = c.String(),
                        GuideTitle = c.String(),
                        GuideImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GuideID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaUrl = c.String(),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaID)
                .ForeignKey("dbo.Guides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Mail = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationID = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(),
                        DayNight = c.String(),
                        Capacity = c.Byte(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        AboutDes = c.String(),
                        AboutTitle = c.String(),
                        AboutResim = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        FeatureDes = c.String(),
                        FeatureTitle = c.String(),
                        FeatureImage = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        IletisimID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        FaceURL = c.String(),
                        TwitterURL = c.String(),
                        InsagramURL = c.String(),
                        MailURL = c.String(),
                        LinkedinURL = c.String(),
                    })
                .PrimaryKey(t => t.IletisimID);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryID = c.Int(nullable: false, identity: true),
                        GalleryURL = c.String(),
                    })
                .PrimaryKey(t => t.GalleryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryURL = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelID = c.Int(nullable: false, identity: true),
                        TravelCategory = c.String(),
                    })
                .PrimaryKey(t => t.TravelID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.SocialMedias", new[] { "GuideID" });
            DropForeignKey("dbo.SocialMedias", "GuideID", "dbo.Guides");
            DropTable("dbo.Travels");
            DropTable("dbo.Categories");
            DropTable("dbo.Galleries");
            DropTable("dbo.Iletisims");
            DropTable("dbo.Features");
            DropTable("dbo.Abouts");
            DropTable("dbo.Admins");
            DropTable("dbo.Destinations");
            DropTable("dbo.Contacts");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Guides");
            DropTable("dbo.Bookings");
        }
    }
}
