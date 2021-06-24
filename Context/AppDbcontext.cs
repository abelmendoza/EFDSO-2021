using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiVentas.Models;

namespace ApiVentas.Context
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Usuario> usuario { get; set; }

    }
}
