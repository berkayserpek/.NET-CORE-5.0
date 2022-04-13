using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = value.Name + " " + value.Surname;

            //weather api
            string api = "77952cc031594a8bdddf06c7380d3051";
            string connection = "https://api.weatherapi.com/v1/current.xml?key=e25a908663a24fb4b33183842221304&q=Eregli&aqi=yes";
            XDocument document = XDocument.Load(connection);
            ViewBag.weather = document.Descendants("temp_c").ElementAt(0).Value;
            ViewBag.City = document.Descendants("name").ElementAt(0).Value;
            ViewBag.Region = document.Descendants("region").ElementAt(0).Value;

            //Statistics
            Context c = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}

    //https://api.openweathermap.org/data/2.5/weather?q=istanbul&appid=77952cc031594a8bdddf06c7380d3051
    
