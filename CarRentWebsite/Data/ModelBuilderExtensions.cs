using CarRentWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region RentAdditionalOption
            modelBuilder.Entity<RentAdditionalOption>().HasData(
                new RentAdditionalOption
                {
                    Id = 1,
                    Name = "Child Chair",
                    Price = 50
                },
                new RentAdditionalOption
                {
                    Id = 2,
                    Name = "Gps",
                    Price = 25
                },
                new RentAdditionalOption
                {
                    Id = 3,
                    Name = "Phone Holder",
                    Price = 10
                }
            );
            #endregion

            #region RentStatus
            modelBuilder.Entity<RentStatus>().HasData(
                new CarStatus
                {
                    Id = 1,
                    Name = "Created"
                },
                new CarStatus
                {
                    Id = 2,
                    Name = "Accepted"
                },
                new CarStatus
                {
                    Id = 3,
                    Name = "Started"
                },
                new CarStatus
                {
                    Id = 4,
                    Name = "Finished"
                }
            );
            #endregion

            #region Role
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Customer"
                },
                new Role
                {
                    Id = 2,
                    Name = "Manager"
                },
                new Role
                {
                    Id = 3,
                    Name = "Admin"
                },
                new Role
                {
                    Id = 4,
                    Name = "ServiceWorker"
                }
            );
            #endregion

            #region CarStatus
            modelBuilder.Entity<CarStatus>().HasData(
                new CarStatus
                {
                    Id = 1,
                    Name = "Idle"
                },
                new CarStatus
                {
                    Id = 2,
                    Name = "Rent"
                },
                new CarStatus
                {
                    Id = 3,
                    Name = "Repair"
                }
            );
            #endregion

            #region Transmition
            modelBuilder.Entity<Transmission>().HasData(
                new Transmission
                {
                    Id = 1,
                    Name = "AT"
                },
                new Transmission
                {
                    Id = 2,
                    Name = "MT"
                },
                new Transmission
                {
                    Id = 3,
                    Name = "AM"
                },
                new Transmission
                {
                    Id = 4,
                    Name = "CVT"
                }
            );
            #endregion

            #region ClassType
            modelBuilder.Entity<CarType>().HasData(
                new CarType
                {
                    Id = 1,
                    Name = "Econom"
                },
                new CarType
                {
                    Id = 2,
                    Name = "Business"
                },
                new CarType
                {
                    Id = 3,
                    Name = "Luxury"
                }
            );
            #endregion ClassType

            #region ClassCar
            modelBuilder.Entity<CarClass>().HasData(
                new CarClass
                {
                    Id = 1,
                    Name = "Microcar"
                },
                new CarClass
                {
                    Id = 2,
                    Name = "Subcompact car"
                },
                new CarClass
                {
                    Id = 3,
                    Name = "Compact car"
                },
                new CarClass
                {
                    Id = 4,
                    Name = "Mid-size car"
                },
                new CarClass
                {
                    Id = 5,
                    Name = "Entry-level car"
                },
                new CarClass
                {
                    Id = 6,
                    Name = "Full-size car"
                },
                new CarClass
                {
                    Id = 7,
                    Name = "Mid-size car"
                },
                new CarClass
                {
                    Id = 8,
                    Name = "Hatchback"
                },
                new CarClass
                {
                    Id = 9,
                    Name = "Grand tourer"
                },
                new CarClass
                {
                    Id = 10,
                    Name = "Compact minivan"
                },
                new CarClass
                {
                    Id = 11,
                    Name = "Minivan"
                },
                new CarClass
                {
                    Id = 12,
                    Name = "Mini SUV"
                },
                new CarClass
                {
                    Id = 13,
                    Name = "Mid-size SUV"
                },
                new CarClass
                {
                    Id = 14,
                    Name = "Full-size SUV"
                },
                new CarClass
                {
                    Id = 15,
                    Name = "Mini pickup truck"
                },
                new CarClass
                {
                    Id = 16,
                    Name = "Mid-size pickup truck"
                },
                new CarClass
                {
                    Id = 17,
                    Name = "Pickup truck"
                },
                new CarClass
                {
                    Id = 18,
                    Name = "Compact SUV"
                }
            );
            #endregion

            #region Fuel
            modelBuilder.Entity<Fuel>().HasData(
                new Fuel
                {
                    Id = 1,
                    Name = "Petrol"
                },
                new Fuel
                {
                    Id = 2,
                    Name = "Diesel"
                },
                new Fuel
                {
                    Id = 3,
                    Name = "Electric"
                },
                new Fuel
                {
                    Id = 4,
                    Name = "Hybrid"
                },
                new Fuel
                {
                    Id = 5,
                    Name = "Propane"
                }
            );
            #endregion

            #region Brand
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Mercedes-Benz"
                },
                new Brand
                {
                    Id = 2,
                    Name = "Toyota"
                },
                new Brand
                {
                    Id = 3,
                    Name = "Tesla"
                },
                new Brand
                {
                    Id = 4,
                    Name = "Volkswagen"
                },
                new Brand
                {
                    Id = 5,
                    Name = "Porsche"
                },
                new Brand
                {
                    Id = 6,
                    Name = "Honda"
                },
                new Brand
                {
                    Id = 7,
                    Name = "Ford"
                },
                new Brand
                {
                    Id = 8,
                    Name = "Nissan"
                },
                new Brand
                {
                    Id = 9,
                    Name = "BMW"
                }
            );
            #endregion

            #region Engine
            modelBuilder.Entity<Engine>().HasData(
                new Engine
                {
                    Id = 1,
                    Name = "Engine1",
                    FuelCapacity = 6,
                    Power = 120,
                    Torque = 45,
                    WinCode = "ASD45ufa95"
                },
                new Engine
                {
                    Id = 2,
                    Name = "Engine2",
                    FuelCapacity = 6,
                    Power = 120,
                    Torque = 45,
                    WinCode = "ASttrra95"
                },
                new Engine
                {
                    Id = 3,
                    Name = "Engine3",
                    FuelCapacity = 6,
                    Power = 120,
                    Torque = 45,
                    WinCode = "1123456"
                },
                new Engine
                {
                    Id = 4,
                    Name = "Engine4",
                    FuelCapacity = 6,
                    Power = 120,
                    Torque = 45,
                    WinCode = "9034hh5"
                }
            );
            #endregion

            #region City
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Dnipro"
                },
                new City
                {
                    Id = 2,
                    Name = "Lviv"
                },
                new City
                {
                    Id = 3,
                    Name = "Kharkiw"
                },
                new City
                {
                    Id = 4,
                    Name = "Kyiv"
                }
            );
            #endregion

            #region Location
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    Building = "7a",
                    Street = "Veresneva Street",
                    CityId = 4
                },
                new Location
                {
                    Id = 2,
                    Building = "17",
                    Street = "Bandera Street",
                    CityId = 2
                },
                new Location
                {
                    Id = 3,
                    Building = "46",
                    Street = "Heroes Avenue",
                    CityId = 1
                },
                new Location
                {
                    Id = 4,
                    Building = "34",
                    Street = "Antonov Street",
                    CityId = 3
                }
            );
            #endregion

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    Model = "model1",
                    KilometersDriven = 1111,
                    CarClassId = 2,
                    CarStatusId = 1,
                    CarTypeId = 1,
                    EngineId = 2,
                    Model = "X5",
                    KilometersDriven = 4500,
                    Description = "Car description...",
                    SeatsCount = 4,
                    LocationId = 1,
                    FuelId = 1,
                    TransmissionId = 1,
                    RegisterDate = DateTime.Now,
                    TrunkSize = 40,
                    RegisterNumber = "BO7104RT",
                    ImageUrl = "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg"
                }, 

                new Car
                {
                    Id = 2,
                    BrandId = 3,
                    Model = "model2",
                    KilometersDriven = 2222,
                    CarClassId = 4,
                    CarStatusId = 1,
                    Model = "X6",
                    KilometersDriven = 4500,
                    CarTypeId = 2,
                    EngineId = 3,
                    Description = "Car description2...",
                    SeatsCount = 4,
                    LocationId = 4,
                    FuelId = 1,
                    TransmissionId = 2,
                    RegisterDate = DateTime.Now,
                    TrunkSize = 60,
                    RegisterNumber = "AA7104MT",
                    ImageUrl = "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg",

                },

                new Car
                {
                    Id = 3,
                    Model = "model3",
                    KilometersDriven = 3333,
                    BrandId = 1,
                    CarClassId = 5,
                    CarStatusId = 1,
                    Model = "Model name",
                    KilometersDriven = 4500,
                    CarTypeId = 3,
                    EngineId = 4,
                    Description = "Car description3...",
                    SeatsCount = 4,
                    LocationId = 2,
                    FuelId = 1,
                    TransmissionId = 3,
                    RegisterDate = DateTime.Now,
                    TrunkSize = 80,
                    RegisterNumber = "AE5544KE",
                    ImageUrl = "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg"
                },

                new Car
                {
                    Id = 4,
                    BrandId = 1,
                    Model = "model4",
                    KilometersDriven = 4444,
                    CarClassId = 5,
                    CarStatusId = 1,
                    CarTypeId = 3,
                    Model = "Model name2",
                    KilometersDriven = 4500,
                    EngineId = 4,
                    Description = "Car description4...",
                    SeatsCount = 4,
                    LocationId = 4,
                    FuelId = 1,
                    TransmissionId = 3,
                    RegisterDate = DateTime.Now,
                    TrunkSize = 60,
                    RegisterNumber = "AE5544KE",
                    ImageUrl = "https://lh3.googleusercontent.com/proxy/r31nMzFvIBFXtAETyk6TaTrPpwO0eNWSDyQa1UGXCb9XkHa2vbDGczQu8J1vXfjv5v663TVdd-mh-kVtOqvRkcNRmFMBbykg"
                }
            );
            #endregion

            //#region Reviews
            //modelBuilder.Entity<Review>().HasData(
            //    new Review 
            //    {
            //        Id = 1,
            //        CarId = 1,
            //        Title = "Title1",
            //        Text = "Text of review............",
            //        Mark = 4,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 2,
            //        CarId = 1,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 3,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 3,
            //        CarId = 1,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 5,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 4,
            //        CarId = 1,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 4,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 5,
            //        CarId = 3,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 4,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 6,
            //        CarId = 3,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 5,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 7,
            //        CarId = 2,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 4,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 8,
            //        CarId = 2,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 2,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    },
            //    new Review 
            //    {
            //        Id = 9,
            //        CarId = 2,
            //        Title = "Title1",
            //        Text = "Text of review",
            //        Mark = 3,
            //        CreateDate = DateTime.Now,
            //        CustomerId = "3feb5988-781d-42b1-8855-63bb2cfdb093"
            //    }
            //);
            //#endregion

            #region PriceCoeficients
            modelBuilder.Entity<PriceCoefficient>().HasData(
                new PriceCoefficient
                {
                    Id =1,
                    CarId = 1,
                    DaysCount = 4,
                    Coefficient = 0.9
                },
                new PriceCoefficient
                {
                    Id = 2,
                    CarId = 1,
                    DaysCount = 7,
                    Coefficient = 0.6
                },
                new PriceCoefficient
                {
                    Id = 3,
                    CarId = 1,
                    DaysCount = 14,
                    Coefficient = 0.5
                },
                new PriceCoefficient
                {
                    Id = 4,
                    CarId = 1,
                    DaysCount = 21,
                    Coefficient = 0.2
                },
                new PriceCoefficient
                {
                    Id = 5,
                    CarId = 2,
                    DaysCount = 4,
                    Coefficient = 0.8
                },
                new PriceCoefficient
                {
                    Id = 6,
                    CarId = 2,
                    DaysCount = 7,
                    Coefficient = 0.7
                },
                new PriceCoefficient
                {
                    Id = 7,
                    CarId = 2,
                    DaysCount = 14,
                    Coefficient = 0.6
                },
                new PriceCoefficient
                {
                    Id = 8,
                    CarId = 2,
                    DaysCount = 21,
                    Coefficient = 0.5
                },

                new PriceCoefficient
                {
                    Id = 9,
                    CarId = 3,
                    DaysCount = 4,
                    Coefficient = 0.8
                },
                new PriceCoefficient
                {
                    Id = 10,
                    CarId = 3,
                    DaysCount = 7,
                    Coefficient = 0.7
                },
                new PriceCoefficient
                {
                    Id = 11,
                    CarId = 3,
                    DaysCount = 14,
                    Coefficient = 0.6
                },
                new PriceCoefficient
                {
                    Id = 12,
                    CarId = 3,
                    DaysCount = 21,
                    Coefficient = 0.5
                },

                new PriceCoefficient
                {
                    Id = 13,
                    CarId = 4,
                    DaysCount = 4,
                    Coefficient = 0.9
                },
                new PriceCoefficient
                {
                    Id = 14,
                    CarId = 4,
                    DaysCount = 7,
                    Coefficient = 0.8
                },
                new PriceCoefficient
                {
                    Id = 15,
                    CarId = 4,
                    DaysCount = 14,
                    Coefficient = 0.7
                },
                new PriceCoefficient
                {
                    Id = 16,
                    CarId = 4,
                    DaysCount = 21,
                    Coefficient = 0.6
                }
            );
            #endregion

        }
    }
}
