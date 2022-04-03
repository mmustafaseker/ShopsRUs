using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.Models
{
    public  class InvoiceType:BaseEntitiy
    {
        public string type { get; set; }
        public ICollection<Invoice> Invoices{ get; set; }
    }
}
