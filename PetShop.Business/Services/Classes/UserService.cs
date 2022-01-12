namespace PetShop.Business.Services.Classes
{
    public class UserService : DomainService<User, UserDto>, IUserService
    {
        public UserService(IQueryRepository<User> queryRepository, ICommandRepository<User> commandRepository, IBaseAdapter<User, UserDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }
    }
}
