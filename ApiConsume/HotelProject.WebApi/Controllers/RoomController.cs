using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
		public IActionResult RoomList()
		{
			var values = _roomService.TGetList();
			return Ok(values);
		}
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.TAdd(values);
            return Ok();
        }
        [HttpDelete("{id}")]
		public IActionResult DeleteRoom(int id)
		{
			var values = _roomService.TGetByID(id);
			_roomService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var values = _roomService.TGetByID(id);
			return Ok(values);
		}
	}
}
