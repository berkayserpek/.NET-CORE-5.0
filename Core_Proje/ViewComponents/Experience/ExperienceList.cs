using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager _experienceManager = new ExperienceManager(new EFExperienceDAL());
        public IViewComponentResult Invoke()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }
    }
}
