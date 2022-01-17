using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Data.Enums;
using PetShop.Domain.Services.Interfaces;
using PetShop.Presentation.Models;
using System.Diagnostics;

namespace PetShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPetService _petService;

        public HomeController(IPetService petService)
        {
            _petService = petService;
        }

        public async Task<IActionResult> Index(Category? category = null, string searchValue = "")
        {
            ViewBag.Pets = await _petService.GetAsync(category,searchValue);
            return View();
        }
    }
}

//  var user = await _userManager.GetUserAsync(User);