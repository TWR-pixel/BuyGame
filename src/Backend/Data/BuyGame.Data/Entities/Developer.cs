using BuyGame.Data.Entities.Abstract;

namespace BuyGame.Data.Entities;

public record Developer : AbstractUser
{
    public DateTime CreationTime { get; set; }

    public Developer()
    {
    }
}
