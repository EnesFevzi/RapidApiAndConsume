﻿
using AutoMapper;
using HotelProject.DtoLayer.Dtos.AboutDto;
using HotelProject.DtoLayer.Dtos.GuestDto;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
   
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            CreateMap<AboutAddDto, About>();
            CreateMap<About, AboutAddDto>();

            CreateMap<AddGuestDto, Guest>();
            CreateMap<Guest, AddGuestDto>();

            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
        }
    }
}
