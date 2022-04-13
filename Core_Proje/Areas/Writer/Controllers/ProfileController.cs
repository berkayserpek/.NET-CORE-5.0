using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateVM userUpdateVM = new UserUpdateVM();
            userUpdateVM.Name = values.Name;
            userUpdateVM.Surname = values.Surname;
            userUpdateVM.ImageURL = values.ImageURL;
            return View(userUpdateVM);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserUpdateVM userUpdateVM)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userUpdateVM.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userUpdateVM.Image.FileName);
                var imageName = (Guid.NewGuid() + extension);
                var saveLocation = resource + "/wwwroot/Uploads/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await userUpdateVM.Image.CopyToAsync(stream);
                values.ImageURL= imageName;
            }
            values.Name = userUpdateVM.Name;
            values.Surname = userUpdateVM.Surname;
            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
