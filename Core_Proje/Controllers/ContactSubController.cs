using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class ContactSubController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ModifiedDate = DateTime.Now;
            contactManager.TUpdate(p);
            return RedirectToAction("Index", "Default");
        }
    }
}
