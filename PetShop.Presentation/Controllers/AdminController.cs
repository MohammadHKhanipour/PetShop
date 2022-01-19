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
            ViewBag.UserCount = _userManager.Users.ToList().Count;
            ViewBag.PetsCount = await _petService.GetCountAsync();
            ViewBag.PetsWorth = await _petService.GetPricesSum();
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
