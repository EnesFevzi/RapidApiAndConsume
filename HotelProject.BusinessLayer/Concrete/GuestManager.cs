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
    public class GuestManager : IGuestService
    {
        private readonly IGuestRepository _guestRepository;

        public GuestManager(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public void TAdd(Guest t)
        {
            _guestRepository.Add(t);
        }

        public void TDelete(Guest t)
        {
            _guestRepository.Delete(t);
        }

        public Guest TGetByID(int id)
        {
           return _guestRepository.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _guestRepository.GetList();
        }

        public void TUpdate(Guest t)
        {
           _guestRepository.Update(t);
        }
    }
}
