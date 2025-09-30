using System.ComponentModel.DataAnnotations;

namespace instagram2.Models.ViewModels;

public class LoginViewModel
{
    [Required]
    public string Login { get; set; } // can be username or email

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
}
