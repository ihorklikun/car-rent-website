using CarRentWebsite.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Models.Users;

namespace CarRentWebsite.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ConditionReport>()
                .HasOne<ConditionMark>(x => x.InteriorCondition)
                .WithMany(c => c.InteriorConditionReports)
                .HasForeignKey(p => p.InteriorConditionId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ConditionReport>()
                .HasOne<ConditionMark>(x => x.LpcCondition)
                .WithMany(c => c.LpcConditionReports)
                .HasForeignKey(p => p.LpcConditionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Car>()
                .HasOne<Location>(x => x.Location)
                .WithMany(c => c.Cars)
                .HasForeignKey(x => x.LocationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Seed();
        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ServiceWorker> ServiceWorkers { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Engine> Engines { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<CarService> CarServices { get; set; }
        public DbSet<CarServiceReport> CarServiceReports { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ConditionMark> ConditionMarks { get; set; }
        public DbSet<ConditionReport> ConditionReports { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<RentAddedOption> RentAddedOptions { get; set; }
        public DbSet<RentAdditionalOption> RentAdditionalOptions { get; set; }
        public DbSet<RentStatus> RentStatuses { get; set; }
        public DbSet<CarPrice> PriceCoefficients { get; set; }
    }
}
