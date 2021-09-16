using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC2.Models;

namespace SalesWebMVC2.Data
{
    public class SalesWebMVC2Context : DbContext
    {
        public SalesWebMVC2Context (DbContextOptions<SalesWebMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVC2.Models.Department> Department { get; set; }
    }
}
