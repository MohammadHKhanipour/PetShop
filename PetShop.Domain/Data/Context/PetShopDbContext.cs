using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PetShop.Domain.Data.Context
{
	public class PetShopDbContext : IdentityDbContext<User, IdentityRole, string>
	{
		public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
		{
		}

		public DbSet<Pet>? Pets { get; set; }



		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			#region Role
			builder.Entity<IdentityRole>().HasData(
				new IdentityRole
				{
					Id = Guid.NewGuid().ToString(),
					Name = "Admin",
					NormalizedName = "ADMIN"
				},
				new IdentityRole
				{
					Id = Guid.NewGuid().ToString(),
					Name = "User",
					NormalizedName = "USER"
				}
			);
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
