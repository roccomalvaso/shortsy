using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Shortly_Client.Helpers.Validators;

public class CustomEmailValidator : ValidationAttribute
{
    private const string _emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$";

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return ValidationResult.Success;
        }

        string emailAddress = value.ToString();

        if (Regex.IsMatch(emailAddress, _emailPattern))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage);
    }
}