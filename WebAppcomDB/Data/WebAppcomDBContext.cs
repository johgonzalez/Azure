using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppcomDB.Models;

namespace WebAppcomDB.Data
{
    public class WebAppcomDBContext : DbContext
    {
        public WebAppcomDBContext (DbContextOptions<WebAppcomDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppcomDB.Models.Usuario> Usuario { get; set; }
    }
}
