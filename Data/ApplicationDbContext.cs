using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AXSeniors_Reto.Models;
using Microsoft.EntityFrameworkCore;

namespace AXSeniors_Reto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Product { get; set; }

    }
}
