namespace Mediator;

public class Bidder : IBidder
{
    private readonly string name;
    private readonly IMediator auctionMediator;
    public Bidder(string name, IMediator auctionMediator)
    {
        this.name = name;
        this.auctionMediator = auctionMediator;
        auctionMediator.RegisterBidder(this);
    }
    public void PlaceBid(int amount)
    {
        auctionMediator.PlaceBid(this, amount);
    }

    public void GetBidNotification(int bidAmount)
    {
        Console.WriteLine($"{name} received a notification of a new bid: {bidAmount}");
    }

    public string GetName()
    {
        return name;
    }
}