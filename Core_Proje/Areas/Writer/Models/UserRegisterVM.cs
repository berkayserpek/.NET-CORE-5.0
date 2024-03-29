﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterVM
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Fotoğraf Yolu Girin")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Tekrar Şifre Girin")]
        [Compare("Password",ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Girin")]
        public string Mail { get; set; }
    }
}
