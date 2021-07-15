using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eval_iv_mateo_lopez.Models;
using Microsoft.EntityFrameworkCore;

namespace eval_iv_mateo_lopez.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
