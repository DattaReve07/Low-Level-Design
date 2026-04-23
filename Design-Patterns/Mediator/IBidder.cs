namespace Mediator;

public interface IBidder
{
    void PlaceBid(int amount);
    void GetBidNotification(int bidAmount);
    string GetName();
}