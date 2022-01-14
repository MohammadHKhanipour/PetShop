namespace PetShop.Domain.Services.Classes
{
    public class PetService : DomainService<Pet, PetDto>, IPetService
    {
        public PetService(IQueryRepository<Pet> queryRepository, ICommandRepository<Pet> commandRepository, IBaseAdapter<Pet, PetDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }
    }
}
