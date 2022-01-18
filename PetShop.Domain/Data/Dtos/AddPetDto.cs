using System.ComponentModel.DataAnnotations;

namespace PetShop.Domain.Data.Dtos
{
	public class AddPetDto
	{
		[Required(ErrorMessage = "Must be completed")]
		public Category Category { get; set; }
		[Required(ErrorMessage = "Must be completed")]
		public string Breed { get; set; } = string.Empty;
		[Required(ErrorMessage = "Must be completed")]
		public Gender Gender { get; set; }
		[Required(ErrorMessage = "Must be completed")]
		public string Name { get; set; } = string.Empty;
		[Required(ErrorMessage = "Must be completed")]
		public int Age { get; set; }
		[Required(ErrorMessage = "Must be completed")]
		public string Price { get; set; } = string.Empty;
		[Required(ErrorMessage = "Must be completed")]
		public string City { get; set; } = string.Empty;
		public string? Description { get; set; }
		public string? ImageAddress { get; set; }
	}
}
