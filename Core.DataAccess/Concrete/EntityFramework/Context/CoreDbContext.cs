using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework.Context
{
    public class CoreDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1M9IC7T\SQLEXPRESS;database=CoreBlogDb;Persist Security Info=True;User ID=sa;Password=test");
            //optionsBuilder.UseSqlServer("Server=192.168.1.118;database=CoreBlogDb;Persist Security Info=True;User ID=sa;Password=test");
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;database=CoreBlogDb; Integrated Security=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writter> Writters { get; set; }

    }
}
