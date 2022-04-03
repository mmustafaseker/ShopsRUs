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
    public class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(

                new Role { Id = 1, Type = "Employee", DiscountRate = 0.3m, CreateDate = new DateTime() },
                new Role { Id = 2, Type = "Affiliate", DiscountRate = 0.1m, CreateDate = new DateTime() },
                new Role { Id = 3, Type = "Customer", DiscountRate = 0.05m, CreateDate = new DateTime() }
                );
        }
    }
}
