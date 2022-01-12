namespace PetShop.Data.Adapters
{
    public class PetAdapter : IBaseAdapter<Pet, PetDto>
    {
        public PetDto GetDto(Pet model)
        {
            if (model == null)
                return null;
            return new PetDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Category = model.Category,
                Breed = model.Breed,
                Name = model.Name,
                Age = model.Age,
                Description = model.Description,
                UserId = model.UserId
            };
        }

        public IEnumerable<PetDto> GetDtos(List<Pet> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Pet GetModel(PetDto dto)
        {
            if (dto == null)
                return null;
            return new Pet()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Category = dto.Category,
                Breed = dto.Breed,
                Name = dto.Name,
                Age = dto.Age,
                Description = dto.Description,
                UserId = dto.UserId
            };
        }

        public IEnumerable<Pet> GetModels(List<PetDto> dtos)
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
