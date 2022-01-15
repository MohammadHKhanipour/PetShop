namespace PetShop.Domain.Services.Interfaces
{
    public interface IPetService : IDomainService<Pet, PetDto>
    {
        public Task<List<PetDto>> GetAllByCityName(string city);
        public Task<List<PetDto>> GetAllByUserCity(User user);
    }
}
