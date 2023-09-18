using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="Must nter your name!!!")]
		[MinLength(3)]
		[MaxLength(50)]
		public string Name {  get; set; }
		[EmailAddress(ErrorMessage ="This is not correct pattern for email")]
		public string Email	 { get; set; }
		public string Sevice { get; set; }
		public string Message { get; set; }
		public SelectList Services { get; set; }
	}
}
