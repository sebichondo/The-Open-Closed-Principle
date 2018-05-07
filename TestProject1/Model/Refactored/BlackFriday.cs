using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommerceProject.Model.Refactored
{
    public class BlackFriday : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 1m;
            
            return total-1000;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("BF");
        }
    }
}
