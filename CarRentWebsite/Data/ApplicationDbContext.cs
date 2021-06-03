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

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ServiceWorker> ServiceWorkers { get; set; }


        //public DbSet<CarRentWebsite.Models.Engine> Engines { get; set; }
        //public DbSet<CarRentWebsite.Models.Car> Cars { get; set; }
        //public DbSet<CarRentWebsite.Models.CarClass> CarClasses { get; set; }
        //public DbSet<CarRentWebsite.Models.CarService> CarServices { get; set; }
        //public DbSet<CarRentWebsite.Models.CarServiceReport> CarServiceReports { get; set; }
        //public DbSet<CarRentWebsite.Models.CarType> CarTypes { get; set; }
        //public DbSet<CarRentWebsite.Models.City> Cities { get; set; }
        //public DbSet<CarRentWebsite.Models.Country> Countries { get; set; }
        //public DbSet<CarRentWebsite.Models.ConditionMark> ConditionMarks { get; set; }
        //public DbSet<CarRentWebsite.Models.ConditionReport> ConditionReports { get; set; }
        //public DbSet<CarRentWebsite.Models.Fuel> Fuels { get; set; }
        //public DbSet<CarRentWebsite.Models.Transmission> Transmitions { get; set; }
        //public DbSet<CarRentWebsite.Models.CarStatus> CarStatuses { get; set; }
        //public DbSet<CarRentWebsite.Models.Review> Reviews { get; set; }
        //public DbSet<CarRentWebsite.Models.Rent> Rents { get; set; }
        //public DbSet<CarRentWebsite.Models.RentAddedOption> RentAddedOptions { get; set; }
        //public DbSet<CarRentWebsite.Models.RentAdditionalOption> RentAdditionalOptions { get; set; }
        //public DbSet<CarRentWebsite.Models.RentStatus> RentStatuses { get; set; }
        //public DbSet<CarRentWebsite.Models.PriceCoefficient> PriceCoeficients { get; set; }
        //public DbSet<CarRentWebsite.Models.Location> Locations { get; set; }
    }
}
