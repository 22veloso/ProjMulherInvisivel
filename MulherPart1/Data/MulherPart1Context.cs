using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MulherPart1.Models;

namespace MulherPart1.Data
{
    public class MulherPart1Context : DbContext
    {
        public MulherPart1Context (DbContextOptions<MulherPart1Context> options)
            : base(options)
        {
        }

        public DbSet<MulherPart1.Models.Cliente> Cliente { get; set; } = default!;
    }
}
