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
	public class RoomManager : IRoomService
	{
		private readonly IRoomRepository _roomRepository;

		public RoomManager(IRoomRepository roomRepository)
		{
			_roomRepository = roomRepository;
		}

		public void TAdd(Room t)
		{
			_roomRepository.Add(t);
		}

		public void TDelete(Room t)
		{
			_roomRepository.Delete(t);
		}

		public Room TGetByID(int id)
		{
			return _roomRepository.GetByID(id);
		}

		public List<Room> TGetList()
		{
			return _roomRepository.GetList();
		}

		public void TUpdate(Room t)
		{
			_roomRepository.Update(t);
		}
	}
}
