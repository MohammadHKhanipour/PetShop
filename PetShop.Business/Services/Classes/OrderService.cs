namespace PetShop.Business.Services.Classes
{
    public class OrderService : DomainService<Order, OrderDto>, IOrderService
    {
        public OrderService(IQueryRepository<Order> queryRepository, ICommandRepository<Order> commandRepository, IBaseAdapter<Order, OrderDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }
    }
}
