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
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.weather = document.Descendants("coord").ElementAt(0).Attribute("lon").Value;

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
    
