namespace PetShop.Data.Adapters
{
    public class PetImageAdapter : IBaseAdapter<PetImage, PetImageDto>
    {
        public PetImageDto GetDto(PetImage model)
        {
            if (model == null)
                return null;
            return new PetImageDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Num = model.Num,
                IsCover = model.IsCover,
                ImageLink = model.ImageLink,
                PetId = model.PetId
            };
        }

        public IEnumerable<PetImageDto> GetDtos(List<PetImage> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public PetImage GetModel(PetImageDto dto)
        {
            if (dto == null)
                return null;
            return new PetImage()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Num = dto.Num,
                IsCover = dto.IsCover,
                ImageLink = dto.ImageLink,
                PetId = dto.PetId
            };
        }

        public IEnumerable<PetImage> GetModels(List<PetImageDto> dtos)
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
