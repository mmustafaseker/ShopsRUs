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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, CreateDate = new DateTime(),RoleId=1,Active=1,Name= "Mustafa",Surname="Şeker", UserName="MustafaSeker",UsageTime=1 },
                new User { Id = 2, CreateDate = new DateTime(),RoleId=2,Active=1,Name= "Osman",Surname="Şahin", UserName="OsmanOsman",UsageTime=3 },
                new User { Id = 3, CreateDate = new DateTime(),RoleId=3,Active=1,Name= "Bilge",Surname="Gelir", UserName="BilgeGe",UsageTime=5 }
                );
        }
    }
}
