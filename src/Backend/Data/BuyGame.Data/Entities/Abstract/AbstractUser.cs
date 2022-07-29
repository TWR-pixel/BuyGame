using System.ComponentModel.DataAnnotations;

namespace BuyGame.Data.Entities.Abstract;

public abstract record AbstractUser : EntityBase
{
    public string? Name { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? PasswordHash { get; set; }
}
