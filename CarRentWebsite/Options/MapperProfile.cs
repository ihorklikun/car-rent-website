using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRentWebsite.Models;
using CarRentWebsite.ViewModels;
using CarRentWebsite.ViewModels.AdditionalOption;
using CarRentWebsite.ViewModels.Car;
using CarRentWebsite.ViewModels.Engine;
using CarRentWebsite.ViewModels.RentStatus;
using CarRentWebsite.ViewModels.Rent;
using CarRentWebsite.ViewModels.Transmission;

namespace CarRentWebsite.Options
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Engine, EngineViewModel>().MaxDepth(2);
            CreateMap<EngineViewModel, Engine>().MaxDepth(2);

            CreateMap<RentStatus, RentStatusViewModel>().MaxDepth(2);
            CreateMap<RentStatusViewModel, RentStatus>().MaxDepth(2);

            CreateMap<Transmission, TransmissionViewModel>().MaxDepth(2);
            CreateMap<TransmissionViewModel, Transmission>().MaxDepth(2);

            CreateMap<Brand, BrandViewModel>().MaxDepth(2);
            CreateMap<BrandViewModel, Brand>().MaxDepth(2);

            CreateMap<CarClass, CarClassViewModel>().MaxDepth(2);
            CreateMap<CarClassViewModel, CarClass>().MaxDepth(2);

            CreateMap<CarStatus, CarStatusViewModel>().MaxDepth(2);
            CreateMap<CarStatusViewModel, CarStatus>().MaxDepth(2);

            CreateMap<CarType, CarTypeViewModel>().MaxDepth(2);
            CreateMap<CarTypeViewModel, CarType>().MaxDepth(2);


            CreateMap<Car, CarViewModel>().MaxDepth(2);
            CreateMap<CarViewModel, Car>().MaxDepth(2);
            
            CreateMap<Car, CreateCarViewModel>().MaxDepth(2);
            CreateMap<CreateCarViewModel, Car>().MaxDepth(2);
            
            CreateMap<Car, UpdateCarViewModel>().MaxDepth(2);
            CreateMap<UpdateCarViewModel, Car>().MaxDepth(2);
            
            CreateMap<Fuel, FuelViewModel>().MaxDepth(2);
            CreateMap<FuelViewModel, Fuel>().MaxDepth(2);


            CreateMap<Rent, RentViewModel>().MaxDepth(2);
            CreateMap<RentViewModel, Rent>().MaxDepth(2);

            CreateMap<Rent, CreateRentViewModel>().MaxDepth(2);
            CreateMap<CreateRentViewModel, Rent>().MaxDepth(2);


            CreateMap<RentAdditionalOption, CreateRentAdditionalOptionViewModel>().MaxDepth(2);
            CreateMap<CreateRentAdditionalOptionViewModel, RentAdditionalOption>().MaxDepth(2);

            CreateMap<RentAdditionalOption, RentAdditionalOptionViewModel>().MaxDepth(2);
            CreateMap<RentAdditionalOptionViewModel, RentAdditionalOption>().MaxDepth(2);
        }
    }
}
