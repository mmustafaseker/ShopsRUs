using ShopsRUs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.Services
{
    public interface IInvoiceService: IService<Invoice>
    {
        Task<Invoice> AddInvoceAsync(Invoice invoice);

    }
}
