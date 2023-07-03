using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		private readonly IServiceRepository _serviceRepository;

		public ServiceManager(IServiceRepository serviceRepository)
		{
			_serviceRepository = serviceRepository;
		}

		public void TAdd(Service t)
		{
			_serviceRepository.Add(t);
		}

		public void TDelete(Service t)
		{
			_serviceRepository.Delete(t);
		}

		public Service TGetByID(int id)
		{
			return _serviceRepository.GetByID(id);	
		}

		public List<Service> TGetList()
		{
			return _serviceRepository.GetList();
		}

		public void TUpdate(Service t)
		{
			_serviceRepository.Update(t);
		}
	}
}
