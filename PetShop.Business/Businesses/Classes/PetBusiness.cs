namespace PetShop.Business.Businesses.Classes
{
    public class PetBusiness : DomainBusiness<Pet, PetDto>, IPetBusiness
    {
        public PetBusiness(IDomainService<Pet, PetDto> domainService, IBaseAdapter<Pet, PetDto> baseAdapter)
            : base(domainService, baseAdapter)
        {
        }
    }
}
