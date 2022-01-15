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

            #region Users
            builder.Entity<User>().HasData(new User()
            {
                Id = 1,
                IsActive = true,
                FirstName = "Mohammad Hassan",
                LastName = "Khanipour",
                Email = "mhkhk@outlook.com",
                Age = 23,
                City = "Tehran",
                PhoneNumber = "09190777620",
                Password = "123",
                Street = "Jeyhun"
            });

            builder.Entity<User>().HasData(new User()
            {
                Id = 2,
                IsActive = true,
                FirstName = "Hossein",
                LastName = "Kargar",
                Email = "h.kargar71@gmail.com",
                Age = 29,
                City = "Shiraz",
                PhoneNumber = "09357105475",
                Password = "456",
                Street = "Shams"
            });

            builder.Entity<User>().HasData(new User()
            {
                Id = 3,
                IsActive = true,
                FirstName = "Mehran",
                LastName = "Zeidi",
                Email = "zeidimehran@gmail.com",
                Age = 23,
                City = "Pardis",
                PhoneNumber = "09386716209",
                Password = "789",
                Street = "Mirzaee"
            });

            builder.Entity<User>().HasData(new User()
            {
                Id = 4,
                IsActive = true,
                FirstName = "Mehdi",
                LastName = "Naderi",
                Email = "mehdinaderi@gmail.com",
                Age = 22,
                City = "Tehran",
                PhoneNumber = "09225129985",
                Password = "135",
                Street = "Piruzi"
            });
            #endregion

            #region Pets
            builder.Entity<Pet>().HasData(new Pet()
            {
                Id = 1,
                IsActive = true,
                City = "Tehran",
                Age = 2,
                Price = "100",
                Name = "Stanley",
                UserId = 1,
                Description = "Playful and Lazy at the same time!",
                Breed = "Husky",
                Gender = Gender.Male,
                Category = Category.Dog,
                DateAdded = DateTime.Now,
                ImageAddress = "https://barkingroyalty.com/wp-content/uploads/2016/02/Alaskan-Malamutes.jpg"
            });

            builder.Entity<Pet>().HasData(new Pet()
            {
                Id = 2,
                IsActive = true,
                City = "Tehran",
                Age = 7,
                Price = "0",
                Name = "Jackey",
                UserId = 1,
                Description = "A *Very* polite gentleman",
                Breed = "Catahoula Leopard",
                Gender = Gender.Male,
                Category = Category.Dog,
                DateAdded = DateTime.Now,
                ImageAddress = "https://barkingroyalty.com/wp-content/uploads/2021/09/catahoula-leopard-dog.jpg"
            });

            builder.Entity<Pet>().HasData(new Pet()
            {
                Id = 3,
                IsActive = true,
                City = "Pardis",
                Age = 2,
                Price = "2000",
                Name = "Snufkin",
                UserId = 3,
                Description = "Snufkin is an affectionate, friendly lady who enjoys the quieter life (who doesn't?).",
                Breed = "Domestic Medium-hair",
                Gender = Gender.Female,
                Category = Category.Cat,
                DateAdded = DateTime.Now,
                ImageAddress = "https://www.battersea.org.uk/sites/default/files/animal_images/00P8e000001EdwGEAS.jpeg"
            });

            builder.Entity<Pet>().HasData(new Pet()
            {
                Id = 4,
                IsActive = true,
                City = "Shiraz",
                Age = 2,
                Price = "2000",
                Name = "Maisie",
                UserId = 2,
                Description = "Maisie is a young Bull breed full of energy and affection who is looking for a family who have experience with high energy dogs that require time, patience, and dedication towards their training. She is still developing and learning but has picked up some fantastic skills during her stay at Battersea Old Windsor. She has responded brilliantly to clicker training and this is being used to help her be a little calmer around other dogs.",
                Breed = "Mastiff: Bull",
                Gender = Gender.Female,
                Category = Category.Dog,
                DateAdded = DateTime.Now,
                ImageAddress = "https://www.battersea.org.uk/sites/default/files/animal_images/00P8e000001EdbrEAC.jpeg"
            });
            #endregion
        }
    }
}
