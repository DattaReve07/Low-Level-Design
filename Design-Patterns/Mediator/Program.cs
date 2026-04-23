// See https://aka.ms/new-console-template for more information

using Mediator;

Console.WriteLine("============================ Mediator Design Pattern ============================");
Console.WriteLine("============================ online auction system ============================");

IMediator auction = new Auction();

IBidder bidder1 = new Bidder("A", auction);
IBidder bidder2 = new Bidder("B", auction);
IBidder bidder3 = new Bidder("C", auction);
IBidder bidder4 = new Bidder("D", auction);
IBidder bidder5 = new Bidder("E", auction);


bidder1.PlaceBid(100);
bidder2.PlaceBid(150);
bidder3.PlaceBid(200);