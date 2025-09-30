using System.ComponentModel.DataAnnotations;

namespace MarketMaven.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter the password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter the age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter the contact details")]
        public long Contact { get; set; }
    }
}
