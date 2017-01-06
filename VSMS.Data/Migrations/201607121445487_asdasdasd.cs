namespace VSMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdasd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.comboboxdatas",
                c => new
                    {
                        vvvid = c.Int(nullable: false, identity: true),
                        vehiclebrand = c.String(maxLength: 100),
                        vehiclemanufacturar = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.vvvid)
                .Index(t => t.vehiclebrand, unique: true)
                .Index(t => t.vehiclemanufacturar, unique: true);
            
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        fName = c.String(nullable: false),
                        lName = c.String(nullable: false),
                        mobile = c.String(nullable: false),
                        email = c.String(nullable: false),
                        address = c.String(nullable: false),
                        insuranceCompany = c.String(nullable: false),
                        insuranceId = c.String(nullable: false, maxLength: 100),
                        invoiceDate = c.DateTime(nullable: false),
                        warrentyS = c.DateTime(nullable: false),
                        warrentyE = c.DateTime(nullable: false),
                        vehicleId = c.Int(nullable: false),
                        paymentType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.customerId)
                .ForeignKey("dbo.vehicles", t => t.vehicleId, cascadeDelete: true)
                .Index(t => t.insuranceId, unique: true)
                .Index(t => t.vehicleId);
            
            CreateTable(
                "dbo.vehicles",
                c => new
                    {
                        vehicleId = c.Int(nullable: false, identity: true),
                        model = c.String(nullable: false),
                        chasisNo = c.String(nullable: false),
                        brand = c.String(nullable: false),
                        manufacturer = c.String(nullable: false),
                        mYear = c.String(nullable: false),
                        color = c.String(nullable: false),
                        engineNo = c.String(nullable: false),
                        status = c.String(nullable: false),
                        bprice = c.Int(nullable: false),
                        sprice = c.Int(nullable: false),
                        image = c.Binary(),
                    })
                .PrimaryKey(t => t.vehicleId);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false, maxLength: 100),
                        userPass = c.String(nullable: false),
                        userType = c.String(nullable: false),
                        sQuestion = c.String(nullable: false),
                        aQuestion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.userId)
                .Index(t => t.userName, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.customers", "vehicleId", "dbo.vehicles");
            DropIndex("dbo.users", new[] { "userName" });
            DropIndex("dbo.customers", new[] { "vehicleId" });
            DropIndex("dbo.customers", new[] { "insuranceId" });
            DropIndex("dbo.comboboxdatas", new[] { "vehiclemanufacturar" });
            DropIndex("dbo.comboboxdatas", new[] { "vehiclebrand" });
            DropTable("dbo.users");
            DropTable("dbo.vehicles");
            DropTable("dbo.customers");
            DropTable("dbo.comboboxdatas");
        }
    }
}
