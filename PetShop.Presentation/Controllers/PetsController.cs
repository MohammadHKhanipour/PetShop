namespace PetShop.Presentation.Controllers
{
    [Authorize]
    public class PetsController : Controller
    {
        private readonly IPetService _petService;
        private readonly UserManager<User> _userManager;

        public PetsController(IPetService petService, UserManager<User> userManager)
        {
            _petService = petService;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Profile(int id)
        {
            var pet = await _petService.GetAsync(id);
            var petOwner = await _userManager.FindByIdAsync(pet.UserId);
            if (petOwner != null)
                ViewBag.UserPhone = petOwner.PhoneNumber;
            return View(pet);
        }

        [HttpGet]
        public IActionResult AddPet()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPet(AddPetDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);
            var user = await _userManager.GetUserAsync(User);
            var pet = new PetDto()
            {
                IsActive = true,
                Name = dto.Name,
                Breed = dto.Breed,
                Age = dto.Age,
                Category = dto.Category,
                City = dto.City,
                Gender = dto.Gender,
                Description = dto.Description,
                Price = dto.Price,
                UserId = user.Id,
                DateAdded = DateTime.Now
            };

            if (string.IsNullOrEmpty(dto.ImageAddress))
                pet.ImageAddress = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/No_image_available_600_x_450.svg/1200px-No_image_available_600_x_450.svg.png";
            else
                pet.ImageAddress = dto.ImageAddress;

            var result = await _petService.AddAsync(pet);
            if (result)
                return RedirectToAction("Profile", "User");

            return RedirectToAction("Profile", "User", new { message = "Adding Pet Failed!" });
        }

        public async Task<IActionResult> DeletePet(int id)
        {
            var result = await _petService.DeleteAsync(id);

            if (result)
            {
                var user = await _userManager.GetUserAsync(User);
                var role = await _userManager.IsInRoleAsync(user, "Admin");

                if (role)
                    return RedirectToAction("ViewPets", "Admin");

                return RedirectToAction("Profile", "User");
            }

            return RedirectToAction("Profile", "User", new { message = "Delete Failed!" });
        }

        [HttpGet]
        public async Task<IActionResult> EditPet(int id)
        {
            var pet = await _petService.GetAsync(id);
            return View(pet);
        }

        [HttpPost]
        public async Task<IActionResult> EditPet(PetDto dto)
        {
            var result = await _petService.UpdateAsync(dto);

            if (result)
            {
                var user = await _userManager.GetUserAsync(User);
                var role = await _userManager.IsInRoleAsync(user, "Admin");

                if (role)
                    return RedirectToAction("ViewPets", "Admin");

                return RedirectToAction("Profile", "User");
            }

            return RedirectToAction("Profile", "User", new { message = "Edit Info Failed" });
        }
    }
}
