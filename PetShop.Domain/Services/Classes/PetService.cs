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
    }
}
