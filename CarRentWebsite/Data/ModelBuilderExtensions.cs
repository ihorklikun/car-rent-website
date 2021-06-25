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

            #region Cars
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    CarClassId = 2,
                    CarStatusId = 1,
                    CarTypeId = 1,
                    EngineId = 2,
                    SeatsCount = 4,
                    LocationId = 1,
                    FuelId = 1,
                    TransmissionId = 1,
                    RegisterDate = DateTime.Now,
                    TrunkSize = 40,
                    RegisterNumber = "BO7104RT",
                    KilometersDriven = 324234,
                    Model = "AMG G3",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRBjOLV4oC85vIevarurD4-EoGNKKyqKVY74w&usqp=CAU"
                }, 

                new Car
                {
                    Id = 2,
                    BrandId = 3,
                    CarClassId = 4,
                    CarStatusId = 1,
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
                    KilometersDriven = 3234,
                    Model = "Model S",
                    ImageUrl = "https://www.ixbt.com/img/n1/news/2021/0/6/lhd-model-3-social_large.png",

                },

                new Car
                {
                    Id = 3,
                    BrandId = 1,
                    CarClassId = 5,
                    CarStatusId = 1,
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
                    KilometersDriven = 300032,
                    Model = "525",
                    ImageUrl = "http://bm.img.com.ua/berlin/storage/600x500/0/d2/0a259e6b0be7ef8067228baf64361d20.jpg"
                },

                new Car
                {
                    Id = 4,
                    BrandId = 1,
                    CarClassId = 5,
                    CarStatusId = 1,
                    CarTypeId = 3,
                    EngineId = 4,
                    Description = "Car description4...",
                    SeatsCount = 4,
                    LocationId = 4,
                    FuelId = 1,
                    TransmissionId = 3,
                    RegisterDate = DateTime.Now,
                    TrunkSize = 60,
                    RegisterNumber = "AE5544KE",
                    KilometersDriven = 3343,
                    Model = "325",
                    ImageUrl = "data:image/jpeg;base64,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"
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
            modelBuilder.Entity<CarPrice>().HasData(
                new CarPrice
                {
                    Id =1,
                    CarId = 1,
                    DaysCount = 4,
                    Price = 200
                },
                new CarPrice
                {
                    Id = 2,
                    CarId = 1,
                    DaysCount = 7,
                    Price = 150
                },
                new CarPrice
                {
                    Id = 3,
                    CarId = 1,
                    DaysCount = 14,
                    Price = 90
                },
                new CarPrice
                {
                    Id = 4,
                    CarId = 1,
                    DaysCount = 21,
                    Price = 70
                },
                new CarPrice
                {
                    Id = 5,
                    CarId = 2,
                    DaysCount = 4,
                    Price = 90
                },
                new CarPrice
                {
                    Id = 6,
                    CarId = 2,
                    DaysCount = 7,
                    Price = 70
                },
                new CarPrice
                {
                    Id = 7,
                    CarId = 2,
                    DaysCount = 14,
                    Price = 60
                },
                new CarPrice
                {
                    Id = 8,
                    CarId = 2,
                    DaysCount = 21,
                    Price = 40
                },

                new CarPrice
                {
                    Id = 9,
                    CarId = 3,
                    DaysCount = 4,
                    Price = 150
                },
                new CarPrice
                {
                    Id = 10,
                    CarId = 3,
                    DaysCount = 7,
                    Price = 120
                },
                new CarPrice
                {
                    Id = 11,
                    CarId = 3,
                    DaysCount = 14,
                    Price = 90
                },
                new CarPrice
                {
                    Id = 12,
                    CarId = 3,
                    DaysCount = 21,
                    Price = 80
                },

                new CarPrice
                {
                    Id = 13,
                    CarId = 4,
                    DaysCount = 4,
                    Price = 70
                },
                new CarPrice
                {
                    Id = 14,
                    CarId = 4,
                    DaysCount = 7,
                    Price = 60
                },
                new CarPrice
                {
                    Id = 15,
                    CarId = 4,
                    DaysCount = 14,
                    Price = 50
                },
                new CarPrice
                {
                    Id = 16,
                    CarId = 4,
                    DaysCount = 21,
                    Price = 40
                }
            );
            #endregion



        }
    }
}
