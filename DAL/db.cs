using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BE;
using System.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DAL
{
  public  class BloggingContext : IdentityDbContext<UserApp>
    {
        public BloggingContext() : base(){ }
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=abolfazl;User ID=sa;Password=123456;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<course_datailfile> course_Datailfiles { get; set; }
        public DbSet<teacher_course> teacher_Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_course> Order_Courses { get; set; }
    }

    
    
}
