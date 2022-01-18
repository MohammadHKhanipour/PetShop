using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Data.Models;
using PetShop.Domain.Services.Interfaces;

namespace PetShop.Presentation.Controllers
{
	[Authorize]
	public class UserController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly IPetService _petService;

		public UserController(UserManager<User> userManager, IPetService petService)
		{
			_userManager = userManager;
			_petService = petService;
		}

		public async Task<IActionResult> Profile(string message = "")
		{
			var user = await _userManager.GetUserAsync(User);
			ViewBag.UserPets = await _petService.GetAllByUserId(user.Id);
			if (!string.IsNullOrEmpty(message))
				ViewBag.Error = message;
			return View(user);
		}
	}
}
