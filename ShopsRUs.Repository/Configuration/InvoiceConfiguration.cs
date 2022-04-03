using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Repository.Configuration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.HasOne(x => x.User).WithMany(x => x.Invoices).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.InvoiceType).WithMany(x => x.Invoices).HasForeignKey(x => x.InvoiceTypeId);
            builder.Property(x => x.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.DiscountedAmount).IsRequired().HasColumnType("decimal(18,2)");


        }
    }
}
