using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginVM
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz")]
        public string UserName { get; set; }
        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Parola giriniz")]
        public string Password { get; set; }
    }
}
