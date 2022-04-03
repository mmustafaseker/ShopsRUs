using AutoMapper;
using ShopsRUs.Core.Models;
using ShopsRUs.Core.Repositories;
using ShopsRUs.Core.Services;
using ShopsRUs.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Service.Services
{
    public class InvoiceService : Service<Invoice>, IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public InvoiceService(IGenericRepository<Invoice> repository, IUnitOfWork unitOfWork, IInvoiceRepository invoiceRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Invoice> AddInvoceAsync(Invoice invoice)
        {
            await _invoiceRepository.AddInvoceAsync(invoice);
            await _unitOfWork.CommitAsync();
            return invoice;

        }
    }
}
