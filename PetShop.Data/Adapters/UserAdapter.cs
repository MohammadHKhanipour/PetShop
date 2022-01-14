namespace PetShop.Data.Adapters
{
    public class UserAdapter : IBaseAdapter<User, UserDto>
    {
        public UserDto GetDto(User model)
        {
            if (model == null)
                return null;
            return new UserDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                City = model.City,
                Street = model.Street
            };
        }

        public IEnumerable<UserDto> GetDtos(List<User> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public User GetModel(UserDto dto)
        {
            if (dto == null)
                return null;
            return new User()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Age = dto.Age,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                City = dto.City,
                Street= dto.Street
            };
        }

        public IEnumerable<User> GetModels(List<UserDto> dtos)
        {
            foreach (var item in dtos)
            {
                if (item == null)
                    continue;
                yield return GetModel(item);
            }
        }
    }
}
