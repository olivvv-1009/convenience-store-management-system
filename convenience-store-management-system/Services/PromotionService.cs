using convenience_store_management_system.Models;
using System;

namespace convenience_store_management_system.Services
{
    public class PromotionService
    {
        public decimal ApplyPromotion(decimal total, Promotion promotion)
        {
            if (promotion == null)
                return total;

            if (!IsValid(promotion))
                return total;

            if (promotion.Type == "Percentage")
            {
                return total * (100 - promotion.DiscountPercent) / 100;
            }

            if (promotion.Type == "Fixed")
            {
                return Math.Max(0, total - promotion.DiscountPercent);
            }

            return total;
        }

        public bool IsValid(Promotion p)
        {
            if (!p.IsActive)
                return false;

            DateTime now = DateTime.Now;

            if (p.StartDate.HasValue && now < p.StartDate.Value)
                return false;

            if (p.EndDate.HasValue && now > p.EndDate.Value)
                return false;

            return true;
        }
    }
}