namespace PetShop.Business.Businesses.Classes
{
    public class UserBusiness : DomainBusiness<User, UserDto>, IUserBusiness
    {
        public UserBusiness(IDomainService<User, UserDto> domainService, IBaseAdapter<User, UserDto> baseAdapter)
            : base(domainService, baseAdapter)
        {
        }
    }
}
