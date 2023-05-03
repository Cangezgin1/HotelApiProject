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
    public class StaffController : ControllerBase
    {
        [HttpGet]
        public IActionResult StaffList() // Tüm Staff ların gelmesi için
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddStaff() // Staff eklemek için
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff() // Staff silmek için
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff() // Staff güncelleme için
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff() // id'ye göre Staff getirmek için
        {
            return Ok();
        }
    }
}
