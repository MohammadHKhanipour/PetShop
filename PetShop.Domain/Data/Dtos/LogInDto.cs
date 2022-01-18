using System.ComponentModel.DataAnnotations;

namespace PetShop.Domain.Data.Dtos
{
	public class LogInDto
	{
		[Required]
		public string UserName { get; set; }
		[Required]
		public string Password { get; set; }
		public bool RememberMe { get; set; } = false;
	}
}
