using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRIMER_MVC.Models;

namespace PRIMER_MVC.Data
{
    public class PRIMER_MVCContext : DbContext
    {
        public PRIMER_MVCContext (DbContextOptions<PRIMER_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<PRIMER_MVC.Models.Restaurante> Restaurante { get; set; } = default!;
    }
}
