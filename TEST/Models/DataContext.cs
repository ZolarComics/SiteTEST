using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST.Models
{
    public class DataContext : DbContext
    { 
            public DbSet<Shmot> Shmots { get; set; }
            public DbSet<Сheck> Checks { get; set; }

            public DataContext(DbContextOptions<DataContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        
    }
}
