using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebApplication1.Models.AppModel;

namespace WebApplication1
{
    public class MyDbContext : DbContext

    {

        public MyDbContext(DbContextOptions<MyDbContext> options)

        : base(options)

        { }


        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

    }


}
