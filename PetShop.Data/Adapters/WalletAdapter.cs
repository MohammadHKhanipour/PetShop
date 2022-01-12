namespace PetShop.Data.Adapters
{
    public class WalletAdapter
    {
        public WalletDto GetDto(Wallet model)
        {
            if (model == null)
                return null;
            return new WalletDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Balance = model.Balance,
                UserId = model.UserId
            };
        }

        public IEnumerable<WalletDto> GetDtos(List<Wallet> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Wallet GetModel(WalletDto dto)
        {
            if (dto == null)
                return null;
            return new Wallet()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Balance = dto.Balance,
                UserId = dto.UserId
            };
        }

        public IEnumerable<Wallet> GetModels(List<WalletDto> dtos)
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
