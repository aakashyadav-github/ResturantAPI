using ResturantAPI.ItemData;
using ResturantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ResturantAPI.ResturantData
{
    public class SqlItemData : IItemData
    {
        private ResturantContext _itemContext;

        public SqlItemData(ResturantContext itemContext)
        {
            _itemContext = itemContext;
        } 

        public Item AddItem(Item item)
        {
            item.ItemId = Guid.NewGuid();
            _itemContext.Items.Add(item);
            _itemContext.SaveChanges();
            return item;
        }

        public Item EditItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid ItemId)
        {
            return _itemContext.Items.Find(ItemId);
        }

        public List<Item> GetItemByCatAndSubCat(string Cat, string SubCat)
        {
            return _itemContext.Items.FromSqlRaw("Select * from dbo.Items where Cat='"+Cat+"'AND SubCat='"+SubCat+"'").ToList();
        }

        public List<Item> GetItems()
        {
            return _itemContext.Items.ToList();
        }
    }
}
