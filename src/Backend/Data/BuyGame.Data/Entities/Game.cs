using BuyGame.Data.Entities.Abstract;

namespace BuyGame.Data.Entities;

public record Game : EntityBase
{
    public string Name { get; set; }
    public Issuer Issuer { get; set; }
    public Developer Developer { get; set; }
    public List<Review> Reviews { get; set; }
    public DateTime CreationDate { get; set; }
    public decimal Price { get; set; }
    public int Discount { get; set; }
    public string Description { get; set; }

    public Game(string name, Issuer issuer, Developer developer, List<Review> reviews, DateTime dateTime
        ,decimal price, int discount, string description)
    {
        Name = name;
        Issuer = issuer;
        Developer = developer;
        Reviews = reviews;
        CreationDate = dateTime;
        Price = price;
        Discount = discount;
        Description = description;
    }

    public Game()
    {

    }
}
