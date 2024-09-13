using System.ComponentModel.DataAnnotations;
using Shortly_Client.Helpers.Validators;

namespace Shortly_Client.Data.ViewModels;

public class RegisterVM
{
    [Required(ErrorMessage = "Fullname is required")]
    public string FullName { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [CustomEmailValidator(ErrorMessage = "Email is not valid")]
    public string EmailAddress { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [MinLength(7,ErrorMessage = "Password must be at least 7 characters")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Confirm Password is required")]
    [Compare("Password",ErrorMessage = "Password do not match")]
    public string ConfirmPassword { get; set; }
}