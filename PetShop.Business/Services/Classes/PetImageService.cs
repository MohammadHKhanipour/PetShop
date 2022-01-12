namespace PetShop.Business.Services.Classes
{
    public class PetImageService : DomainService<PetImage, PetImageDto>, IPetImageService
    {
        public PetImageService(IQueryRepository<PetImage> queryRepository, ICommandRepository<PetImage> commandRepository, IBaseAdapter<PetImage, PetImageDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }
    }
}
