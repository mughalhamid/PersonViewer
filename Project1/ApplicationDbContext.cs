using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Project1
{
    //public class ApplicationDbContext
    //{
    //    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    //    public DbSet<Person> Persons { get; set; }
    //}

    //public class BloggingContext : DbContext
    //{

    //    public DbSet<Blog> Blogs { get; set; }
    //}


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Person> Persons { get; set; }
    }




    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        //public List<Post> Posts { get; } = new();
    }
}
