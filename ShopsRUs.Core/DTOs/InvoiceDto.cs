using ShopsRUs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.DTOs
{
    public class InvoiceDto : BaseDto
    {
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public int InvoiceTypeId { get; set; }

    }
}
