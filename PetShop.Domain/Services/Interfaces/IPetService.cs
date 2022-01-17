namespace PetShop.Domain.Services.Interfaces
{
    public interface IPetService : IDomainService<Pet, PetDto>
    {
        public Task<List<PetDto>> GetAllByCityName(string city);
        public Task<List<PetDto>> GetAllByUserCity(User user);
        public Task<List<PetDto>> GetAllByUserId(string id);
        Task<List<PetDto>> GetAsync(Category? category = null, string searchValue = "");
    }
}
