using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.DTOs
{
    public class RoleDto : BaseDto
    {
        public string Type { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
