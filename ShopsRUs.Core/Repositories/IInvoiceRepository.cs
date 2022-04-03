using ShopsRUs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.Repositories
{
    public interface IInvoiceRepository: IGenericRepository<Invoice>
    {
        Task AddInvoceAsync(Invoice invoice);

    }
}
