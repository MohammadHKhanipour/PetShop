namespace PetShop.Business.Services.Classes
{
    public class BillService : DomainService<Bill, BillDto>, IBillService
    {
        public BillService(IQueryRepository<Bill> queryRepository, ICommandRepository<Bill> commandRepository, IBaseAdapter<Bill, BillDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }
    }
}
