using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.Service;
using HotelProject.WebUI.Models.Booking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        protected IBookingService _bookingService;

        public BookingController(IHttpClientFactory httpClientFactory, IBookingService bookingService)
        {
            _httpClientFactory = httpClientFactory;
            _bookingService = bookingService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7024/api/Booking", stringContent);
            return RedirectToAction("Index", "Default");
        }
        //[HttpPost]
        //public async Task< PartialViewResult> AddBooking(Booking booking)
        //{
        //       booking.Status = "Onay Bekliyor";
        //        _bookingService.TAdd(booking);
        //        return PartialView();
        //}
    }
}
