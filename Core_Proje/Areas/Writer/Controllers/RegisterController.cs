using Core_Proje.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    public class RegisterController : Controller
    {
        [Area("Writer")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserRegisterVM userRegisterVM)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}
