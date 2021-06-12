using ResturantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantAPI.ResturantData
{
    public class SqlOrderData : IOrderData
    {
        private ResturantContext _orderContext;

        public SqlOrderData(ResturantContext orderContext)
        {
            _orderContext = orderContext;
        }

        public Order GetOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
