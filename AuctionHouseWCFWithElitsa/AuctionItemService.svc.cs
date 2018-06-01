using AuctionHouseWCFWithElitsa.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AuctionHouseWCFWithElitsa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionItemService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuctionItemService.svc or AuctionItemService.svc.cs at the Solution Explorer and start debugging.
    public class AuctionItemService : IAuctionItemService
    {
        private object _lock = new object();
        public Dictionary<int, AuctionItem> GetAllItems()
        {
            lock (_lock)
            {
                return AuctionItemRepo.GetAllItems();
            }

            
        }

        public AuctionItem GetItemById(int itemNumber)
        {
            AuctionItem auctionItem = null;
            foreach(AuctionItem item in GetAllItems().Values)
            {
                if(item.ItemNumber == itemNumber)
                {
                    auctionItem = item;

                }
                
            }
            return auctionItem;
        }

        public string MakeBid(Bid bid)
        {
            AuctionItem auctionItem = GetItemById(bid.ItemNumber);
            //bid.Price = 100;
            //bid.ItemNumber = 2;
            //bid.CustomPhone = "1515151";
            //bid.CustomPhone = "Joao";
          

            if ( auctionItem != null )
            {
                if(bid.Price > auctionItem.BidPrice)
                {
                    auctionItem.BidPrice = bid.Price;
                    auctionItem.BidCustomName = bid.CustomName;
                    auctionItem.BidCustomPhone = bid.CustomPhone;
                    auctionItem.BidTimeStamp = DateTime.Now;
                    return "OK";
                }

                return "Bid is too low";

            }

                return " Item doesn't exist";

        }
    }
}
