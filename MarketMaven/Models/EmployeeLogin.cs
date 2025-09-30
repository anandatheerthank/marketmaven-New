using System.ComponentModel.DataAnnotations;

namespace MarketMaven.Models
{
    public class EmployeeLogin
    {
        [Required(ErrorMessage = "Please enter the email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
