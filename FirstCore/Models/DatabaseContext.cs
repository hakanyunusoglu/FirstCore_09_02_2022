using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {
            //startupta da belirtmek gerekli
        }
        public DbSet<Product> Products { get; set; }

    }
}
