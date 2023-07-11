using FluentValidation;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.ValidationRules.GuestValidationRules;

namespace HotelProject.WebUI.Extensions
{
    public static class ValidationExtensions
    {
        public static IServiceCollection LoadWebUILayerExtension(this IServiceCollection services)
        {

            services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
            services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
            return services;


        }
    }
}
