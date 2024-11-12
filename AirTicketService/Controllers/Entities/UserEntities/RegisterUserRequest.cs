using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace AirTicketService.Controllers.Entities.UserEntities;

public class RegisterUserRequest : IValidatableObject
{
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public int RoleId { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var errors = new List<ValidationResult>();

        if (!Regex.IsMatch(Email, @"\w+@\w+[.]\w+"))
            errors.Add(new ValidationResult("Invalid email"));

        if (!Regex.IsMatch(Name, @"[A-Z][a-z]+"))
            errors.Add(new ValidationResult("Name contains invalid symbols"));

        if (!Regex.IsMatch(Surname, @"[A-Z][a-z]+"))
            errors.Add(new ValidationResult("ValidationResult contains invalid symbols"));

        if (Patronymic != null && !Regex.IsMatch(Patronymic, @"[A-Z][a-z]+"))
            errors.Add(new ValidationResult("Patronymic contains invalid symbols"));

        return errors;
    }

    public ValidationResult Validate2(ValidationContext validationContext)
    {
        var errorMessages = new StringBuilder();
        var errorFiledNames = new List<string>();

        if (!Regex.IsMatch(Email, @"\w+@\w+[.]\w+"))
        {
            errorFiledNames.Add("Email");
            errorMessages.AppendLine("Invalid email");
        }

        if (!Regex.IsMatch(Name, @"[A-Z][a-z]+"))
        {
            errorFiledNames.Add("Name");
            errorMessages.AppendLine("Name contains invalid symbols");
        }

        if (!Regex.IsMatch(Surname, @"[A-Z][a-z]+"))
        {
            errorFiledNames.Add("Surname");
            errorMessages.AppendLine("ValidationResult contains invalid symbols");
        }

        if (Patronymic != null && !Regex.IsMatch(Patronymic, @"[A-Z][a-z]+"))
        {
            errorFiledNames.Add("Patronymic");
            errorMessages.AppendLine("Patronymic contains invalid symbols");
        }

        var errors = new ValidationResult(errorMessages.ToString(),errorFiledNames);
        return errors;
    }
}