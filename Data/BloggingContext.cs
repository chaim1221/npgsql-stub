using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stub.PostgreSQL;

    public class BloggingContext : DbContext
    {
        public BloggingContext (DbContextOptions<BloggingContext> options)
            : base(options)
        {
        }

        public DbSet<stub.PostgreSQL.Blog> Blog { get; set; }
    }
