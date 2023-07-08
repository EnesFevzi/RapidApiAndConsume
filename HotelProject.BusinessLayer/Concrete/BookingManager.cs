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
    public class BookingManager : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public void TAdd(Booking t)
        {
            _bookingRepository.Add(t);
        }

        public void TDelete(Booking t)
        {
            _bookingRepository.Delete(t);
        }

        public Booking TGetByID(int id)
        {
            return _bookingRepository.GetByID(id);  
        }

        public List<Booking> TGetList()
        {
            return _bookingRepository.GetList();
        }

        public void TUpdate(Booking t)
        {
            _bookingRepository.Update(t);
        }
    }
}
