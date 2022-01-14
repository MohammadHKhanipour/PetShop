using System.Data.Entity;

namespace PetShop.Data.Context
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext() : base("name=PetShopDbContext")
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
