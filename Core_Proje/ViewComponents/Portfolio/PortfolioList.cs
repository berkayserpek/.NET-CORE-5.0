using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager _portfolioManager = new PortfolioManager(new EFPortfolioDAL());
        public IViewComponentResult Invoke()
        {
            var values = _portfolioManager.TGetList();
            return View(values);
        }
    }
}
