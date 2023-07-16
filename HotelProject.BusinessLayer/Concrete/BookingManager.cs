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

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bookingRepository.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _bookingRepository.BookingStatusChangeApproved2(id);
        }

        public void TBookingStatusChangeApproved3(int id)
        {
            _bookingRepository.BookingStatusChangeApproved3(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingRepository.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
            _bookingRepository.BookingStatusChangeWait(id);
        }

        public void TDelete(Booking t)
        {
            _bookingRepository.Delete(t);
        }

        public int TGetBookingCount()
        {
            return _bookingRepository.GetBookingCount();
        }

        public Booking TGetByID(int id)
        {
            return _bookingRepository.GetByID(id);  
        }

        public List<Booking> TGetList()
        {
            return _bookingRepository.GetList();
        }

        public List<Booking> TLast6Bookings()
        {
           return _bookingRepository.Last6Bookings();
        }

        public void TUpdate(Booking t)
        {
            _bookingRepository.Update(t);
        }
    }
}
