using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EFWriterUserDAL());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            writerUserManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        //private static List<class0> liste = new List<class0>()
        //{
        //    new class0{ID = 1, AD="Ali"},
        //    new class0{ID = 2, AD="Ayşe"},
        //    new class0{ID = 3, AD="Esra"},
        //    new class0{ID = 4, AD="Ali"},
        //};


    }
    //public class class0
    //{
    //    public int ID { get; set; }
    //    public string AD { get; set; }
    //}
}
