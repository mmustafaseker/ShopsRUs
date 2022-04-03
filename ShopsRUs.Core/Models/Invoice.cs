using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.Models
{
    public class Invoice :BaseEntitiy
    {
        public decimal Amount { get; set; }
        public decimal DiscountedAmount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int InvoiceTypeId { get; set; }
        public InvoiceType InvoiceType { get; set; }

    }
}
