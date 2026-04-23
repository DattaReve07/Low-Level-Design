namespace Mediator;

public interface IMediator
{
    void RegisterBidder(IBidder bidder);
    void PlaceBid(IBidder bidder, int amount);
}