using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı gereklidir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "KullanıcıAdı Alanı gereklidir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı gereklidir.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Alanı gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
