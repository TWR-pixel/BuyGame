using BuyGame.Data.Entities.Abstract;

namespace BuyGame.Data.Entities;

public record Review : EntityBase
{
    public string? Text { get; set; }
}
