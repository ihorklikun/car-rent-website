using CarRentWebsite.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<Engine> Engines { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<CarService> CarServices { get; set; }
        public DbSet<CarServiceReport> CarServiceReports { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ConditionMark> ConditionMarks { get; set; }
        public DbSet<ConditionReport> ConditionReports { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmitions { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<RentAddedOption> RentAddedOptions { get; set; }
        public DbSet<RentAdditionalOption> RentAdditionalOptions { get; set; }
        public DbSet<RentStatus> RentStatuses { get; set; }
        public DbSet<PriceCoefficient> PriceCoeficients { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<ServiceWorker> ServiceWorker { get; set; }
    }
}
