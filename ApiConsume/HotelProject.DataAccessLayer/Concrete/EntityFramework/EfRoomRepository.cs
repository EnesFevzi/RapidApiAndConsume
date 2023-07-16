using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete.EntityFramework
{
	public class EfRoomRepository : GenericRepository<Room>, IRoomRepository
	{
		public EfRoomRepository(TContext context) : base(context)
		{
		}

        public int RoomCount()
        {
           var context = new TContext();
            return  context.Rooms.Count();
        }
    }
}
