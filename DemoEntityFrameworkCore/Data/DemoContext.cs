using Microsoft.EntityFrameworkCore;
using StartupDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEntityFrameworkCore.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options)
            :base(options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}
