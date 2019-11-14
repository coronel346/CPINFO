using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BMTeste.Models
{
    public class BMTesteContext : DbContext
    {
        public BMTesteContext (DbContextOptions<BMTesteContext> options)
            : base(options)
        {
        }

        public DbSet<BMTeste.Models.Usuarios> Usuarios { get; set; }
    }
}
