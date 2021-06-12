using ResturantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantAPI.ItemData
{
    public interface IItemData
    {
        List<Item> GetItems();

        Item GetItem(Guid ItemId);

        Item AddItem(Item item);

        Item EditItem(Item item);

        List<Item> GetItemByCatAndSubCat(string Cat, string SubCat);
    }
}
