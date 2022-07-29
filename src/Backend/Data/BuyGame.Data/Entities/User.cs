using BuyGame.Data.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BuyGame.Data.Entities;

public record User : AbstractUser
{
    [Required]
    public string? Nickname { get; set; }
    public List<Review>? Reviews { get; set; }
    public Cart? Cart { get; set; }


}
