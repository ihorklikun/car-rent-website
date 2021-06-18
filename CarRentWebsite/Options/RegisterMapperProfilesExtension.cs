using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CarRentWebsite.Options
{
    public static class RegisterMapperProfilesExtension
    {
        public static void RegisterMapperProfiles(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(c =>
            {
                c.AddProfile<MapperProfile>();
            });

            services.AddTransient(s => configuration.CreateMapper());
        }
    }
}
