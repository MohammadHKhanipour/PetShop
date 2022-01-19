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

        [HttpGet]
        public async Task<IActionResult> EditProfile(string id)
        {
            User user = null;
            if (!string.IsNullOrEmpty(id))
                user = await _userManager.FindByIdAsync(id);

            else
                user = await _userManager.GetUserAsync(User);

            EditDto dto = new EditDto()
            {
                Id = user.Id,
                Age = user.Age,
                City = user.City,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Street = user.Street,
            };
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(EditDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var user = await _userManager.FindByIdAsync(dto.Id);

            if (user != null)
            {
                user.Street = dto.Street;
                user.City = dto.City;
                user.Email = dto.Email;
                user.FirstName = dto.FirstName;
                user.LastName = dto.LastName;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    var currentUser = await _userManager.GetUserAsync(User);
                    var role = await _userManager.IsInRoleAsync(currentUser, "Admin");

                    if (role)
                        return RedirectToAction("ViewUsers", "Admin");

                    return RedirectToAction("Profile", "User");
                }
            }


            return RedirectToAction("Profile", "User", new { message = "Edit Info Failed" });
        }
    }
}
