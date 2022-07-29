using BuyGame.Data.Entities.Abstract;

namespace BuyGame.Data.Entities;

public record Cart : EntityBase
{
    public List<Game>? Games { get; set; }
}
