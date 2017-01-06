namespace VSMS.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VSMS.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<VSMS.Data.VSMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "VSMS.Data.VSMSContext";
        }

        protected override void Seed(VSMS.Data.VSMSContext context)
        {

            context.users.AddOrUpdate(t =>t.userId,
                new user() { userId=1, userName = "admin", userPass = "123", userType = "Admin", sQuestion = "how are you?", aQuestion = "Not Good" });

            context.vehicles.AddOrUpdate(t => t.vehicleId,
                new vehicle() { vehicleId = 1, bprice =5000000, brand = "Allion", chasisNo = "99F945JH", color = "Black", engineNo = "883400234023", manufacturer = "Toyota", model = "T2002", mYear = "2002", status = "Available"});
            
            
            context.comboboxdatas.AddOrUpdate(x =>x.vvvid,
                new comboboxdata() { vvvid = 1, vehiclebrand = "Allion", vehiclemanufacturar = "Toyota " },
                new comboboxdata() { vvvid = 2, vehiclebrand = "Nissan Leaf", vehiclemanufacturar = "Nissan" },
                new comboboxdata() {vvvid=3, vehiclebrand="Audi A1", vehiclemanufacturar="Audi"});
        
        }
           



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }

