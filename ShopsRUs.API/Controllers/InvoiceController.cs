using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Core.DTOs;
using ShopsRUs.Core.Models;
using ShopsRUs.Core.Services;

namespace ShopsRUs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Invoice> _service;
        private readonly IInvoiceService _InvoiceService;

        public InvoiceController(IMapper mapper, IService<Invoice> service, IInvoiceService ınvoiceService)
        {
            _mapper = mapper;
            _service = service;
            _InvoiceService = ınvoiceService;
        }

        [HttpPost]
        public async Task<IActionResult> Save(InvoiceDto invoiceDto)
        {
            var invoices = await _InvoiceService.AddInvoceAsync(_mapper.Map<Invoice>(invoiceDto));
            var invoicesDto = _mapper.Map<InvoiceDto>(invoices);
            return CreateActionResult(CustomResponseDto<InvoiceDto>.Success(201, invoiceDto));
        }
    }
}
