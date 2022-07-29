using BuyGame.Data.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BuyGame.Data.Entities;

public record Organization : AbstractUser
{
    [Required]
    public DateTime CreationDate { get; set; }


}
