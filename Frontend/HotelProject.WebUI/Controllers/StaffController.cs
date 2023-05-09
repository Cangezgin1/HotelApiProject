﻿using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller 
    {

        private readonly IHttpClientFactory _httpClientFactory; // IHttpClientFactory örneği, uygulamanın diğer web hizmetlerine (API'ler veya diğer web siteleri gibi) HTTP isteklerinde bulunmasını sağlar.

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        { 
            var client = _httpClientFactory.CreateClient();  // İstemci oluşturduk
            var responseMessage = await client.GetAsync("http://localhost:57222/api/Staff"); // İstekte bulunduğum adres
            if (responseMessage.IsSuccessStatusCode) // başarılı durum kodu dönerse
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync(); // veriyi jsondata ya atadım
                var values = JsonConvert.DeserializeObject<List<StaffViewModal>>(jsondata); // veriyi Deserialize ederek tabloda gösterebilecek formata dönüştürdük.
                return View(values);
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult AddStaff() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model); // Modeli json formatına dönüştürüyoruz.
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json"); // Bu satır, jsonData dizesini UTF-8 kodlamasında bir JSON içeriği olarak temsil eden bir StringContent nesnesi oluşturur. Bu nesne, HTTP isteği mesaj gövdesi olarak kullanılabilir.
            var responseMessage = await client.PostAsync("http://localhost:57222/api/Staff",stringContent); // 
            if (responseMessage.IsSuccessStatusCode)
                return RedirectToAction("Index");
            return View();
        }
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:57222/api/Staff?id={id}");
            if (responseMessage.IsSuccessStatusCode)
                return RedirectToAction("Index");
            return View();
        }

    }
}