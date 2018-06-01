using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionHouseWCFWithElitsa.DAL
{
    public static class AuctionItemRepo
    {
        //declaring the dictionary
        static public Dictionary<int, AuctionItem> auctionItemList;

        static AuctionItemRepo()
        {
            //Initialize the Dictionary
            auctionItemList = new Dictionary<int, AuctionItem>();


              auctionItemList.Add(1, new AuctionItem(auctionItemList.Count + 1, "Item 1", 10.2, 20, "Pedro", "004522336699", DateTime.Now));
              auctionItemList.Add(2, new AuctionItem(auctionItemList.Count + 1,"Item 2", 20.2, 36, "David", "004151515152", DateTime.Now));
              auctionItemList.Add(3, new AuctionItem(auctionItemList.Count + 1, "Item 3", 14, 77, "Elitsa", "115588955625", DateTime.Now));

        }

        static public Dictionary<int, AuctionItem> GetAllItems()
        {
            return auctionItemList;
        }


    }
}