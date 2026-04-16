using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string? Code { get; set; }
        public string? PromotionName { get; set; }
        public int DiscountPercent { get; set; }
        public string? Type { get; set; } // Percentage / Fixed
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
