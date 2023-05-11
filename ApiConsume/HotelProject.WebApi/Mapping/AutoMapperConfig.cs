using AutoMapper;
using HotelProject.DTOLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {

        // Bı sınıf Dto sınıfdaki propertiler ile Entity sınıfındaki propertiler eşleşiyor. Yani kısaca Dto sınıfında yaptığımız koşullar Entity sınıfındakilerle birleşiyor.

        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap(); // Üstekinin kısa yolu.
        }
    }
}
