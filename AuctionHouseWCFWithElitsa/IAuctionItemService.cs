using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AuctionHouseWCFWithElitsa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuctionItemService" in both code and config file together.
    [ServiceContract]
    public interface IAuctionItemService
    {
        [OperationContract]

        Dictionary<int, AuctionItem> GetAllItems();

        [OperationContract]

        AuctionItem GetItemById(int itemNumber);

        [OperationContract]

        string MakeBid(Bid bid);

    }
}
