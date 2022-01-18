namespace PetShop.Domain.Services.Classes
{
	public class PetService : DomainService<Pet, PetDto>, IPetService
	{
		private readonly IQueryRepository<Pet> _queryRepository;
		private readonly ICommandRepository<Pet> _commandRepository;
		private readonly IBaseAdapter<Pet, PetDto> _baseAdapter;

		public PetService(IQueryRepository<Pet> queryRepository, ICommandRepository<Pet> commandRepository, IBaseAdapter<Pet, PetDto> baseAdapter)
			: base(queryRepository, commandRepository, baseAdapter)
		{
			_queryRepository = queryRepository;
			_commandRepository = commandRepository;
			_baseAdapter = baseAdapter;
		}

		public async Task<List<PetDto>> GetAllByCityName(string city)
		{
			var models = await _queryRepository.GetAsync(x => x.City == city);
			return _baseAdapter.GetDtos(models).ToList();
		}

		public async Task<List<PetDto>> GetAllByUserCity(User user)
		{
			var models = await _queryRepository.GetAsync(x => x.City == user.City);
			return _baseAdapter.GetDtos(models).ToList();
		}

		public async Task<List<PetDto>> GetAllByUserId(string id)
		{
			var models = await _queryRepository.GetAsync(x => x.UserId == id);
			return _baseAdapter.GetDtos(models).ToList();
		}

		public async Task<List<PetDto>> GetAsync(Category? category = null, string searchValue = "", string cityValue = "")
		{
			if (!string.IsNullOrEmpty(cityValue))
				return _baseAdapter.GetDtos(await _queryRepository.GetAsync(x => x.City.ToLower().Contains(cityValue.ToLower()))).ToList();

			if (!string.IsNullOrEmpty(searchValue))
				return _baseAdapter.GetDtos(await _queryRepository.GetAsync(x => x.Breed.ToLower().Contains(searchValue.ToLower()))).ToList();

			var pets = await _queryRepository.GetAsync();
			if (category != null)
				switch (category)
				{
					case Category.Others:
						pets = pets.Where(x => x.Category == Category.Others).ToList();
						break;
					case Category.Dog:
						pets = pets.Where(x => x.Category == Category.Dog).ToList();
						break;
					case Category.Cat:
						pets = pets.Where(x => x.Category == Category.Cat).ToList();
						break;
					case Category.Bird:
						pets = pets.Where(x => x.Category == Category.Bird).ToList();
						break;
					case Category.Reptile:
						pets = pets.Where(x => x.Category == Category.Reptile).ToList();
						break;
					case Category.Mammal:
						pets = pets.Where(x => x.Category == Category.Mammal).ToList();
						break;
					default:
						break;
				}

			return _baseAdapter.GetDtos(pets).ToList();
		}
	}
}
