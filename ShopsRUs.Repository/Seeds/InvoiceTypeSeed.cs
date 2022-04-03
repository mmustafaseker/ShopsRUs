using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Repository.Seeds
{
    public class InvoiceTypeSeed : IEntityTypeConfiguration<InvoiceType>
    {
        public void Configure(EntityTypeBuilder<InvoiceType> builder)
        {
            builder.HasData(
                new InvoiceType { Id = 1,type= "Groceries" },
                new InvoiceType { Id = 2,type= "Textile" },
                new InvoiceType { Id = 3,type= "Stationary" }
                );
        }
    }
}
