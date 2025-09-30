using System.ComponentModel.DataAnnotations;

namespace instagram2.Models.ViewModels;

public class RegisterViewModel
{
    [Required]
    public string Username { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Required]
    public IFormFile Avatar { get; set; }

    public string? Name { get; set; }
    public string? Bio { get; set; }
    public string? Gender { get; set; }

    [Phone]
    public string? PhoneNumber { get; set; }
}