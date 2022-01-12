namespace PetShop.Business.Services.Classes
{
    public class WalletService : DomainService<Wallet, WalletDto>, IWalletService
    {
        public WalletService(IQueryRepository<Wallet> queryRepository, ICommandRepository<Wallet> commandRepository, IBaseAdapter<Wallet, WalletDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }
    }
}
