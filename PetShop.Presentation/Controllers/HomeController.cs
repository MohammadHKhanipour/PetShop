using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Data.Enums;
using PetShop.Domain.Data.Models;
using PetShop.Domain.Services.Interfaces;

namespace PetShop.Presentation.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPetService _petService;
		private readonly UserManager<User> _userManager;

		public HomeController(IPetService petService, UserManager<User> userManager)
		{
			_petService = petService;
			_userManager = userManager;
		}

		public async Task<IActionResult> Index(Category? category = null, string searchValue = "", string cityValue = "", bool userCityPets = false)
		{
			if (userCityPets)
			{
				var user = await _userManager.GetUserAsync(User);
				if (user != null)
					cityValue = user.City;
			}
			ViewBag.Pets = await _petService.GetAsync(category, searchValue, cityValue);
			return View();
		}
	}
}
