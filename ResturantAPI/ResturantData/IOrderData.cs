using ResturantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantAPI.ResturantData
{
    interface IOrderData
    {
        Order GetOrder(Order order);
    }
}
