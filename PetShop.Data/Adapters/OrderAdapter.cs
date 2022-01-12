namespace PetShop.Data.Adapters
{
    public class OrderAdapter : IBaseAdapter<Order, OrderDto>
    {
        public OrderDto GetDto(Order model)
        {
            if (model == null)
                return null;
            return new OrderDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Date = model.Date,
                IsFinal = model.IsFinal,
                Total = model.Total,
                PetId = model.PetId,
                UserId = model.UserId
            };
        }

        public IEnumerable<OrderDto> GetDtos(List<Order> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Order GetModel(OrderDto dto)
        {
            if (dto == null)
                return null;
            return new Order()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Date = dto.Date,
                IsFinal = dto.IsFinal,
                Total = dto.Total,
                PetId = dto.PetId,
                UserId = dto.UserId
            };
        }

        public IEnumerable<Order> GetModels(List<OrderDto> dtos)
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
