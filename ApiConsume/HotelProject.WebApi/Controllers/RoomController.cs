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
        [HttpGet]
        public IActionResult RoomList() // Tüm room ların gelmesi için
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRoom() // Room eklemek için
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom() // Room silmek için
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom() // Room güncelleme için
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom() // id'ye göre room getirmek için
        {
            return Ok();
        }

    }
}
