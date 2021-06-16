using AutoMapper;
using CarRentWebsite.Models;
using CarRentWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Settings
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Car, CarViewModel>();
            CreateMap<CarViewModel, Car>();
            
            CreateMap<Car, CreateCarViewModel>();
            CreateMap<CreateCarViewModel, Car>();
            
            CreateMap<Car, UpdateCarViewModel>();
            CreateMap<UpdateCarViewModel, Car>();

            CreateMap<Brand, BrandViewModel>();


        }
    }
}
