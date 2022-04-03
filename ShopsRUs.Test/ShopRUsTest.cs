using AutoMapper;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using ShopsRUs.Core.Models;
using ShopsRUs.Core.Repositories;
using ShopsRUs.Core.UnitOfWorks;
using ShopsRUs.Repository;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShopsRUs.Test
{
    public class Tests
    {
        protected readonly AppDbContext _context;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Invoice> _repository;
        public Tests(AppDbContext context, IInvoiceRepository invoiceRepository, IMapper mapper, IUnitOfWork unitOfWork, IGenericRepository<Invoice> repository)
        {
            _context = context;
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{
        //    ShopsRUs.Service.Services.InvoiceService _invoiceService = new Service.Services.InvoiceService(_repository, _unitOfWork, _invoiceRepository, _mapper);
        //    //ShopsRUs.Repository.Repositories.InvoiceRepository _invoiceRepository = new Repository.Repositories.InvoiceRepository(_context);
        //    var result = _invoiceService.AddInvoceAsync(new Invoice { Amount = 100, InvoiceTypeId = 2, UserId = 1 });
        //    Assert.That(result, Is.Not.Null);
        //}

        [Test]
        public async Task AddInvoiceAsyncTest()
        {
            ShopsRUs.Service.Services.InvoiceService _invoiceService = new Service.Services.InvoiceService(_repository, _unitOfWork, _invoiceRepository, _mapper);
            //ShopsRUs.Repository.Repositories.InvoiceRepository _invoiceRepository = new Repository.Repositories.InvoiceRepository(_context);
            var result = _invoiceService.AddInvoceAsync(new Invoice { Amount = 100, InvoiceTypeId = 2, UserId = 1 });

            using var app = new InvoiceEndpointTestApp(x =>
            {
                x.AddSingleton(result);
            });

            var httpClient = app.CreateClient();

            var response = await httpClient.GetAsync("api/Invoice/Save");
            var responseText = await response.Content.ReadAsStringAsync();
            var InvoiceResult = JsonSerializer.Deserialize<Invoice>(responseText);

            Assert.That(InvoiceResult, Is.Not.Null);
        }


    }
}

internal class InvoiceEndpointTestApp : WebApplicationFactory<Invoice>
{
    private readonly Action<IServiceCollection> _servisCollection;
    public InvoiceEndpointTestApp(Action<IServiceCollection> servisCollection)
    {
        _servisCollection = servisCollection;
    }
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.ConfigureServices(_servisCollection);
        return base.CreateHost(builder);
    }
}