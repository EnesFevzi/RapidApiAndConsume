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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeRepository _subscribeRepository;

		public SubscribeManager(ISubscribeRepository subscribeRepository)
		{
			_subscribeRepository = subscribeRepository;
		}

		public void TAdd(Subscribe t)
		{
			_subscribeRepository.Add(t);
		}

		public void TDelete(Subscribe t)
		{
			_subscribeRepository.Delete(t);
		}

		public Subscribe TGetByID(int id)
		{
			return _subscribeRepository.GetByID(id);
		}

		public List<Subscribe> TGetList()
		{
			return _subscribeRepository.GetList();
		}

		public void TUpdate(Subscribe t)
		{
			_subscribeRepository.Update(t);
		}
	}
}
