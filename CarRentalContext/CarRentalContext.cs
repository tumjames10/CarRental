using Billy.Framework.Model;
using Billy.Server;
using CarRental.EFDBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalContext
{
    public class CarRentalCtx : BDBContext
        {
            public CarRentalCtx()

            : base(@" Data Source = (localdb)\v11.0;
                        AttachDbFilename=CarRental.mdf;
                        Initial Catalog = CarRentalDB;
                        Integrated Security=True;
                        Connect Timeout=30")
            {
                Database.SetInitializer<CarRentalCtx>(new CarRentalSetInitializer());
            }

            public DbSet<Borrower> Borrower { get; set; }
            public DbSet<Rent> Rent { get; set; }
            public DbSet<Car> Car { get; set; }
            public DbSet<Schedule> Schedule { get; set; }
            public DbSet<Referral> Referral { get; set; }
          

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


                base.OnModelCreating(modelBuilder);
            }
        }

        public class CarRentalSetInitializer : CreateDatabaseIfNotExists<CarRentalCtx>
        {
            protected override void Seed(CarRentalCtx context)
            {
                User _admin = new User() { Username = "Admin" };

                context.User.Add(_admin);

                context.SaveChanges();

                base.Seed(context);
            }

        }
}
