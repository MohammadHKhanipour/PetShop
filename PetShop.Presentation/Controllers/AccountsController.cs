using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Data.Dtos;
using PetShop.Domain.Data.Models;
using PetShop.Domain.Services.Interfaces;

namespace PetShop.Presentation.Controllers
{
    public class AccountsController : Controller
    {
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
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Age = dto.Age,
                City = dto.City,
                Street = dto.Street,
                PhoneNumber = dto.PhoneNumber,
                UserName = dto.PhoneNumber
            };

            return View(dto);
        }
    }
}
