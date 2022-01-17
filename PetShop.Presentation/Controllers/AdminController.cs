using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Data.Models;
using PetShop.Domain.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Presentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IPetService _petService;
        private readonly UserManager<User> _userManager;

        public AdminController(IPetService petService, UserManager<User> userManager)
        {
            _petService = petService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Dashboard()
		{
            return View();
		}

        public async Task<IActionResult> ViewPets()
        {
            return View(await _petService.GetAsync());
        }

        public async Task<IActionResult> ViewUsers()
        {
            return View(await _userManager.Users.ToListAsync());
        }

    }
}
