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

        //public async Task<IActionResult> Test()
        //{
        //    var model = new User()
        //    {
        //        IsActive = true,
        //        FirstName = "Hossein",
        //        LastName = "Kargar",
        //        Age = 29,
        //        PhoneNumber = "09357105475",
        //        Email = "hossein@hossein.hossein",
        //        City = "Shiraz",
        //        Street = "Shams",
        //        Password = "456"
        //    };

        //    var result = await _userService.AddAsync(model);

        //    return Ok(result);
        //}
    }
}
