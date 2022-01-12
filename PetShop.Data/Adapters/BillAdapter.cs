namespace PetShop.Data.Adapters
{
    public class BillAdapter : IBaseAdapter<Bill, BillDto>
    {
        public BillDto GetDto(Bill model)
        {
            if (model == null)
                return null;
            return new BillDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Total = model.Total,
                IssueDate = model.IssueDate,
                PaymentState = model.PaymentState,
                PaymentNumber = model.PaymentNumber,
                OrderId = model.OrderId
            };
        }

        public IEnumerable<BillDto> GetDtos(List<Bill> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Bill GetModel(BillDto dto)
        {
            if (dto == null)
                return null;
            return new Bill()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Total = dto.Total,
                IssueDate = dto.IssueDate,
                PaymentState = dto.PaymentState,
                PaymentNumber = dto.PaymentNumber,
                OrderId = dto.OrderId
            };
        }

        public IEnumerable<Bill> GetModels(List<BillDto> dtos)
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
