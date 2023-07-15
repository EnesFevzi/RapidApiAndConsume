using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete.EntityFramework;
using HotelProject.DataAccessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services)
		{
           

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IRoomRepository, EfRoomRepository>();
			services.AddScoped<IStaffRepository, EfStaffRepository>();
			services.AddScoped<ITestimonialRepository, EfTestimonialRepository>();
			services.AddScoped<IServiceRepository, EfServiceRepository>();
			services.AddScoped<ISubscribeRepository, EfSubscribeRepository>();
			services.AddScoped<IAboutRepository, EfAboutRepository>();
			services.AddScoped<IBookingRepository, EfBookingRepository>();
			services.AddScoped<IContactRepository, EfContactRepository>();
			services.AddScoped<IGuestRepository, EfGuestRepository>();
			services.AddScoped<ISendMessageRepository, EfSendMessageRepository>();
			services.AddScoped<IMessageCategoryRepository, EfMessageCategoryRepository>();
			services.AddScoped<IWorkLocationRepository, EfWorkLocationRepository>();
			services.AddScoped<IAppUserRepository, EfAppUserRepository>();
			return services;


		}
	}
}
