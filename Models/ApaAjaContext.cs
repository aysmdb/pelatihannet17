using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apajaadastore.Models
{
    public class ApaAjaContext : DbContext
    {
        public ApaAjaContext(DbContextOptions<ApaAjaContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
