using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WriteItDown.Models;

namespace WriteItDown.Data
{
    public class WriteItDownContext : DbContext
    {
        public WriteItDownContext (DbContextOptions<WriteItDownContext> options)
            : base(options)
        {
        }

        public DbSet<WriteItDown.Models.Category> Category { get; set; }
    }
}
