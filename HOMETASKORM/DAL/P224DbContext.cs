using HOMETASKORM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOMETASKORM.DAL
{
    public class P224DbContext:DbContext
    {
        public P224DbContext(DbContextOptions<P224DbContext>options) :base(options){}
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
