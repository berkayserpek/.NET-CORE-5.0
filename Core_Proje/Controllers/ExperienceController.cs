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
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDAL());
        public IActionResult Index()
        {
            ViewBag.v1 = "Tecrübe Listesi";
            ViewBag.v2 = "Tecrübeler";
            ViewBag.v3 = "Tecrübe Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Tecrübe Ekle";
            ViewBag.v2 = "Tecrübeler";
            ViewBag.v3 = "Tecrübe Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.v1 = "Tecrübe Güncelle";
            ViewBag.v2 = "Tecrübeler";
            ViewBag.v3 = "Tecrübe Güncelle";
            var values = experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience p)
        {
            experienceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
