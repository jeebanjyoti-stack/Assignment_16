using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAssignment16.Models;

namespace WebAppAssignment16.Data
{
    public class EmpDb16Context : DbContext
    {
        public EmpDb16Context (DbContextOptions<EmpDb16Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppAssignment16.Models.Emp> Emp { get; set; } = default!;
    }
}
