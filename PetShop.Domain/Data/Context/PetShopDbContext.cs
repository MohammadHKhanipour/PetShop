namespace PetShop.Domain.Data.Context
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
        {
        }

        public DbSet<Pet>? Pets { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
