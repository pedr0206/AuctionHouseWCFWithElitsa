using System;
using System.Runtime.Serialization;

namespace AuctionHouseWCFWithElitsa
{
    [DataContract]
    public class AuctionItem
    {
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public string ItemDescription { get; set; }
        [DataMember]
        public double RatingPrice { get; set; }
        [DataMember]
        public double BidPrice { get; set; }
        [DataMember]
        public string BidCustomName { get; set; }
        [DataMember]
        public string BidCustomPhone { get; set; }
        [DataMember]
        public DateTime BidTimeStamp { get; set; }

        public AuctionItem( int itemNumber, string itemDescription, double ratingPrice, double bidPrice, string bidCustomName, string bidCustomPhone, DateTime bidTimeStamp)
        {
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            RatingPrice = ratingPrice;
            BidPrice = bidPrice;
            BidCustomName = bidCustomName;
            BidCustomPhone = bidCustomPhone;
            BidTimeStamp = bidTimeStamp;
        }

        public AuctionItem()
        {

        }

    }
}