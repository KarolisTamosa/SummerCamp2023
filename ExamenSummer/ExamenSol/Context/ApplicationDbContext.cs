using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;

namespace Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
