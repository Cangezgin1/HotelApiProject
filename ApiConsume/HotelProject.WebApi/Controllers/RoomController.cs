using HotelProject.BusinessLayer.Abstract;
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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService RoomService)
        {
            _roomService = RoomService;
        }

        [HttpGet]
        public IActionResult RoomList() // Tüm Room ların gelmesi için
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room) // Room eklemek için
        {
            _roomService.TInsert(room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id) // Room silmek için
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room) // Room güncelleme için
        {
            _roomService.TUpdate(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id) // id'ye göre Room getirmek için
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }

    }
}
