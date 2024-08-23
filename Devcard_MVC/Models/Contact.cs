using System.ComponentModel.DataAnnotations;

namespace Devcard_MVC.Models
{
	public class Contact
	{
		[Required(ErrorMessage = "این فیلد اجباری است")]
		[MinLength(3 , ErrorMessage ="حداقل طول نام 3 کاراکتر می باشد")]
		[MaxLength(100 , ErrorMessage = "حداکثر طول نام 100 کاراکتر می باشد")]
		public string Name {  get; set; }
		
		[Required(ErrorMessage = "این فیلد اجباری است")]
		[EmailAddress]
		public string Email { get; set; }
		public string Message { get; set; }
		public string service { get; set; }
	}
}
