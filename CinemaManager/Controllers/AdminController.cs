using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CinemaManager.ApplicationLogic.Services;
using CinemaManager.Models;
using CinemaManager.Models.Admins;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CinemaManager.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly AdminService adminService;
        private readonly UserManager<IdentityUser> userManager;

        public AdminController(UserManager<IdentityUser> userManager, AdminService adminService)
        {
            this.adminService = adminService;
            this.userManager = userManager;
        }
        
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            return PartialView("_AddFilm", new NewFilmViewModel());
        }

        [HttpPost]
        public IActionResult AddFilm([FromForm]NewFilmViewModel modelData)
        {
            string image = "";

            if (ModelState.IsValid || modelData == null)
                return RedirectToAction("Index", "Home");
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    modelData.Image.CopyTo(memoryStream);

                    image = Convert.ToBase64String(memoryStream.ToArray());
                }

                adminService.AddFilm(modelData.Name, modelData.Description, modelData.ReleaseDate,
                    modelData.Duration, modelData.Director, image);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}