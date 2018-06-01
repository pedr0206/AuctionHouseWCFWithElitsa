using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AuctionHouseWCFWithElitsa
{
    [DataContract]
    public class Bid
    {
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string CustomName { get; set; }
        [DataMember]
        public string CustomPhone { get; set; }

        //public Bid(int itemNumber, double price, string customName, string customPhone)
        //{
        //    ItemNumber = itemNumber;
        //    Price = price;
        //    CustomName = customName;
        //    CustomPhone = customPhone;

        //}
        //public Bid()
        //{

        //}




    }
}