using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace CodeFirst
{
    class DBContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }


    }
}
