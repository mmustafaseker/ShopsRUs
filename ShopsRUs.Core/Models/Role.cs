using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.Models
{
    public class Role : BaseEntitiy
    {
        public string Type { get; set; }
        public decimal DiscountRate { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
