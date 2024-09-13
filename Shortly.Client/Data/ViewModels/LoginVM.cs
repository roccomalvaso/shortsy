using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Shortly_Client.Helpers.Validators;

namespace Shortly_Client.Data.ViewModels;

public class LoginVM
{
    [Required(ErrorMessage = "Email Required")]
    [CustomEmailValidator(ErrorMessage = "Email is not valid")]
    public string EmailAddress { get; set; }
    [Required(ErrorMessage = "Password Required")]
    [MinLength(7, ErrorMessage = "Password must be at least 7 characters")]
    public string Password { get; set; }
}