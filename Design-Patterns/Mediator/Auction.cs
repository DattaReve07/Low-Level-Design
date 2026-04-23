namespace Mediator;

public class Auction : IMediator
{
    private readonly List<IBidder> bidders = [];

    public void RegisterBidder(IBidder bidder)
    {
        bidders.Add(bidder);
    }

    public void PlaceBid(IBidder bidder, int amount)
    {
        Console.WriteLine($"{bidder.GetName()} placed a bid of {amount}");
        NotifyBidders(bidder, amount);
        Console.WriteLine("====================================");
    }

    private void NotifyBidders(IBidder bidder, int amount)
    {
        foreach (var b in bidders)
        {
            if (!b.GetName().Equals(bidder.GetName()))
            {
                b.GetBidNotification(amount);
            }
        }
    }
}