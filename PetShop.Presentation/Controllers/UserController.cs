using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Services.Interfaces;

namespace PetShop.Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var test = await _userService.GetAsync();

            return Ok(test);
        }
    }
}
