using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Data.Dtos;
using PetShop.Domain.Data.Models;

namespace PetShop.Presentation.Controllers
{
	public class AccountsController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public AccountsController(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignUp(SignUpDto dto)
		{
			if (!ModelState.IsValid)
				return View(dto);

			var user = new User()
			{
				IsActive = true,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Email = dto.Email,
				Age = dto.Age,
				City = dto.City,
				Street = dto.Street,
				PhoneNumber = dto.PhoneNumber,
				UserName = dto.PhoneNumber
			};

			var result = await _userManager.CreateAsync(user, dto.Password);
			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, "User");
				return RedirectToAction("LogIn");
			}

			ViewBag.Error = "Sign Up Failed";
			return View(dto);
		}

		[HttpGet]
		public IActionResult LogIn()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> LogIn(LogInDto dto)
		{
			if (!ModelState.IsValid)
				return View(dto);

			var result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, true);
			if (result.Succeeded)
				return RedirectToAction("Index", "Home");

			ViewBag.Error = "LogIn Failed";
			return View(dto);
		}

		[HttpGet]
		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
