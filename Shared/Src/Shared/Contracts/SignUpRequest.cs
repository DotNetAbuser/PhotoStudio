namespace Shared.Contracts;

public class SignUpRequest
{
    [Required(ErrorMessage = "Поле фамилия не должно быть пустым!")] public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Поле имя не должно быть пустым!")] public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    [Required(ErrorMessage = "Поле эл. почта не должно быть пустым!")] [EmailAddress(ErrorMessage = "Поле не соответсвует эл. почте!")] public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "Поле номер телефона не должно быть пустым!")] [Phone(ErrorMessage = "Поле не соответсвует номеру телефона!")] public string PhoneNumber { get; set; } = string.Empty;
    [Required(ErrorMessage = "Поле пароль не должно быть пустым!")] public string Password { get; set; } = string.Empty;    
}