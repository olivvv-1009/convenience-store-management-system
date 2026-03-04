using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;

namespace convenience_store_management_system.Services
{
    internal class PromotionService
    {
        public decimal ApplyPromotion(decimal total, Promotion promotion)
        {
            if (promotion == null)
                return total;

            return total - promotion.DiscountValue;
        }
    }
}
