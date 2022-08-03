namespace AuctionHouse.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }
        public int StartingPrice { get; set; }
        public int LastBid { get; set; }
    }
}
