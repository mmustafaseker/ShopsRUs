using Microsoft.EntityFrameworkCore;
using ShopsRUs.Core.Models;
using ShopsRUs.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Repository.Repositories
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {

        public InvoiceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddInvoceAsync(Invoice invoice)
        {
            var role = _context.Users.Include(x => x.Role).FirstOrDefault();
            var InvoiceType = _context.Invoices.Include(x => x.InvoiceType).FirstOrDefault();
            int RoleId = role.RoleId;



            var User = _context.Invoices.Find(invoice.UserId);
            var userTime = User.CreateDate.Year;
            var time = DateTime.Now.Year;
            var invociTypeId = invoice.InvoiceTypeId;

            decimal amount = invoice.Amount;
            decimal discountedAmount = invoice.DiscountedAmount;
            int UsageTime = time - userTime;

            int ind = 0;
            int y;


            if (amount >= 100)
            {
                y = (int)Math.Floor(amount / 100);

                ind = y * 5;

                discountedAmount = amount - ind;

                if (invociTypeId != 1)
                {
                    if (RoleId == 1)
                    {
                        discountedAmount = discountedAmount - (discountedAmount * 0.3m);
                    }
                    else if (RoleId == 2)
                    {
                        discountedAmount = discountedAmount - (discountedAmount * 0.1m);

                    }
                    else
                    {
                        if (UsageTime >= 2)
                        {

                            discountedAmount = discountedAmount - (discountedAmount * 0.05m);
                        }

                    }
                }

            }
            else
            {
                if (invociTypeId != 1)
                {
                    if (RoleId == 1)
                    {
                        discountedAmount = amount - (amount * 0.3m);
                    }
                    else if (RoleId == 2)
                    {
                        discountedAmount = amount - (amount * 0.1m);

                    }
                    else
                    {
                        if (UsageTime >= 2)
                        {

                            discountedAmount = amount - (amount * 0.05m);
                        }

                    }
                }

            }
            invoice.DiscountedAmount = discountedAmount;
            invoice.User = User.User;
            invoice.InvoiceType = InvoiceType.InvoiceType;

            await _dbSet.AddAsync(invoice);


        }
    }

}
