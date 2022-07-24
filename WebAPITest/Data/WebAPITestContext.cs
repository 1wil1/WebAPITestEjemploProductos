using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPITest.Models;

namespace WebAPITest.Data
{
    public class WebAPITestContext : DbContext
    {
        public WebAPITestContext (DbContextOptions<WebAPITestContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPITest.Models.Productos> Productos { get; set; } = default!;
    }
}
