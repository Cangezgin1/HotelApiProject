using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DTOLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }




        [HttpGet]
        public IActionResult Index() 
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.TInsert(values);
            return Ok();
        }


    }
}
          