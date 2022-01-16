using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Services.Interfaces;

namespace PetShop.Presentation.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
    }
}
