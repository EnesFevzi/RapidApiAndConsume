using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Extensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
		{

			services.AddScoped<IRoomService, RoomManager>();
			services.AddScoped<IStaffService, StaffManager>();
			services.AddScoped<ITestimonialService, TestimonialManager>();
			services.AddScoped<IServiceService, ServiceManager>();
			services.AddScoped<ISubscribeService, SubscribeManager>();
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IBookingService, BookingManager>();
			

			return services;


		}
	}
}
