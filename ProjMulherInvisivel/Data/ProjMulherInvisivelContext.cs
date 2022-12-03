using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjMulherInvisivel.Models;

namespace ProjMulherInvisivel.Data
{
    public class ProjMulherInvisivelContext : DbContext
    {
        public ProjMulherInvisivelContext (DbContextOptions<ProjMulherInvisivelContext> options)
            : base(options)
        {
        }

        public DbSet<ProjMulherInvisivel.Models.Cliente> Cliente { get; set; } = default!;
    }
}
