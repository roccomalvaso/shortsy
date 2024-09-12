using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shortly_Client.Data.ViewModels;

public class LoginVM
{
    [Required(ErrorMessage = "Email Required")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$", ErrorMessage = "Invalid email address")]
    public string EmailAddress { get; set; }
    [Required(ErrorMessage = "Password Required")]
    [MinLength(7, ErrorMessage = "Password must be at least 7 characters")]
    public string Password { get; set; }
}