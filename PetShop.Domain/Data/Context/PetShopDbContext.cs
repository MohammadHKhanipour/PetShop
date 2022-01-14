namespace PetShop.Domain.Data.Context
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
        {
        }

        public DbSet<Pet>? Pets { get; set; }
        public DbSet<User>? Users { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(new User()
            {
                Id = 1,
                IsActive = true,
                FirstName = "Mamad",
                LastName = "Khani",
                Email = "mamad@mamad.mamad",
                Age = 23,
                City = "Tehran",
                PhoneNumber = "09190777620",
                Password = "123",
                Street = "Jeyhun"
            });

            builder.Entity<Pet>().HasData(new Pet()
            {
                Id = 1,
                IsActive = true,
                City = "Tehran",
                Age = 2,
                Price = "100",
                Name = "Stanley",
                UserId = 1,
                Description = "A good boy",
                Breed = "Husky",
                Category = Category.Dog,
                DateAdded = DateTime.Now,
                ImageAddress = "https://barkingroyalty.com/wp-content/uploads/2016/02/Alaskan-Malamutes.jpg"
            });
        }
    }
}
