using ShopsRUs.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Core.DTOs
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public int Active { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

    }
}
